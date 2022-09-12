using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Win64CPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Utils.PrintMessage(ConsoleColor.Cyan, "C# calling cpp code windows 64....Press any key to start...");
            Console.ReadKey();


            Console.WriteLine("Accessing cpp 64 bit code...");
            CppConnector connector = new CppConnector();
            bool connect = connector.InitializeCppInstance();

            if(!connect)
            {
                Utils.PrintMessage(ConsoleColor.Red, "Fail to connect to cpp....");
                Console.ReadKey();
                return;
            }

            Utils.PrintMessage(ConsoleColor.Green, "Integer Manipulation through c++");
            Utils.PrintMessage(ConsoleColor.Blue, connector.IntegerManipulationFromCpp(5, 3).ToString());
            Console.WriteLine();

            Thread.Sleep(2000);


            Utils.PrintMessage(ConsoleColor.Green, "Float Manipulation through c++");
            Utils.PrintMessage(ConsoleColor.Blue, connector.FloatManipulationFromCpp(5.5F, 3.3F).ToString());
            Console.WriteLine();

            Thread.Sleep(2000);

            Utils.PrintMessage(ConsoleColor.Green, "String Manipulation through c++");
            Utils.PrintMessage(ConsoleColor.Blue, connector.StringManipulationFromCpp("String", "Concatenation"));
            Console.WriteLine();

            Thread.Sleep(2000);

            // End of execusion
            Thread.Sleep(1000);
            Utils.PrintMessage(ConsoleColor.Cyan, "Execusion complete....Press any key to exit...");
            Console.ReadKey();
        }
    }
}
