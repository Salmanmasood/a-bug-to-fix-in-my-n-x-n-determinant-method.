using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the no. of rows: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the no. of columns: ");
            int c = int.Parse(Console.ReadLine());
            float[,] a = new float[r+1, c+1];

            for (int i = 1; i <= r; i++)   //taking input
            {
                for (int j = 1; j <= c; j++)
                {
                    Console.Write("\nEnter the value at index A[{0},{1}] :", i, j);
                    a[i, j] = float.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("displaying........");

            for (int i = 1; i <= r; i++) //displaying
            {
                for (int j = 1; j <= c; j++)
                {
                    Console.Write(a[i, j] + "\t");

                }
                Console.WriteLine();

            }


            //method of determinant
            for (int i = 1; i <= r; i++)
            {
                a[1, i] = a[1,i] / a[1, 1]; //making 1st a[1,1] =1 dividing the 1st row by a[1,1] 
            }
            //reduction started
            for (int i = 2; i <= r; i++)
            {

                for (int j = 1; j <= c; j++)
                {
                    //if (a[1, i] < 0)
                    //{
                    //    a[1, i] = a[1, i] * (-1);

                    //}
                    
                    
                        a[j, i] = (a[j, i] - (a[j, 1] * a[1, i]));
                    

                }
            }


            Console.WriteLine("displaying after reduction........");

            for (int i = 1; i <= r; i++) //displaying again....
             {
                for (int j = 1; j <= c; j++)
                {
                    Console.Write(a[i, j] + "\t");

                }
                Console.WriteLine();

            }






            Console.ReadLine();
        }
    }
}
