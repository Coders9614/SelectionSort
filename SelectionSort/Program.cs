using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 77, 92, 88, 67, 82 };

            Console.WriteLine("The orignal scores:");
            Display(arr);

            SelectionSort(arr);

            Console.WriteLine("The Assending scores:");
            Display(arr);
            Console.ReadKey();
        }
        static void SelectionSort(int[] arr )
        {
            int n = arr.Length;
            for( int i = 0;i < n; i++ )
            {
                 int midscore =i;
                for( int j = 0;j <n; j++ )
                {
                    if (arr[j] < arr[midscore])
                    {  midscore = j; }
                }
                int temp = arr[midscore];
                arr[midscore] = arr[i];
                arr[i] = temp;
            }
          
        }
       static void Display(int[] arr)
        {
            foreach(int score in arr )
            {
                Console.Write(score + " ");
            }
            Console.WriteLine();
        }
 
    }
}
