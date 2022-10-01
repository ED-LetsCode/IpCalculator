using System.Text.RegularExpressions;

namespace IpCalculatorLibrary
{
    /// <summary>
    /// This class calculates the properties from a ip adress with subnet suffix<br/>
    /// Before instancing an object of this class call the static function CheckIfIpIsValid to check if the ip adress is valid<br/>
    /// </summary> 
    public class IPCalculator : ICalculateIP
    {
        #region Properties
        public string IpProperties =>   $"Input:            {UserInput}\n" +
                                        $"Subnet Mask:      {SubnetMask} \n" +
                                        $"Host parts:       {HostParts} \n" +
                                        $"Network Adress:   {NetworkAdress} \n" +
                                        $"Broadcast Adress: {BroadcastAdress} \n" +
                                        $"First Host:       {FirstHost} \n" +
                                        $"Last Host:        {LastHost}";
        public string? UserInput { get; }
        public int? HostParts { get; }
        public string? NetworkAdress { get; }
        public string? BroadcastAdress { get; }
        public string? SubnetMask { get; }
        public string? LastHost { get; }
        public string? FirstHost { get; }
        #endregion


        #region Constructors
        /// <summary>
        /// parameter <paramref name="ipAdressWithSubnetSuffix"/> should look like this example => 192.168.1.0/24
        /// </summary>
        /// <param name="ipAdressWithSubnetSuffix"></param>
        public IPCalculator(string ipAdressWithSubnetSuffix)
        {
            UserInput = ipAdressWithSubnetSuffix;
            byte[] ipOctetsByte = new byte[4]; //byte array of ip octets
            byte[] subnetMaskByteArray = new byte[4];
            int hostParts, subnetSuffix = 0;
            string binarySubnetMask = string.Empty;

            SplitIpAdress(ipAdressWithSubnetSuffix, ref subnetSuffix, ref ipOctetsByte);
            HostParts = hostParts = CalculateHosts(subnetSuffix);
            SubnetMask = GetSubnetMask(subnetSuffix, ref binarySubnetMask, ref subnetMaskByteArray);
            LastHost = GetLastNetworkAdress(1, ipOctetsByte, subnetMaskByteArray);
            BroadcastAdress = GetLastNetworkAdress(0, ipOctetsByte, subnetMaskByteArray);
            FirstHost = GetFirstNetworkAdress(1, ipOctetsByte, subnetMaskByteArray);
            NetworkAdress = GetFirstNetworkAdress(0, ipOctetsByte, subnetMaskByteArray);
        }
        #endregion

        #region Functions
        /// <summary>
        /// Splits the ip adress and subnet prefix with following seperators [".", "/"] and saves it to an array.
        /// </summary>
        public void SplitIpAdress(string ipAndSubnet, ref int subnetSuffix, ref byte[] ipOctetsByte)
        {
            string[] tmpStringArray = ipAndSubnet.Split("./".ToCharArray());
            for (int i = 0; i < 4; i++) { ipOctetsByte[i] = (byte)Convert.ToInt32(tmpStringArray[i]); }
            subnetSuffix = int.Parse(tmpStringArray.Last());
        }

        /// <summary>
        /// Calculates the hosts from a network range and returns it back.<br/>
        /// networkID and broadcastID is substracted <br/>
        /// </summary>
        /// <returns> number of hosts within a network range</returns>
        public int CalculateHosts(int subnetSuffix) => (int)Math.Pow(2, 32 - subnetSuffix) - 2;

        /// <summary>
        /// Converts a subnet suffix to a subnetmask
        /// </summary>
        /// <returns>string subnetmask</returns>
        public string GetSubnetMask(int subnetSuffix, ref string binarySubnetMask, ref byte[] subnetMaskByteArray)
        {
            for (int i = 0; i < 32; i++) { binarySubnetMask = i < subnetSuffix ? binarySubnetMask += "1" : binarySubnetMask += "0"; }

            subnetMaskByteArray[0] = (byte)Convert.ToInt32(binarySubnetMask.Substring(0, 8), 2);
            subnetMaskByteArray[1] = (byte)Convert.ToInt32(binarySubnetMask.Substring(8, 8), 2);
            subnetMaskByteArray[2] = (byte)Convert.ToInt32(binarySubnetMask.Substring(16, 8), 2);
            subnetMaskByteArray[3] = (byte)Convert.ToInt32(binarySubnetMask.Substring(24, 8), 2);

            return $"{subnetMaskByteArray[0]}.{subnetMaskByteArray[1]}.{subnetMaskByteArray[2]}.{subnetMaskByteArray[3]}";
        }

        /// <summary>
        /// Calculates the first network adress <br/>
        /// If you write 0 as add parameter, you will get the network adress exmaple 192.168.1.0 <br/>
        /// If you write 1 as add parameter, you will get the first usable hostadress from a network example 192.168.1.1
        /// </summary>
        /// <returns>string ip adress</returns>
        public string GetFirstNetworkAdress(int add, byte[] ipOctetsByte, byte[] subnetMaskByte) =>
                                                      $"{ipOctetsByte[0]  & subnetMaskByte[0]}." +
                                                      $"{ipOctetsByte[1]  & subnetMaskByte[1]}." +
                                                      $"{ipOctetsByte[2]  & subnetMaskByte[2]}." +
                                                      $"{(ipOctetsByte[3] & subnetMaskByte[3]) + add}";

        /// <summary>
        /// Calculates the last network adress <br/>
        /// If you write 0 as subtract parameter, you will get the broadcast adress exmaple 192.168.1.255 <br/>
        /// If you write 1 as subtract parameter, you will get the last usable hostadress from a network example 192.168.1.254
        /// </summary>
        /// <returns>string ip adress</returns>
        public string GetLastNetworkAdress(int subtract, byte[] ipOctetsByte, byte[] subnetMaskByte) =>
                                                      $"{(byte)((ipOctetsByte[0]) | ~subnetMaskByte[0])}." +
                                                      $"{(byte)((ipOctetsByte[1]) | ~subnetMaskByte[1])}." +
                                                      $"{(byte)((ipOctetsByte[2]) | ~subnetMaskByte[2])}." +
                                                      $"{(byte)((ipOctetsByte[3]) | ~subnetMaskByte[3]) - subtract}";

        /// <summary>
        /// Checks if ip is valid and returns bool
        /// </summary>
        /// <returns>If ip is valid then return true else false</returns>
        public static bool CheckIfIpIsValid(string? userInput) => new Regex(@"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\/([1-9]|[1-2][0-9]|3[0-2])$").IsMatch(userInput);
        

        /// <summary>
        /// Creates a .txt file and write ip properties in file
        /// </summary>
        public void CreateAndWriteFile(string path) => new StreamWriter(path).WriteLine(IpProperties);
        

        #endregion
    }
}
