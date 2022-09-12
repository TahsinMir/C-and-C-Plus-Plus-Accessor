using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Win64CPP
{
    public class CppConnector
    {
        private const string Path64 = "D:\\codeRepos\\CCPLUSPLUSACCESSOR\\C-and-C-Plus-Plus-Accessor\\C#\\Win64\\Win64CPP\\x64\\Debug\\CPP.dll"; // the directory where the dll file is generated

        // x64
        [DllImport(Path64, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        private static extern IntPtr CreateInstaceWin64();

        [DllImport(Path64, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        private static extern int IntegerManipulation(IntPtr instance, int x, int y);

        [DllImport(Path64, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        private static extern float FloatManipulation(IntPtr instance, float x, float y);


        [DllImport(Path64, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.BStr)]
        private static extern string StringManipulation(IntPtr instance, string x, string y);

        private IntPtr instance;


        public CppConnector()
        {
            this.instance = IntPtr.Zero;
            string dir = Directory.GetCurrentDirectory();
            Console.WriteLine(dir);
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

        public float FloatManipulationFromCpp(float x, float y)
        {
            return FloatManipulation(this.instance, x, y);
        }

        public string StringManipulationFromCpp(string x, string y)
        {
            return StringManipulation(this.instance, x, y);
        }
    }
}
