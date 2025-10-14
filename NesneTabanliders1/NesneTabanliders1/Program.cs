using System.Net.Security;

namespace NesneTabanliders1
{
    class Program1()
    {
        static int a = 10;
        static void Main()
        {
            /*
            Console.WriteLine("Hello World!");
            */


            /*
            Console.WriteLine("Bir tuşa basınız.");
            Console.ReadKey();
            Console.WriteLine("Bir tuşa bastınız.");
            */

            //büyük küçük harf fark eder
            /*
            int ucret = 10;
            int UCRET;
            UCRET = 50;
            Console.WriteLine(ucret);
            Console.WriteLine(UCRET);
            */

            //dış blokta atama yaptıktan sonra iç blokta aynı isimle atama yapamazsın
            /*
            int a;
            {
                int a = 10;
            }
            */


            //main dışında yapılan statik atama etkilemez
            /*
            int a= 5;
            Console.WriteLine(a);
            */


            //sabit değer atamak için
            /*
            const double pi = 3.14;
            pi = 3.1;
            */

            //c sabit bir değer olduğu için hatalı bir atamadır.
            /*
            int a = 3, b;
            b = a;
            const int c = b + a;
            */

            //hatalı bir atamadır.
            /*
            const int a = 5;
            const int b = a + 6;
            Console.WriteLine(b);
            */

            //hatalı bir atamadır.
            /*
            const int a = 3;
            a=a + 1;
            */
            /*
            int tamsayi = new int();
            int tamsayi1 = 0;
            Console.WriteLine(tamsayi);
            Console.WriteLine(tamsayi1);
            */

            /*
            int a = new int();
            char b = new char();
            bool c = new bool();
            float f  =new float();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(f);
            */
            /*
            byte b = 0;
            byte a = 10;
            byte c = 255;
            */
            /*
            float f = 3.12f;
            decimal j = 3.12m;
            Console.WriteLine(f);
            */
            /*
            bool b1 = true;
            bool b2 = false;
            int a = 50;

            bool b3 = a < 60;

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            */
            /*
            char c1 = 'A';
            char c2 = (char)90;
            char c3 = '\u0058';
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            */

            /*
            string s1 = "Hello";
            string s2 = ".NET";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            */
            string s4 = "Escape karakterleri \',\\";
            string s5 = @"Escape karakterleri ',\";
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.ReadLine();

        }
    }
}
