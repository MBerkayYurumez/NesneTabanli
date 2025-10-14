using System.Runtime.InteropServices;
using System.Text;

namespace NeesneTabanliDers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //matematiksel işlem yapılırken, int veya daha büyük bir türe dönüştürmek gerekir.
            //(en az giren veriler kadar büyük olması gerekir.)

            byte a = 5, b = 10;
            short d = 2, e = 9;
            byte f = a + b;
            short g = d + e;
            Console.WriteLine(g);
            */


            /*
            int a = 10;
            byte b = 20;
            short c = 30;
            double d = a + b + c;
            Console.WriteLine(d);
            */


            /*
            //bir karakter inte dönüşürken, ascii tablosundaki karşılığının değerini alır.
            double c = 16.5f;
            int d = 'a';
            Console.WriteLine(d);
            Console.WriteLine(c);
            */


            /*
            //Hatalı bir dönüştürmedir.
            decimal c = 10;
            byte b = c;
            char d = c;
            Console.WriteLine(d);
            */


            /*
            const double pi = Math.PI;
            Console.WriteLine(pi);
            int tamsayi = (int)pi;  //double -> int  , kesir kısım atılır.
            Console.WriteLine(tamsayi);
            */


            
            int i = 25;
            byte b = (byte)i;
            Console.WriteLine(b);

            int c = 2561;
            byte d = (byte)c;
            Console.WriteLine(d);
            

            
            /*
            //Taşma olacağı için hata verir.
            int i = 256;
            byte b;
            //checked bloğunun içinde yapılan atama dışarıda kullanılamayacağı için atamayı dışarıda yapıyoruz.
            
            checked
            {
                b = (byte)i;
            }
            Console.Write(b);
            */


            //SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS
            /*
            int i = 256;
            int a = 300;
            byte b, c;
            checked
            {
                b = (byte)i;
                unchecked
                {
                    c = (byte)a;
                }
            }
            Console.WriteLine(b);
            */


            /*
            try
            {
                string s1, s2;

                int sayi1, sayi2;
                int Toplam;

                Console.WriteLine("İlk Sayıyı Gir: ");
                s1 = Console.ReadLine();
                sayi1 = Convert.ToInt32(s1);
                //sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("İkinci Sayıyı Gir: ");
                s2 = Console.ReadLine();
                sayi2 = Convert.ToInt32(s2);
                Toplam = sayi1 + sayi2;
                Console.WriteLine("Toplam = " + Toplam.ToString());
            }
            catch
            {
                Console.WriteLine("Yanlış veri tipi! Programı kapatıp tekrar deneyiniz.");
            }
            */



            /*
            Console.WriteLine (3.ToString ());

            string str = 36.6f.ToString();
            Console.WriteLine(str);

            bool b = false;
            int i = Convert.ToInt32(b);
            Console.WriteLine(i);

            int a = 123;
            bool bo = Convert.ToBoolean(a);
            Console.WriteLine(bo);
            int c = 0;

            bool d = Convert.ToBoolean (c);
            Console.WriteLine(d);

            */


            /*
            int a = 5;
            char m = 'k';
            string r = "deneme";
            float f = 12.5f;
            string b = a + m + r + f;
            Console.WriteLine(b);
            */


            /*
            //hata verir, toplamada string bir veri kullanılmadığı için
            int a = 5;
            char m = 'a';
            float f = 12.5f;
            string b = a + m + f;
            Console.WriteLine(b);
            */


            /*
            int a = 10;
            int b = 20;
            int c = 30;
            int d = 40;
            float f = 5.6f;

            a++;
            ++b;
            c--;
            --d;
            f++;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n",
                a,b,c,d,f);
            */


            /*
            int a = 10;
            int b;
            int c;
            b = a++;//b=10 değeri verilir, a nın değeri artırılır(11 olur).
            c = ++a;//a nın değeri artırılır(12 olur), c ye bu değeri atar.

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            */

            /*
            bool b1 = 60 < 50;
            bool b2 = 50 < 50;
            bool b3 = b2;
            bool b4 = b3;
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n", b1,b2,b3,b4);
            */


            /*
            object i = "50";
            string s = i as string;
            Console.WriteLine(s);
            */


            /*
            int i = 50;
            bool b1 = i is int;
            bool b2 = i is string;
            bool b3 = i is object;

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            */




        }
    }
}
