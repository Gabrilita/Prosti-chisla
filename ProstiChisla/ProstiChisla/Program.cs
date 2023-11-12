using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProstiChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi chislo");
            int newNum = int.Parse(Console.ReadLine());

            Prime prostoChislo= new Prime();
            Console.WriteLine($"Chisloto {newNum} e prosto {prostoChislo.Prosto(newNum)}");
        }
    }
}
