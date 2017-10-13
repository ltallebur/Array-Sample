using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ApplicationUtilities.DisplayApplicationInformation();
            ApplicationUtilities.PauseExecution();
            ApplicationUtilities.DisplayDivider("Simple Array");
            Simple_Array.testArray();
            ApplicationUtilities.DisplayDivider("Simple Array");
            ApplicationUtilities.PauseExecution();
            ApplicationUtilities.DisplayDivider("Multidimensional Array");
            tenByTenArray.multiDem();
            ApplicationUtilities.DisplayDivider("Multidimensional Array");
            ApplicationUtilities.PauseExecution(); 
            ApplicationUtilities.DisplayDivider("Simple String Array");
            simpleStringArray.simpStringArray();
            ApplicationUtilities.DisplayDivider("Simple String Array");
            ApplicationUtilities.TerminateApplication();


        }
    }
}
