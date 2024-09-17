using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFrist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add Two Numner using User Input
            int a;
            Console.Write("Enter Frist Number = ");
            a=Convert.ToInt32(Console.ReadLine());
            int b;
            Console.Write("Enter Second Number = ");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of Two Number = "+(a+b));
            Console.ReadLine();
        }
    }
}
