using System.Data;
using System.Runtime.CompilerServices;

namespace NesneTabanliDers7
{
    class Ogrenci
    {
        public int yas;
    }
    internal class Program
    {
        static int Enbuyuk2(int x, int y)
        {
            if (x > y)
                return x;
            return y;
        }
        static int Enbuyuk3(int x, int y, int z)
        {
            return Enbuyuk2(x, Enbuyuk2(y, z));
        }
        /*
        static void Yazdir(int[] dizi)
        {
            foreach (int i in dizi)
                Console.WriteLine(i);
        }*/
        static void Yazdir(Array dizi, int bicim)
        {
            if (bicim == 0)
                foreach (object i in dizi)
                    Console.WriteLine(i.ToString());
            else
                foreach (object i in dizi)
                    Console.Write(i.ToString()+" ");
        }

        public static void Degerilegecir(int x)
        {
            x = 20;
            Console.WriteLine("metod içinde  sayı: {0}",x);
        }
        static void Degerilegecir(Ogrenci Ogr)
        {
            Ogr.yas = 20;//nesnenin içeriğini değiştirir.
            Ogr = new Ogrenci();//referansı değiştirir ama orijinali etkilemez
        }

        static void Degerrilegecir(ref int x)
        {
            x = 30;
            Console.WriteLine($"metot içinde sayı:{x}");
        }
        static void Degerilegecir(out int x)
        {
            x = 35;
            Console.WriteLine($"metot içindeki sayı:{x}");
        }
        public static void degerilegecir(in int sayi)
        {
            Console.WriteLine($"metod içinde sayı: {sayi}");
        }


        static void Metod1(int x, int y)
        {
            Console.WriteLine("1. metod çağırıldı.");
        }
        static void Metod1(float x, float y)
        {
            Console.WriteLine("2. metod çağırıldı.");
        }
        static void Metod1(string x, string y)
        {
            Console.WriteLine("3. metot çağırıldı.");
        }


        static void Metod2(int x, int y,int z)
        {
            Console.WriteLine("1. metod çağrıldı.");
        }
        static void Metod2(int x, int z)
        {
            Console.WriteLine("2. metod çağrıldı.");
        }
        static void Metod2(int x, int y, double z)
        {
            Console.WriteLine("3. metod çağrıldı.");
        }

        public static double HesaplaAlan(double genislik, double yukseklik)
        {
            return genislik * yukseklik;
        }
        //dairenin alanını hesaplayan metod(aynı isim,farklı parametre)
        public static double HesaplaAlan(double yaricap)
        {
            return Math.PI * yaricap * yaricap;
        }

        static int Toplam (params int[] sayilar)
        {
            if (sayilar.Length == 0)
                return 0;
            else
            {
                int sonuc = 0;
                foreach (int i in sayilar)
                {
                    sonuc += i;
                }
                return sonuc;
            }
        }

        static void Yaz(int bicim, params object[] nesne)
        {
            if (nesne.Length == 0)
                return;
            if (bicim == 0)
                foreach (object o in nesne)
                    Console.Write(o.ToString() + " ");
            else
                foreach (object o in nesne)
                    Console.WriteLine(o.ToString());
        }

        public static void Metod(string a,string b="Ali", int c = 7)
        {
            Console.WriteLine("a=" + a + " b=" + b + " c=" + c.ToString());
        }

        static void Main(string[] args)
        {
            /*
            int sayi1, sayi2, sayi3;
            Console.WriteLine("sayıları girin");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            sayi2 = Convert.ToInt32(Console.ReadLine());
            sayi3 = Convert.ToInt32(Console.ReadLine());

            int max = Enbuyuk3(sayi1,sayi2,sayi3);
            Console.WriteLine("En büyük sayı:{0}",max);

            int[] dizi1 = { 1, 2, 3, 4, 5, 6 };
            float[] dizi2 = { 1.23f, 2.29f, 3.86f, 4.66f, 5.72f, 6.49f };
            char[] dizi3 = {'a','c','d','l','b'};
            Yazdir(dizi1,1);
            Console.WriteLine();
            */
            /*
            int x = 10;
            Console.WriteLine("metod dışında x: {0}",x);
            Degerilegecir(x);
            */

            Ogrenci o = new Ogrenci();
            o.yas = 10;
            Degerilegecir(o.yas);
            Console.WriteLine();

            Console.WriteLine("Metod dışında sayı:{0} ",o.yas);
            Degerrilegecir(ref o.yas);
            Console.WriteLine();

            int x;
            Degerilegecir(out x);//out da değer atamaya gerek yok.
            Console.WriteLine($"metod dışında sayı:{x}");
            Console.WriteLine();

            int y = 10;
            degerilegecir(in y);
            Console.WriteLine($"metod dışında sayı: {y}");
            Console.WriteLine();

            Metod1("deneme", "deneme");
            Metod1(1, 3);
            Metod1(12.3f, 23.76f);
            Console.WriteLine();

            Metod2(5,10);
            Metod2(5,6,10);
            Metod2(10,10,25.4);
            Console.WriteLine();


            double dikdortgenalani = HesaplaAlan(10.0, 5.0);
            double dairealani = HesaplaAlan(7.0);

            Console.WriteLine($"diktörtgenin alanı: {dikdortgenalani}");
            Console.WriteLine($"dairenin alanı: {dairealani}");


            Console.WriteLine(Toplam(1, 2, 3, 4));
            Console.WriteLine(Toplam(135,23,32,55));


            Yaz(1, "deneme", 2.25f, 26.5);
            Yaz(0, 1, 2, 'c');
            Yaz(1);


            Metod("sefer");
            Metod("sefer","algan");
            Metod("sefer", "algan", 10);
            Metod(c: 10, a: "sefer", b: "algan");
        }
    }
}
