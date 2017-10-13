using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Samples
{
    public class ApplicationUtilities
    {
        public static void DisplayApplicationInformation()
        {
            Console.WriteLine("It's all about arrays in this program");
            Console.WriteLine("Designed by: Rufus A. Bell Sr.");
            Console.WriteLine();
        }
        public static void DisplayDivider(string outputTitle)
        {
            Console.WriteLine("\n********* " + outputTitle + " *********\n");
        }
        public static void TerminateApplication()
        {
            DisplayDivider("Program Termination");
            Console.Write("Thank you.  Press any key to terminate the program...");
            Console.ReadLine();
        }
        public static void PauseExecution()
        {
            Console.Write("\nProgram paused, press any key to continue...");
            Console.ReadLine();
            Console.WriteLine();
        }
    }
}
