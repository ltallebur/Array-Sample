using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Samples
{
    class Simple_Array
    {
        public static void testArray()
        {
         int num = 0;
            int[] test = new int[4];
                for (int cal = 0; cal < 4; cal++)
                {
                   num++;
                
                   Console.WriteLine("Enter number "  +num + ": ");
                   test[cal] = Convert.ToInt32(Console.ReadLine());
                }


                Console.WriteLine("Your numbers entered are listed below \n");

                for (int cal = 0; cal < 4; cal++)
                {
                    Console.WriteLine( test[cal] + "\n");
                }

 

        }
    }
}
