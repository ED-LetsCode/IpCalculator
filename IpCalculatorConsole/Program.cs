using IpCalculatorLibrary;

namespace IpCalculatorConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(  "██╗██████╗      ██████╗ █████╗ ██╗      ██████╗██╗   ██╗██╗      █████╗ ████████╗ ██████╗ ██████╗\r\n" +
                                "██║██╔══██╗    ██╔════╝██╔══██╗██║     ██╔════╝██║   ██║██║     ██╔══██╗╚══██╔══╝██╔═══██╗██╔══██╗\r\n" +
                                "██║██████╔╝    ██║     ███████║██║     ██║     ██║   ██║██║     ███████║   ██║   ██║   ██║██████╔╝\r\n" +
                                "██║██╔═══╝     ██║     ██╔══██║██║     ██║     ██║   ██║██║     ██╔══██║   ██║   ██║   ██║██╔══██╗\r\n" +
                                "██║██║         ╚██████╗██║  ██║███████╗╚██████╗╚██████╔╝███████╗██║  ██║   ██║   ╚██████╔╝██║  ██║\r\n" +
                                "╚═╝╚═╝          ╚═════╝╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝");
            Console.WriteLine("Enter a ip adress! Example => 192.168.1.1/24");
            Console.ForegroundColor = ConsoleColor.White;

            string? userInput = Console.ReadLine();
            Console.WriteLine();

            //while userinput is invalid user must enter a valid ip adress
            while (!IPCalculator.CheckIfIpIsValid(userInput))
            {
                Console.WriteLine("Enter a valid ip adress");
                userInput = Console.ReadLine();
            }

            IPCalculator ipCalculator = new IPCalculator(userInput);
            Console.WriteLine(ipCalculator.IpProperties);
        }
    }
}