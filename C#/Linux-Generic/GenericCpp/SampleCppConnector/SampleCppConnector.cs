using System;
using System.Runtime.InteropServices;

namespace SampleCppConnector
{
    public class SampleCppConnector
    {
        // insert the source location here
        private const string PathCpp = "/home/tahsin/Desktop/myProj/C-and-C-Plus-Plus-Accessor/C#/Linux-Generic/GenericCpp/CPP/libProject.so";


        // instance
        private IntPtr instance;

        // Linux
        [DllImport(PathCpp, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        private static extern IntPtr CreateInstaceGeneric();

#pragma warning disable CA2101 // Specify marshaling for P/Invoke string arguments
        [DllImport(PathCpp, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
#pragma warning restore CA2101 // Specify marshaling for P/Invoke string arguments
        private static extern void VoidTest(IntPtr instance, string key);

#pragma warning disable CA2101 // Specify marshaling for P/Invoke string arguments
        [DllImport(PathCpp, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
#pragma warning restore CA2101 // Specify marshaling for P/Invoke string arguments
        private static extern IntPtr TestFunction(IntPtr instance, string key);
        // private static extern string TestFunction(IntPtr instance, string key);

        public SampleCppConnector()
        {
            this.instance = IntPtr.Zero;            
        }

        public bool CreateInstance()
        {
            try
            {
                this.instance = CreateInstaceGeneric();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            return true;
        }

        /*private void PrintMessage(ConsoleColor foregroundColor, string message)
        {
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(message);

            Console.ResetColor();
        }*/

        public void VoidTestWithCpp(string s)
        {
            VoidTest(this.instance, s);
        }

        public string TestFunctionWithCpp(string s)
        {
            IntPtr objPtr = TestFunction(this.instance, s);
            string objectStr = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(objPtr);
            // string objectStr = TestFunction(this.instance, s);
            return objectStr;
        }
    }
}
