using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Lab01_Core
{
    public class SysInfo
    {
        public static void PrintCurrentOSVer()
        {
            Console.WriteLine($"Current OS version: {System.Environment.OSVersion}");
        }

        // Print the current RAM usage
        // Param indicates whether to force a garbage collection before measuring memory usage
        public static void PrintRAMUsage()
        {
            Console.WriteLine($"Total memory usage: {System.GC.GetTotalMemory(false)} bytes");
        }
    }
}
