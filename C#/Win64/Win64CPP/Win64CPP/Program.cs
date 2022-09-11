using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win64CPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Calling Cpp Code Windows 64");
            Console.ReadKey();


            Console.WriteLine("Accessing Cpp 64 code...");
            CppConnector connector = new CppConnector();
            bool connect = connector.InitializeCppInstance();

            if(!connect)
            {
                Utils.PrintMessage(ConsoleColor.Red, "Fail to connect to cpp");
                Console.ReadKey();
                return;
            }

            Utils.PrintMessage(ConsoleColor.Green, "Integer Manipulation through c++");
            Utils.PrintMessage(ConsoleColor.Blue, connector.IntegerManipulationFromCpp(5, 3).ToString());
            Console.WriteLine();

            string messageFromCpp = connector.ReturnAStringFromCpp();
            Console.WriteLine("Returned Message: ");
            Console.WriteLine(messageFromCpp);
            Console.ReadKey();
        }
    }
}
