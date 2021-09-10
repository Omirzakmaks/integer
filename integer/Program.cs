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
            Console.WriteLine($"{L / 100}metr");
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
            Console.WriteLine($"{A / B}");
        }

        static void int5()
        {
            Console.Write("Сандар (A>B) шарт бойынша енгиз: A= ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("B= ");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine($"{A % B}");
        }
        static void int6()
        {
            Console.Write("Eki oryndy san engiz:  ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine($"ondyk={A / 10 * 10} birlik={A % 10}");
        }
        static void int7()
        {
            Console.Write("Eki oryndy san engiz:  ");
            int A = int.Parse(Console.ReadLine());
            int ondyk = A / 10;
            int birlik = A % 10;
            Console.WriteLine($"kosyndy= {birlik + ondyk}, kobeitindi= {birlik * ondyk}");
        }
        static void int8()
        {
            Console.Write("Eki oryndy san engiz:  ");
            int A = int.Parse(Console.ReadLine());
            int ondyk = A / 10;
            int birlik = A % 10;
            Console.WriteLine($"orny auskan can={birlik * 10 + ondyk}");
        }
        static void int9()
        {
            Console.Write("Uw oryndy san engiz:  ");
            int A = int.Parse(Console.ReadLine());
             Console.WriteLine($"juzdik= {A/100}");
        }
        static void int10()
        {
            Console.Write("Uw oryndy san engiz:  ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine($"birlik= {(A % 100)%10}, ondyk= {(A % 100) / 10}");
        }

        static void int11()
        {
            Console.Write("Uw oryndy san engiz: ");
            int A = int.Parse(Console.ReadLine());
            int juzdik = A / 100;
            int ondyk= A % 100 / 10;
            int birlik = A % 100%10;
            Console.WriteLine($"kobeitindi={juzdik* ondyk* birlik}");
        }
        static void int12()
        {
            Console.Write("Uw oryndy san engiz: ");
            int A = int.Parse(Console.ReadLine());
            int juzdik = A / 100;
            int ondyk = A % 100 / 10;
            int birlik = A % 100 % 10;
            Console.WriteLine($"orny auskan can={juzdik + ondyk *10+ birlik*100}");
        }
        static void int13()
        {
            Console.Write("Uw oryndy san engiz: ");
            int A = int.Parse(Console.ReadLine());
            int juzdik = A / 100;
            int ondyk = A % 100 / 10;
            int birlik = A % 100 % 10;
            Console.WriteLine($"orny auskan can={juzdik*10 + ondyk * 100 + birlik }");
        }
        static void Main(string[] args)
        {
            int13();

            Console.ReadKey();
        }
    }
}
