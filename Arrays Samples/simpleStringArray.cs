using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Samples
{
    class simpleStringArray
    {
        public static void simpStringArray()
        {
            //Declaring an simplestring array with 3 elements

            string[] array2 = new string[3];
            
            int count = 0;

            //accepting values in the array
            for (int sampRows = 0; sampRows < array2.Length; sampRows++)
            {
                
                Console.WriteLine("\nEnter name: ");
                array2[sampRows] = Console.ReadLine();

            }
                    //Console.WriteLine("\n" + " You're names are: "+ array2[0]+ ", " + array2[1] + ", "  + array2[2] + ","+"\t");
                    Console.WriteLine("\n" + " Welcome: " + array2[0] + ", " + array2[1] + ", " + array2[2]);
            
            //display array
           /* for (int sampRows = 0; sampRows < array2.Length; sampRows++)
            {

                
                Console.WriteLine("\n" + " Welcome: "+ array2[0]+ ", " + array2[1] + ", "  + array2[2] + ","+"\t");
            }
            */


        }
    
    }
}
//"\n" + "The name entered was: " + "\n"