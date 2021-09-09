using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integer
{
    class Program
    {
        static void int1()
        {
            Console.Write("uzyndyk cm engiz: L= ");
            int L = int.Parse(Console.ReadLine());
            Console.WriteLine($"{L/100}metr");
        }

        static void int2()
        {
            Console.Write("massa kg engiz: M= ");
            int L = int.Parse(Console.ReadLine());
            Console.WriteLine($"{L / 1000}tonna");
        }

        static void int3()
        {
            Console.Write(" razmer file Byte engiz: B= ");
            int L = int.Parse(Console.ReadLine());
            Console.WriteLine($"{L / 1024} kiloByte");
        }
        static void int4()
        {
            Console.Write("Сандар (A>B) шарт бойынша енгиз: A= ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("B= ");
            int B = int.Parse(Console.ReadLine());
                Console.WriteLine($"{A/B}");   
        }

        static void Main(string[] args)
        {
            int4();
            Console.ReadKey();
        }
    }
}
