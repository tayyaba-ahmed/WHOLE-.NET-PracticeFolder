﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class One_dimen
    {   
        public static void Main() {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
