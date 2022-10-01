namespace IpCalculatorLibrary
{
    internal interface ICalculateIP
    {
        public int CalculateHosts(int subnetSuffix);
        public string GetFirstNetworkAdress(int add, byte[] ipOctetsByte, byte[] subnetMaskByte);
        public string GetLastNetworkAdress(int subtract, byte[] ipOctetsByte, byte[] subnetMaskByte);
        public string GetSubnetMask(int subnetSuffix, ref string binarySubnetMask, ref byte[] subnetMaskByteArray);
        public void SplitIpAdress(string ipAndSubnet, ref int subnetSuffix, ref byte[] ipOctetsByte);
        public void CreateAndWriteFile(string path);
    }
}
