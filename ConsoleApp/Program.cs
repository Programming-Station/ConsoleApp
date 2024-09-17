using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WAP To Print Table using by the user
            int a;
            Console.Write("Enter Any Number And Find Table = ");
            a=Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(a*i);
            }
            Console.ReadLine();
        }
    }
}
