using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Jagged
    {
        public static void Main()
        {
            // jagged arrays can have diff col
            int[][] arr = new int[3][]; //rows=3, col not decided
            arr[0] = new int[3] {2,6,4}; // first row have 3 elements and 3 col
            arr[1] = new int[1] { 4 }; // second row have 1 element and 1 col
            arr[2] = new int[2] { 9,3 }; // second row have 2aq element and 2 col
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
