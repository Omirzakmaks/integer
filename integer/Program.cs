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
            Console.WriteLine($"juzdik= {A / 100}");
        }
        static void int10()
        {
            Console.Write("Uw oryndy san engiz:  ");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine($"birlik= {(A % 100) % 10}, ondyk= {(A % 100) / 10}");
        }

        static void int11()
        {
            Console.Write("Uw oryndy san engiz: ");
            int A = int.Parse(Console.ReadLine());
            int juzdik = A / 100;
            int ondyk = A % 100 / 10;
            int birlik = A % 100 % 10;
            Console.WriteLine($"kobeitindi={juzdik * ondyk * birlik}");
        }
        static void int12()
        {
            Console.Write("Uw oryndy san engiz: ");
            int A = int.Parse(Console.ReadLine());
            int juzdik = A / 100;
            int ondyk = A % 100 / 10;
            int birlik = A % 100 % 10;
            Console.WriteLine($"orny auskan can={juzdik + ondyk * 10 + birlik * 100}");
        }
        static void int13()
        {
            Console.Write("Uw oryndy san engiz: ");
            int A = int.Parse(Console.ReadLine());
            int juzdik = A / 100;
            int ondyk = A % 100 / 10;
            int birlik = A % 100 % 10;
            Console.WriteLine($"orny auskan can={juzdik * 10 + ondyk * 100 + birlik }");
        }
        static void bool1()
        {
            int a = int.Parse(Console.ReadLine());
            bool m = (a > 0);
            if (m)
                Console.WriteLine("Число A является положительным");
            else
                Console.WriteLine("Число A является отрицательный или ноль");

        }
        static void if1()
        {
            Console.Write("san engiz:");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                a++;
                Console.WriteLine($"a+1={a}");
            }
            else
                Console.WriteLine($"a= {a}");
        }
        static void if2()
        {
            Console.Write("san engiz:");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
                Console.WriteLine($"a+1={a++}");
            else
                Console.WriteLine($"a-(-2)= {a + 2}");
        }
        static void if3()
        {
            Console.Write("san engiz:");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
                Console.WriteLine($"a+1={a++}");
            else if (a < 0)
                Console.WriteLine($"a-(-2)= {a + 2}");
            else
                Console.WriteLine(10);
        }
        static void if4()
        {
            Console.Write("san engiz:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("san engiz:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("san engiz:");
            int c = int.Parse(Console.ReadLine());
            int s = 0;
            if (a > 0)
                s++;
            if (b > 0)
                s++;
            if (c > 0)
                s++;
            Console.WriteLine($"on sandar sany={s}");

        }

        static void if5()
        {
            Console.Write("san engiz:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("san engiz:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("san engiz:");
            int c = int.Parse(Console.ReadLine());
            int s = 0;
            int x = 0;
            if (a > 0)
                s++;
            else if (a < 0)
                x++;
            if (b > 0)
                s++;
            else if (b < 0)
                x++;
            if (c > 0)
                s++;
            else if (c < 0)
                x++;
            Console.WriteLine($"on sandar sany: {s}");
            Console.WriteLine($"teris sandar sany: {x} ");

        }
        static void if6()
        {
            Console.Write("san engiz:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("san engiz:");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
                Console.WriteLine($"ulken san= {a}");
            else if (a < b)
                Console.WriteLine($"ulken san= {b}");
            else
                Console.WriteLine("Eki san ten");

        }
        static void if7()
        {
            Console.Write("san engiz:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("san engiz:");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
                Console.WriteLine($" 1-wi san ulken ");
            else if (a < b)
                Console.WriteLine($" 2-wi san ulken ");
            else
                Console.WriteLine("Eki san ten");

        }
        static void if8()
        {
            Console.Write("san engiz:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("san engiz:");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"ulken san= {a}");
                Console.WriteLine($"kiwi  san= {b}");
            }

            else if (a < b)
            {
                Console.WriteLine($"ulken san= {b}");
                Console.WriteLine($"kiwi  san= {a}");
            }
            else
                Console.WriteLine("Eki san ten");

        }
        static void if9()
        {
            Console.Write("'a' sany:");
            float a = float.Parse(Console.ReadLine());
            Console.Write("'b' sany :");
            float b = float.Parse(Console.ReadLine());
            float c;
            if (a < b)
            {
                c = a;
                a = b;
                b = c;
                Console.WriteLine($"a = {a}");
                Console.WriteLine($"b = {b}");
            }
            else
            {
                Console.WriteLine($"a = {a}");
                Console.WriteLine($"b = {b}");
            }


        }
        static void if10()
        {
            Console.Write("'a' sany:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("'b' sany :");
            int b = int.Parse(Console.ReadLine());
            if (a!=b)
            Console.WriteLine($"eki san ten bolmasa: a+b = {a+b}");
            else
            {
                a=b = 0;
                Console.WriteLine($"eki san ten bolganda = {a}");
                Console.WriteLine($"eki san ten bolganda = {b}");
            }


        }
        static void if11()
        {
            Console.Write("'a' sany:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("'b' sany :");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                b = a;
                Console.WriteLine($"eki san ten bolmasa: a= {a}, b={b}");
            }
                
            else if (a<b)
            {
                a = b;
                Console.WriteLine($"eki san ten bolmasa: a= {a}, b={b}");
            }
            else
            {
                a = b = 0;
                Console.WriteLine($"eki san ten bolganda = {a}");
                Console.WriteLine($"eki san ten bolganda = {b}");
            }
        }
        static void if12()
        {
            Console.Write("a sanyn engiz:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b sanyn engiz:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c sanyn engiz:");
            int c = int.Parse(Console.ReadLine());
            if(a < b && a < c)
                Console.WriteLine($"En kiwi san:{a}");
            else if(b<a&&b<c)
                Console.WriteLine($"En kiwi san:{b}");
            else
                Console.WriteLine($"En kiwi san:{c}");
        }
        static void if13()
        {
            Console.Write("a sanyn engiz:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b sanyn engiz:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c sanyn engiz:");
            int c = int.Parse(Console.ReadLine());
            if (a < b && b < c || a > b && b > c)
                Console.WriteLine($"orta san:{b}");
            else if (b < a && a < c || b > a && a > c)
                Console.WriteLine($"orta san:{a}");
            else if (c > a && b > c || c < a && b < c)
                Console.WriteLine($"orta san:{c}");
        }
        static void Main(string[] args)
        {
            if13();

            Console.ReadKey();
        }
    }
}
