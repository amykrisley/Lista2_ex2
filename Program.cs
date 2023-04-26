using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Informe o primeiro valor:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor:");
            b = int.Parse(Console.ReadLine());
            if (a > b)
                Console.WriteLine("o maior valor é: {0}", a);
            else if (a < b)
                Console.WriteLine("o maior valor é: {0}", b);
            else
                Console.WriteLine("os valores são iguais");
        }
    }
}
