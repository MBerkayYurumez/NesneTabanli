namespace NesneTabanliDers8
{
    internal class Program
    {
        static int Fibonacci(int a)
        {
            if (a == 0) return 0;
            if (a== 1) return 1;
            return Fibonacci(a - 1) + Fibonacci(a - 2);
        }

        //bir dizideki elemanların toplamını özyinelemeli bulma
        static int DiziToplar(int[] a,int index)
        {
            if (index == 0) 
                return 0;
            return a[index-1] +DiziToplar(a,index - 1);

        }
        //1 den N e kadar olan sayılararı artan sırada özyinelemeli olarak yazdırma
        static void NeKadarYazdir(int a)
        {
            if (a == 0)
                return;
            NeKadarYazdir(a - 1);
            Console.WriteLine(a);
        }
        //sayının basamak toplamını özyinelemeli hesaplama
        static int Basamaktopla(int a)
        {
            if (a == 0)
                return 0;
            return (a % 10) + Basamaktopla(a/10);
        }

        //static void Main(string[] args)
        //{
        //    /*
        //    Console.WriteLine("kaçıncı fibonacci sayısını istiyorsun: ");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.WriteLine($"Fibonacci {a} = {Fibonacci(a)}");*/

        //    /*
        //    int[] dizi = { 1, 2, 3, 4, 5, 6, };
        //    Console.WriteLine(DiziToplar(dizi,dizi.Length));*/
        //    /*NeKadarYazdir(5);*/
        //    int a = Basamaktopla(13);
        //    Console.WriteLine(a);
        //}
    }

    //class ArgumanListe
    //{
    //    static void Main(string[] args)
    //    {
    //        for (int i=0;i<args.Length;++i)
    //        {
    //            Console.WriteLine("{0}. Argüman = {1} ",i, args[i]);
    //        }
    //    }
    //}


    //class Hesapla
    //{
    //    static int Main(string[] args)
    //    {
    //        int len = args.Length;
    //        if(len == 0||len==1||len ==2)
    //        {
    //            Console.WriteLine("Eksik parametre!");
    //            return 1;
    //        }    
    //        if (len > 3)
    //        {
    //            Console.WriteLine("Fazla parametre!");
    //        }
    //        string i = args[0];
    //        if (!(i=="t"||i=="c"||i=="b"||i=="m"))
    //        {
    //            Console.WriteLine("Yanlış işlem!");
    //            return 3;            
    //        }
    //        int sayi1 = Convert.ToInt32(args[1]);
    //        int sayi2 = Convert.ToInt32(args[2]);


    //        switch (i)
    //        {
    //            case "t":
    //                Console.WriteLine("Sonuç : {0}", sayi1 + sayi2);
    //                break;
    //            case "m":
    //                Console.WriteLine("Sonuç : {0}", sayi1 * sayi2);
    //                break;
    //            case "c":
    //                Console.WriteLine("Sonuç : {0}", sayi1 - sayi2);
    //                break;
    //            case "b":
    //                switch(sayi2)
    //                {
    //                    case 0:
    //                        Console.WriteLine("Bölen 0 olamaz!");
    //                        break;
    //                    default:
    //                        float sonuc = (float)sayi1/(float)sayi2;
    //                        Console.WriteLine("Sonuç : {0}", sonuc);
    //                        break;
    //                }break;
    //        }return 0;

    //    }
    //}


    //class E_PI
    //{
    //    static void Main()
    //    {
    //        double e = Math.E;
    //        double pi = Math.PI;
    //        Console.WriteLine($"pi = {pi}");
    //        Console.WriteLine($"e = {e}");
    //    }
    //}


    //class MathMetot
    //{
    //    static void Yaz(object o)
    //    {
    //        Console.WriteLine(o.ToString());
    //    }
    //    static void Main()
    //    {
    //        Yaz(Math.Abs(-10.5));
    //        Yaz(Math.Abs(10));
    //        Yaz(Math.Cos(60));
    //        Yaz(Math.Sin(60));
    //        Yaz(Math.Tan(45));
    //        Yaz(Math.Ceiling(5.6));
    //        Yaz(Math.Floor(5.6));
    //        Yaz(Math.Max(5.56, 6.85));
    //        Yaz(Math.Min(5.56, 6));
    //        Yaz(Math.Pow(2, 3));
    //        Yaz(Math.Sqrt(144));
    //        Yaz(Math.Log(10));
    //        Yaz(Math.Log10(1000));
    //        Yaz(Math.Exp(1));
    //    }
    //}


    //class Hesapla
    //{
    //    static double[] karekokbul(params double[] sayilar)
    //    {
    //        double[] kokler = new double[sayilar.Length];
    //        for(int i = 0;i<sayilar.Length;i++)
    //        {
    //            kokler[i] = Math.Sqrt(sayilar[i]);
    //        }return kokler;
    //    }
    //    static void Main()
    //    {
    //        double[] dizi = karekokbul(2, 4, 9, 144, 500);
    //        foreach(double i in dizi)
    //            Console.WriteLine(i);
    //    }
    //}


    class KrediHesabi
    {
        public ulong HesapNo;
        public double Limit;
        public string KartSahibi;
    }
    //class MainSınıf
    //{
    //    static void Main(string[] args)
    //    {
    //        KrediHesabi Hesap = new KrediHesabi();
    //        Hesap.HesapNo = 5678946985;
    //        Hesap.Limit = 500000;
    //        Hesap.KartSahibi = "Sefer Algan";
    //        Console.WriteLine(Hesap.HesapNo);
    //        Console.WriteLine(Hesap.Limit);
    //        Console.WriteLine(Hesap.KartSahibi);
    //    }
    //}
    //class AnaSınıf
    //{
    //    static void Main(string[] args)
    //    {
    //        KrediHesabi hesap1 = new KrediHesabi();
    //        KrediHesabi hesap2;

    //        hesap1.HesapNo = 5697457458;
    //        Console.WriteLine(hesap1.HesapNo);

    //        hesap2 = hesap1;
    //        Console.WriteLine(hesap2.HesapNo);

    //        hesap2.HesapNo = 1111111111;
    //        Console.WriteLine(hesap1.HesapNo);
    //    }
    //}


    class AnaSınıf
    {
        static void Main()
        {
            int a;
            int b;

            a = 20;
            b = a;

            Console.WriteLine (b);

            b = 10;
            Console.WriteLine (a);
            Console.WriteLine (b);
        }
    }


}
