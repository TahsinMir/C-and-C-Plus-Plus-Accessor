using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Win64CPP
{
    public class CppConnector
    {
        private const string Path64 = "D:\\codeRepos\\CCPLUSPLUSACCESSOR\\C-and-C-Plus-Plus-Accessor\\C#\\Win64\\Win64CPP\\Debug\\CPP.dll";


        // x64
        [DllImport(Path64, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        private static extern IntPtr CreateInstaceWin64();

        [DllImport(Path64, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        private static extern int IntegerManipulation(IntPtr instance, int x, int y);


        [DllImport(Path64, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.BStr)]
        private static extern string ReturnAString(IntPtr instance);

        private IntPtr instance;


        public CppConnector()
        {
            this.instance = IntPtr.Zero;
        }

        public bool InitializeCppInstance()
        {
            try
            {
                this.instance = CreateInstaceWin64();
                return true;
            }
            catch (Exception e)
            {
                Utils.PrintMessage(ConsoleColor.Red, "Exception occured during cpp instance initialization!");
                Utils.PrintMessage(ConsoleColor.Yellow, e.ToString());
            }
            return false;
        }

        public int IntegerManipulationFromCpp(int x, int y)
        {
            return IntegerManipulation(this.instance, x, y);
        }

        public string ReturnAStringFromCpp()
        {
            return ReturnAString(this.instance);
        }
    }
}
