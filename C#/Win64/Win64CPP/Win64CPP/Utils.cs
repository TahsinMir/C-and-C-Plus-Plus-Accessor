using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win64CPP
{
    public static class Utils
    {
        public static void PrintMessage(ConsoleColor foregroundColor, string message)
        {
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
