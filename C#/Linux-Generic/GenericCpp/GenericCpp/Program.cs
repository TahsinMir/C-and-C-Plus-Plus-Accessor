using System;

namespace GenericCpp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing generic cpp dll");
            SampleCppConnector.SampleCppConnector connector = new SampleCppConnector.SampleCppConnector();

            string result = connector.TestFunctionWithCpp("Test");
            Console.WriteLine(result);
        }
    }
}
