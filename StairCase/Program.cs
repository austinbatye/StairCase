using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StairCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of stairs: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string spaces = new String(' ', (n - i));
                string sharps = new String('#', i);
                Console.WriteLine($"{spaces}{sharps}");
            }
        }
    }
}
