using System.Data;
using System.Linq.Expressions;
using System.Reflection;

namespace NesneTabanliDers6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string ayrac = new string('-', 20);
            int[] dizi = new int[10];
            Random rnd = new Random();
            int randomdeger;
            Console.WriteLine("{0}\nrandom sınıfını kullanarak dizi oluşturma\n{0}\nDizinin elemanları:", ayrac,ayrac);
            for (int i = 0; i < dizi.Length; i++)
            {
                randomdeger = rnd.Next(100);
                dizi[i] = randomdeger;
                Console.WriteLine("[{0}]",dizi[i]);
                //Console.Write("[" + dizi[i] +"]")
            }
            Console.WriteLine("\n" + ayrac);
            */

            /*
            string[] isimler = new string[10];
            isimler[0] = "Ömer";
            isimler[1] = "mert";
            isimler[2] = "emre";
            isimler[3] = "oktay";
            isimler[4] = "ihsan";
            isimler[5] = "ali";
            isimler[6] = "mahmut";
            isimler[7] = "mustafa";
            isimler[8] = "fatma";
            isimler[9] = "ayşe";
            for (int i = 0; i<isimler.Length;i++)
                Console.WriteLine(isimler[i]);
            Console.WriteLine("===========================");
            Random rnd = new Random();
            int rastgele = rnd.Next(0,isimler.Length);
            Console.WriteLine("seçilen isim: {0}", isimler[rastgele]);
            Console.ReadKey();
            */

            /*
            //{30,19,122,10,710,1,2,88} elemanlarından oluşan bir dizi tanımla
            //bu dizinin elemanlarınıı küçükten büyüğe sıralayan kodu yaz.
            //bu dizinin elemanlarını büyükten küçüğe sıralayan kodu yaz.
            int[] sayidizisi = { 30, 19, 122, 10, 710, 1, 2, 88 };
            Console.WriteLine("dizinin ilk hali:");
            for (int i = 0; i < sayidizisi.Length; i++)
                Console.Write(sayidizisi[i] + " ");
            Console.WriteLine();
            Array.Sort(sayidizisi);
            for (int i = 0; i < sayidizisi.Length; i++)
                Console.Write(sayidizisi[i]+" ");
            Console.WriteLine();
            Array.Reverse(sayidizisi);
            for (int i = 0; i < sayidizisi.Length; i++)
                Console.Write(sayidizisi[i]+" ");
            */

            /*
            string str = "asdsdfdfgfghghjhjkjklklşlşişiaias";
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            str =new string(chars);
            Console.WriteLine(str);
            */


            /*
            int[] dizi1 = { 1, 2, 3, 4 };
            int[] dizi2 = new int[10];
            int[] dizi3 = new int[10];
            
            dizi1.CopyTo(dizi2 , 2);
            foreach (int i in dizi2)
                Console.WriteLine(i);
            
            Console.WriteLine();
            Array.Copy(dizi1, 2, dizi3, 3, 2);
            foreach (int i in dizi3)
                Console.WriteLine(i);
            */

            /*
            char[] isimsoyisim = { 'E', 'M', 'R', 'E', 'Ç', 'E', 'L', 'E', 'N' };
            char[] kopya = new char[5];

            string ayrac = new string('-', 20);

            Console.Write("{0}\n-> İsim:", ayrac);
            for (int i = 0; i < 4; i++)
                Console.Write(isimsoyisim[i]);

            Console.Write("\n->Soyisim:");
            for (int i = 0; i < isimsoyisim.Length; i++)
                Console.Write(isimsoyisim[i]);
            Console.WriteLine("\n{0}\n< İsimSoyisim dizisinden kopyalanan değer >\n{1}",ayrac,ayrac);
            Array.Copy(isimsoyisim, 2, kopya, 0, 5);
            for (int i = 0; i < kopya.Length; i++)
                Console.Write(kopya[i]);
            Console.WriteLine("\n"+ayrac);
            */


            /*
            //aşağıdaki elemanlardan oluşan bir dizi oluştur bu dizinin en büyük elemanını ve bulunduğu indeksi yazdır.
            //{627,234,127,6,17,987,636,473}
            //hoca uzun bir çözüm yaptı,almadım, benim çözümüm:
            int[] sayidizisi = { 627, 234, 127, 6, 17, 987, 636, 473 };
            int buyuksayi = 0;
            int index = 0;
            for (int i = 1; i < sayidizisi.Length; i++)
            {
                if (buyuksayi < sayidizisi[i])
                {
                    buyuksayi = sayidizisi[i];
                    index = i;
                }
            }
            Console.WriteLine("En büyük sayı {0},bulunduğu index :{1}",buyuksayi, index);
            */

            /*
            //int türünden bir dizinin elemanlarını sıralayan bir program yazınız.
            //sıralama yapılırken array sınıfının sort() metodu kullanılmayacaktır.
            
            //benim cozumum:
            int bardak;
            int[] dizi = { 13, 226, 335, 41, 5632, 653, 712, 835, 9241, };

            for (int i = 0; i <dizi.Length; i++)
            {
                for (int j = 0; j < dizi.Length-1; j++)
                {
                    if (dizi[j] > dizi[i])
                    {
                        bardak = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j]=bardak;
                    }
                }
            }
            foreach (int i in dizi)
                Console.WriteLine(i);
            */
            /*
            //hocanın cozumu:
            int[] dizi = { 13, 226, 335, 41, 5632, 653, 712, 835, 9241, }
            ;
            int gecici, j;
            for(int i = 0;i <dizi.Length;i++)
            {
                if (dizi[i] < dizi[i-1])
                {
                    gecici = dizi[i];
                    for (j = i; j > 0 && gecici < dizi[j - 1]; j--)
                        dizi[j] = dizi[j - 1];
                    dizi[j] = gecici;
                }
            }
            foreach (int i in dizi)
                Console.WriteLine(i);
            */
            //char türünde bir dizinin elemanlarını array sınıfının reverse() metodunu kullanmadan ters çeviren bir program yazınız.
            //benim cozumum:
            /*
            char[] chars = { 'a', 'c', 'd', 'j', 'f', 'o', 'd', 'i' };
            char[] gecici = new char[chars.Length];
            for (int i = 0;i<chars.Length;i++)
            {
                gecici[i] = chars[chars.Length-1-i];
            }
            gecici.CopyTo(chars, 0);
            foreach (char c in chars)
                Console.WriteLine(c);
            */
            /*
            //hocanın cozumu:
            char[] dizi = { 'a', 'c', 'd', 'j', 'f', 'o', 'd', 'i' };
            char gecici;
            for(int i = 0; i < dizi.Length; i++)
            {
                //dizi.length=5
                //dizi.length/2 = 2(tam sayıya bölme olduğu için)
                //yani i değerleri 0 ve 1 olacak
                //amaç:dizinin ilk yarısıyla son yarısına yer değiştirmek
                gecici = dizi[i];
                dizi[i] = dizi[dizi.Length - 1-i];
                dizi[dizi.Length-1-i] = gecici;
                //bu klasik bir yer değiştirme işlemidir. her adımda dizinin başındaki eleman ile sondaki eleman yer değiştiriyor.
            }
            foreach (char c in dizi)
                Console.WriteLine(c);
            */

            
            //Elemanları 1-100 arasında rastgele değerler olan int türünden 20 elemanlı bir dizideki elemanın sayısal ortalamasını
            //en büyük değeri ve en küçük değeri bulan bir program yazınız.
            //benim cozumum
            /*
            Random rnd = new Random();
            int[] dizi = new int[20];
            for (int i = 0; i < dizi.Length; i++)
                dizi[i] = rnd.Next(0,100);
            int max = dizi[0];
            int min = dizi[0];
            int top = dizi[0];
            for (int i = 1;i<dizi.Length;i++)
            {
                if (max < dizi[i])
                    max = dizi[i];
                if (min > dizi[i])
                    min = dizi[i];
                top += dizi[i];
            }
            Console.WriteLine("Dizideki en büyük sayı:{0}\nDizideki en küçük sayı:{1}\nDizideki sayıların ortalaması:{2}",max, min, (top / dizi.Length));
            */
            /*
            //hocanın cozumu
            int[] dizi = new int[20];
            Random rnd = new Random();
            int max = 0, min=100, toplam = 0;
            for(int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(0,100);
                if (max < dizi[i])
                    max = dizi[i];
                if (min > dizi[i])
                    min = dizi[i];
                toplam += dizi[i];
            }
            Console.WriteLine("Dizideki en büyük sayı:{0}\nDizideki en küçük sayı:{1}\nDizideki sayıların ortalaması:{2}", max, min, ((float)toplam / dizi.Length));
            */

            /*
            //oluşturulan metod statik değil ise o sınıftan bir nesne oluşturmak şarttır!!
            //geri dönüş değei olmayan metodlar void anahtar sözcüüğü ile bildirilmelidir.
            int sonuc = Ilkmetot(3, 5);
            Console.Write(sonuc);
            float snc = Ilkmetot(3, 2);
            Console.Write(snc);
            double sn = Ilkmetot(3, 2);
            Console.Write(sn);
            byte a = 10;
            yaz(a);
            //yaz(12.3);
            */

            /*
            int sayi1,sayi2;
            Console.WriteLine("sayıları girin:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            sayi2 = Convert.ToInt32(Console.ReadLine());
            int max = EnBuyuk2(sayi1,sayi2);
            Console.WriteLine("en büyük sayı:{0}",max);
            */
        }
        static int Ilkmetot(int a,int b)
        {
            return a + b;
        }
        static void yaz(int a)
        {
            Console.WriteLine(a); 
        }

        static int EnBuyuk2(int a, int b)
        {
            if (a > b)
                return a;
            return b;
        }



    }
}
