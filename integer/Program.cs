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
        static void if14()
        {
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            int c = Convert.ToInt32(Console.ReadLine());
            int max,min;
            if (a <= b && a <= c)
                min = a;

            else if (b <= a && b <= c)
                min = b;
            else
                min = c;
            if (a >= b && a >= c)
                max = a;
            else if (b >= a && b >= c)
                max = b;
            else
                max = c;
            Console.WriteLine($"min san={min}\nmax san={max}");
        }
        static void if15()
        {
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            int c = Convert.ToInt32(Console.ReadLine());
            int min;
            if (a <= b && a <= c)
                min = a;

            else if (b <= a && b <= c)
                min = b;
            else
                min = c;
             Console.WriteLine($"min san={a+b+c-min}\n");
        }
        static void if16()
        {
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            int c = Convert.ToInt32(Console.ReadLine());
            int min;
            if (a <= b && b <= c)
                Console.WriteLine($"a={a*2}, b={b*2}, c={c*2}\n");
            
            else
                Console.WriteLine($"a={a * -1}, b={b * -1}, c={c * -1}\n");
        }
        static void if17()
        {
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a <= b && b <= c)
                Console.WriteLine($"a={a * 2}, b={b * 2}, c={c * 2}\n");
            else if(a >=b && b >= c)
                Console.WriteLine($"a={a * 2}, b={b * 2}, c={c * 2}\n");
            else
                Console.WriteLine($"a={a * -1}, b={b * -1}, c={c * -1}\n");
        }
        static void if18()
        {
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            int c = Convert.ToInt32(Console.ReadLine());
            
            if (a == b )
                Console.WriteLine($"c={3}\n");
            else if (a == c)
                Console.WriteLine($"b={2}\n");
            else
                Console.WriteLine($"a={1}\n");
        }
        static void if19()
        {
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("d=");
            int d = Convert.ToInt32(Console.ReadLine());
            int k=0;
            if (a == b && b == c)
                k = 4;
            else if (a == b && a == d)
                k = 3;
            else if (a == c && c == d)
                k = 2;
            else if(b == c && b == d)
                k = 1;
            Console.WriteLine($"rettik nomer {k}");
        }
        static void if20()
        {
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            int c = Convert.ToInt32(Console.ReadLine());
            int ras1 = Math.Abs(c - a);
            int ras2 = Math.Abs(b - a);
            if (ras2 >= ras1)
                Console.WriteLine($"to4ka 'c' rastoenie={ras1}");
            else  
                Console.WriteLine($"to4ka 'b' rastoenie={ras2}");
        }
        static void if21()
        {
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            
            if (a == 0 && b==0)
                Console.WriteLine(0);
            else if ( a==0)
                Console.WriteLine(1);
            else if(b==0)
                Console.WriteLine(2);
            else
                Console.WriteLine(3);

         }
        static void if22()
        {
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > 0 && b > 0)
                Console.WriteLine(1);

            else if (a < 0&&b>0)
                Console.WriteLine(2);

            else if (a < 0 && b < 0)
                Console.WriteLine(3);

            else if(a > 0 && b < 0)
                Console.WriteLine(4);
            else
                Console.WriteLine("os boinda jatyr");

        }
        static void if23()
        {
            Console.Write("koordinata engiz: a1=");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("b1=");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("koordinata engiz: a2=");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("b2=");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("koordinata engiz: a3=");
            int a3= Convert.ToInt32(Console.ReadLine());
            Console.Write("b3=");
            int b3 = Convert.ToInt32(Console.ReadLine());
            int a4, b4;
            if (a1 == a2)
                a4 = a3;
            else if (a1 == a3)
                a4 = a2;
            else a4 = a1;

            if (b2 == b3)
                b4 = b1;
            else if (b2 == b1)
                b4 = b3;
            else b4 = b2;
            Console.WriteLine($"a4={a4}\tb4={b4}");
                                   
        }
        static void if24()
        {
            Console.Write("x= ");
            int x = Convert.ToInt32(Console.ReadLine());
            double y;
            if (x > 0)
                y = 2 * Math.Sin(x);
            else if (x <= 0)
                y = 6 - x;
            Console.WriteLine($"y= {y}");

        }
        static void if25()
        {
            Console.Write("x= ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y;
            if (x < -2 || x > 2)
                y = 2 * x;
            else
                y = -3 * x;
            Console.WriteLine($"y= {y}");
        }
        static void if26()
        {
            Console.Write("x= ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x <= 0)
                Console.WriteLine(-x);
            else if (x > 0 && x < 2)
                Console.WriteLine(x * x);
            else if (x >= 2)
                Console.WriteLine(4);
        }
        static void if27()
        {
            Console.Write("x= ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 0)
                Console.WriteLine(0);
            else if (x%2==0)
                Console.WriteLine(1);
            else if (x%2!=0)
                Console.WriteLine(-1);
        }
        static void Main(string[] args)
        {
            if23();

            Console.ReadKey();
        }
    }
}
