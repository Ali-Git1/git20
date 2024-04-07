using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    public static class Extensions
    {
        public static int[] Add(this int[] arr, int element)
        {
            int[] newarr = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newarr[i] = arr[i];
            }

            newarr[newarr.Length - 1] = element;
            return newarr;
        }
    }
}
