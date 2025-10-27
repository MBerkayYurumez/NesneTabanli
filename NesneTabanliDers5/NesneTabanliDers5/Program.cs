namespace NesneTabanliDers5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //dizi tanımlamak için, tip dizi_ismi = new tip[elemansayisi];
            int[] sayilar = new int[5];
            //veya, int[] sayilar;
            //      sayilar=new int[5];

            //indexe veri atamak için , dizi_ismi[indeks numarası] = 0;
            sayilar[0] = 1;

            //dizinin belli bir indeksini başka bir değişkene atamak için
            int sayi = sayilar[0];
            */

            /*
            //bir dizinin boyutu belirlendikten sonra artık değiştirilemez!
            short[] futbolcular = new short[11];
            futbolcular[0] = 1;
            futbolcular[1] = 2;
            futbolcular[2] = 3;
            futbolcular[3] = 5;
            futbolcular[4] = 8;
            futbolcular[5] = 12;
            futbolcular[6] = 28;
            futbolcular[7] = 37;
            futbolcular[8] = 44;
            futbolcular[9] = 56;
            futbolcular[10] = 61;
            
            foreach(short futbolcu  in futbolcular)
            {
                Console.WriteLine(futbolcu);
            }

            //veriptipi[] diziadi = new veritipi[dizide tutulacak eleman sayisi] {dizide tutulacak değerler}; şeklinde de tanımlama yapılabilir.
            */

            /*
            string[] isimler = new string[30];
            Console.WriteLine(isimler.Length);
            short[] futboltakimi = { 1, 4, 5, 2, 8, 12, 19, 99, 22, 10, 11 };
            Console.WriteLine(futboltakimi.Length);
            */

            /*
            //dizinin belli sayıdaki elemanın sıfırlamak için clear  metodu kullanılır örneğin, Array.clear(diziadi,baslangicindexi,kacindexsifirlanacak);
            //reverse metodu dizinin tamamını ters çevirmek için kullanılır
            //Array.Reverse(dizi);
            //Array.Reverse(dizi,1,3);

            int[] dizi = { 50, 63, 64, 75 };
            //1. elemandan itibaren, 2 index siler
            Array.Clear(dizi, 1, 2);
            foreach(int i in dizi)
            {
                Console.WriteLine(i);
            }
            //dizideki tüm elemanları siler.
            Array.Clear(dizi,0,dizi.Length);
            foreach (int i in dizi)
            {
                Console.WriteLine(i);
            }
            */

            /*
            //Reverse metodu dizi elemanlarının sıralamasını indeks sırasına göre tersine çevirir.
            char[] harfler = { 'a', 'b', 'c' };
            Array.Reverse(harfler);
            Console.WriteLine(harfler[2]);
            //Sort metodu dizi elemanlarını dizinin tipine bağlı olarak sıralar dizi
            //metinsel ise alfabetik olarak, numerikise rakamların büyüklüğüne göre sıralama yapılır.
            char[] harflerr = { 'c', 'b', 'a' };
            Array.Sort(harflerr);
            Console.WriteLine(harflerr[2]);
            */

            /*
            int[] sayilar1 = { 15, 3, 27, 9, 1 };
            Console.WriteLine("Sıralamadan önce");
            foreach(int s in  sayilar1)
                 Console.WriteLine(s +" ");
            //diziyi küçükten büyüğe sıralar.
            Array.Sort(sayilar1);
            Console.WriteLine("\nSıralamadan sonra:");
            foreach (int s in sayilar1)
                Console.WriteLine(s+" ");
            */

            /*
            string[] isimler = {"Emre","Mustafa","Ömer","Oktay","Ali İhsan","Mert" };
            string[] isimdizisi = {"Emre","Mustafa","Ömer","Oktay","Ali İhsan","Mert" };

            //dizilerin eşitliğini kontrol edelim
            if (isimler.SequenceEqual(isimdizisi)==true)
                Console.WriteLine("Tanımlamış olduğunuz dizilerin elemanları birbirine eşittir.");
            else
                Console.WriteLine("Tanımlamış olduğunuz dizilerin elemanları birbirine eşit değildir.");
            */


            /*
            decimal[] Sonuclar = { 78, 99, 100, 12 };
            decimal maksimum = 100;
            Console.WriteLine(Array.IndexOf(Sonuclar, maksimum).ToString());
            */

            /*
            //BinarySearch metodu, bir nesneyi dizi içinde arrar, eğer bulursa bulduğu nesnenin indeksini tutar. bulamazsa negatif bir sayı tutar.
            //BinarySearch metodunun kullanılabilmesi için dizi tek boyutlu olmalıdır
            string[] dizi = { "ayşe", "osman", "ömer", "yakup", "meltem" };
            Array.Sort(dizi);
            Console.WriteLine(Array.BinarySearch(dizi, "osman"));
            Console.WriteLine(Array.BinarySearch(dizi,1,2, "osman"));
            string a = "selam";
            */

            /*
            string[] dizi = new string[5];
            string str;
            int indeks;
            dizi.SetValue("Sefer", 0);
            dizi.SetValue("Feride", 1);
            dizi.SetValue("Gökçen", 2);
            dizi.SetValue("İhsan", 3);
            dizi.SetValue("Yusuf", 4);
            Console.Write("Aranacak yazı: ");
            str = Console.ReadLine();
            Array.Sort(dizi);
            indeks = Array.BinarySearch(dizi, str);
            if (indeks < 0)
                Console.WriteLine("Yazı bulunamadı...");
            else
                Console.WriteLine("Yazının bulunduğu indeks numarası : {0}", indeks);
            */

            /*
            //getlength metodu dizinin boyunu öğrenmek için kullanılır.
            int[,] dizi = { { 1, 2, 3, 8 }, { 4, 5, 6, 9 }, { 5, 6, 7, 10 } };
            Console.WriteLine("Satır sayısı: "+dizi.GetLength(0));
            Console.WriteLine("Sütun sayısı: " + dizi.GetLength(1));
            */

            /*
            //üç boyutlu bir dizi tanımlayarak bu dizinin tüm
            //elemanlarını alt alta ekrana yazdıran kodu geliştirelim
            int[,,] a = { { { 1, 2, 3, }, { 4, 5, 6 } }
                         ,{ { 7, 8, 9, }, { 10, 11, 12 } }
                         ,{ { 13,14,15}, { 16,17,18 } } };

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    for (int k = 0; k < a.GetLength(2); k++)
                        Console.Write(a[i, j, k]+" ");
                    Console.WriteLine();
                }Console.WriteLine();
            }
            //fibonacci dizisinin ilk 20 elemanını dizi yardımıyla hesaplayan ve ekrana yazdıran c# programını geliştiriniz.
            int[] fibonacci = new int[20];
            fibonacci[0] = 1;
            fibonacci[1] = 1;
            for (int i = 2;i < fibonacci.Length;i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            foreach (int i in fibonacci)
                Console.WriteLine(i);
            Console.WriteLine();

            //tanımladığınız iki boyutlu bir dizinin en küçük elemanını bulan c# programını geliştiriniz
            int[,] b = { { 8, 12, 22, 7, 13 } , { 14, 4, 11, 8 ,10} };
            int enkucuk = b[0, 0];
            for (int i = 0;i<b.GetLength(0);i++)
            {
                for(int j = 0;j < b.GetLength(1);j++)
                    if (b[i,j]<enkucuk)
                    {
                        enkucuk=b[i,j];
                    }
            }
            Console.WriteLine(enkucuk);
            */
        }
    }
}
