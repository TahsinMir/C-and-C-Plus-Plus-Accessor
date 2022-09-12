using System;
using System.Runtime.InteropServices;

namespace SampleCppConnector
{
    public class SampleCppConnector
    {
        // insert the source location here
        private const string PathCpp = "/home/tahsin/Desktop/test2/slimPsiClean/Sources/Runtime/NativeMethods/bin/NativeDataStoreLinux.so";


        // instance
        private IntPtr instance;

        // Linux
        [DllImport(PathCpp, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        private static extern IntPtr CreateInstaceGeneric();


#pragma warning disable CA2101 // Specify marshaling for P/Invoke string arguments
        [DllImport(PathCpp, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
#pragma warning restore CA2101 // Specify marshaling for P/Invoke string arguments
        private static extern IntPtr TestFunction(IntPtr instance, string key);

        public SampleCppConnector()
        {
            this.instance = CreateInstaceGeneric();
        }

        /*private void PrintMessage(ConsoleColor foregroundColor, string message)
        {
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(message);

            Console.ResetColor();
        }*/

        public string TestFunctionWithCpp(string s)
        {
            IntPtr objPtr = TestFunction(this.instance, s);
            string objectStr = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(objPtr);
            return objectStr;
        }
    }
}
