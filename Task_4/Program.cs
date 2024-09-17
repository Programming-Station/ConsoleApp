using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WAP to input any number and Find Table
            int a;
            Console.Write("Enter Any Number & Find Table = ");
            a=Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(a*i);
            }
            Console.ReadLine();
        }
    }
}
