using System.Net.NetworkInformation;

namespace NesneTabanliDers4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //c# da döngüler...
            int toplam = 0;

            for (int i = 1;i<=3;i++)
                toplam= toplam+i;
            //üçü de aynı gösterimi yapar.
            Console.WriteLine("Toplam = {0}",toplam);
            Console.WriteLine("Toplam = " + toplam);
            Console.WriteLine($"Toplam = {toplam}");


            //for(deyim1;deyim2;deyim3;
            char ch;
            for (ch = Convert.ToChar(Console.Read()); ch != 'q'; ch = Convert.ToChar(Console.Read()))
                Console.WriteLine(ch);


            //for döngüsünde parantezin içindeki ifadeler eksik bırakılabilir ancak okunabilirlik açısından kullanılmaması tercih edilebilir.
            int k = 0;

            for(;k<10;k++)
                Console.WriteLine(k);


            //aynı şekilde bazı durumlarda 1. ve 3. kısım da olmayabilir.Şartlar olmasa bile ";" for ifadesinde kullanılmalıdır.
            int l = 0;
            for (;l<10;)
            {
                Console.WriteLine(l);
                l++;
            }
            */



            /*
            //sonsuz döngüler parantizin içi boş bırakılarak yapılabilir
            int m = 0;
            for (; ; )
            {
                Console.WriteLine(m);
                ++m;
            }
            */


            /*
            //1'den 1000' e kadar olan sayılar içerisinde 5' e tam bölünen aynı zamanda 7'ye tam bölünemeyen sayıları sayan,
            //toplamlarını hesaplayan ve bu sayıları listleyen bir program yazınız.
            
            //benim kodum
            int sayilari = 0;
            int toplamlari = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 5 == 0&&i%7!=0)
                {
                    Console.WriteLine(i);
                    toplamlari += i;
                    sayilari++;
                }
            }
            Console.WriteLine(sayilari);
            Console.WriteLine(toplamlari);
            */
            /*
            //cevap:
            int adet = 0, toplam = 0;
            for(int i = 0; i< 1000;i++)
            {
                if((i%5) == 0&&(i%7)!=0)
                {
                    Console.WriteLine(i);
                    toplam += i;
                    adet++;
                }
            }
            Console.WriteLine("Sayı Adedi= "+adet);
            Console.WriteLine("Toplam= "+toplam);
            */

            /*
            //Satır sayısı: 3
            //sütun sayısı: 5
            //******
            //******
            //******

            //yukarıdaki görüntüyü verecek kodu yazınız

            //benim kodum, cevap koduyla minimal farklar var.
            Console.Write("satır sayısı:");
            int satir =Convert.ToInt32(Console.ReadLine());
            Console.Write("sütun sayısı:");
            int sutun =Convert.ToInt32 (Console.ReadLine());
            for (int i =0;i<satir;i++)
            {
                for (int j=0; j < sutun; j++)

                    Console.Write("*");//her sütun için *
                Console.WriteLine();//alt satıra geçmek için
            }
            */



            /*
            //0 ile 100 arasında konsol ekranından girilen 10 notun en büyüğünü, en küçüğünü hesaplayan ve
            //notların ortalamasını bulan bir program yazınız.

            
            //benim kodum
            Console.Write("notunuzu giriniz:");
            int yenisayi = Convert.ToInt32(Console.ReadLine());
            int max=yenisayi;
            int min=yenisayi;
            int toplam = yenisayi;
            for (int i  = 0; i < 9;i++)
            {
                Console.Write("notunuzu giriniz:");
                yenisayi =Convert.ToInt32(Console.ReadLine());
                toplam += yenisayi;
                if(yenisayi>max)
                    max = yenisayi;
                if(yenisayi<min)
                    min = yenisayi;
            }
            Console.WriteLine("En yüksek not: " + max);
            Console.WriteLine("En yüksek not: " + min);
            Console.WriteLine("Ortalama: " + ((double)toplam / 10));
            */
            /*
            //cevap
            int max = 0, min = 100, toplam = 0;
            int adet = 10;
            int not;
            for (int i = 0;i< adet;)
            {
                Console.Write("notu giriniz:");
                not = Convert.ToInt32(Console.ReadLine());
                if(not<0||not>100)
                    Console.WriteLine("Yanlış not!");
                else
                {
                    if(not>max)
                        max = not;
                    else if (not<min)
                        min = not;
                    toplam += not;
                    i++;
                }
            }
            Console.WriteLine("En yüksek not:" + max);
            Console.WriteLine("En düşük not:" + min);
            float ortalama = (float)toplam / adet;
            Console.WriteLine("Ortalama: " + ortalama);
            */


            /*
            //while döngüsü
            int k = 1;
            while (k<=20)
            {
                Console.WriteLine(k);
                k++;
            }
            */
            //0'dan 100' kadar olan çift sayıların toplamı(while ile)
            //benim kodum
            /*
            int i = 0,toplam=0;
            while (i<=100)
            {
                if(i%2==0)
                {
                    toplam += i;
                }
                i++;
            }
            Console.WriteLine(toplam);
            */
            /*
            //cevap
            int i = 0, toplam = 0;
            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                    i = i + 2;
                }
            }
            Console.WriteLine(toplam);
            */

            
            /*
            //do while döngüsü.tipik olarak kullanıcıdan şifre soran programlarda bu döngü yapısı kullanılabilir.
            //başlangıçta sabit bir şifre değeri belirleyin,
            //daha sonra kullanıcııdan şifre girmesini isteyin, şifre doğru ise ekrana bir mesaj yazdırın.(do-while kullanarak)
            string sifredeneme;
            string dogrusifre ="sifrem123degil";
            do
            {
                Console.WriteLine("Şifrenizi Giriniz");
                sifredeneme =(Console.ReadLine());
            } while (dogrusifre != sifredeneme);
            Console.WriteLine("Girilen Şifre doğru.");
            */


            /*
            //atlama(jump) deyimleri
            //break en çok switch yapısında karşımıza çıkar
            //daha önce yaptığımız örneği bir de do while ve break ile yapalım
            char ch;
            do
            {
                Console.Write("Bir karakter giriniz: ");
                ch = Convert.ToChar(Console.ReadLine());
                if (ch == 'q' || ch == 'Q')
                    break;
                else
                    Console.WriteLine("Döngüye devam...");
            }while (true);
            //break anahtar sözcüğünü döngü bloklarının dışında ya da switch bloğunun dışında kullanmak mümkün değildir!
            

            //continue;
            
            int sayi;
            int toplam = 0;
            int bironcekisayi = 0;
            for(; ;)
            {
                Console.Write("Bir sayı girin: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0)
                    break;
                if (sayi == bironcekisayi)
                {
                    Console.WriteLine("Farklı sayı girin");
                    continue;
                }
                toplam += sayi;
                Console.WriteLine("toplam ={0}", toplam);
                bironcekisayi=sayi;
            }
            Console.WriteLine("döngü bitti");
            
            //break ile döngü bitirilirken continue ile sadece döngünün o anki iterasyonu sonlandırılır ve döngüye devam edilir

            //goto gerekmedikçe kullanmıyoruz.
            int say = 0;
        baslangic:
            Console.WriteLine("bir sayı girin(0 ile çıkış): ");
            say = Convert.ToInt32(Console.ReadLine());

            if (say!=0)
            {
                Console.WriteLine("Girdiğiniz sayı: "+say);
                goto baslangic;
            }
            Console.WriteLine("Program sonlandı.");
            */
            //return metotların sonlandırılmasında kullanılır.

        }
    }
}
