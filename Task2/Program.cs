using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // WAP To Inpur Any Chercater Find Vowel or Consonant
            char ch;
            Console.Write("Enter Any Charactor =");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'A' || ch=='E' || ch=='I' || ch=='O' || ch=='U' || ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u')
            {
                Console.WriteLine($"{ch} Is Vowel");
            }
            else
            {
                Console.WriteLine($"{ch} Is Consonant");
            }
            Console.ReadLine();
        }
    }
}
