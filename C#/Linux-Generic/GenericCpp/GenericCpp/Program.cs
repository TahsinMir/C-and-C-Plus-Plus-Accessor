using System;

namespace GenericCpp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing generic cpp dll");
            SampleCppConnector.SampleCppConnector connector = new SampleCppConnector.SampleCppConnector();


            bool connect = connector.CreateInstance();
            if (!connect)
            {
                Console.WriteLine("Failed to get instance");
                Console.ReadKey();
                return;
            }
            else {
                Console.WriteLine("instance created. proceeding with test.....");
            }
            connector.VoidTestWithCpp("voidTest");
            string result = connector.TestFunctionWithCpp("Test234567");
            Console.WriteLine("result in C#::");
            Console.WriteLine(result);
            /*Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
            Console.WriteLine(result[2]);*/
            Console.WriteLine(result.Length);
        }
    }
}
