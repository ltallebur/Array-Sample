using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Samples
{
    class tenByTenArray
    {
        public static void multiDem()
        {

            Console.WriteLine("In this example I have created an array that is 10 X 10" + 
                                "\nand we are adding elements from 1 to 100 and" + 
                                "\ncounting by tens on the final column");
            //Declaring an array with 10 rows 10 columns

            int[,] array1 = new int[10, 10];
 

                //accepting values in the array
                for (int rows = 0; rows < 10; rows++)
                {
                    //Console.WriteLine("Enter Row: {0}", rows + 1);


                    for (int columns = 0; columns < 10; columns++)
                    {
                        //array1[rows, columns] = rows + 1;

                        array1[rows, columns] = (rows + 1) * (columns + 1);
                    }

                }


                        //Displaying values of Multidementional array
                        for (int rows = 0; rows < 10; rows++)
                        {

                            Console.WriteLine("Row: {0}", rows + 1);


                            for (int cols = 0; cols < 10; cols++)
                            {
                                Console.Write(array1[rows, cols] + "\t");
                            }
                            Console.WriteLine();
                        }


        }
    }
}
