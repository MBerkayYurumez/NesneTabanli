using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace NesneTabanliDers3
{
    internal class Program
    {
        class Kisi
        {
            public string Ad;
        }
        static void Main(string[] args)
        {
            /*
            //bool b1 = false && false;
            //bool b2 = false & false;

            byte b1 = 255;
            byte b2 = (byte)~b1; //255 in tümleyeni 0 olur.
            Console.WriteLine(b2);
            */

            /*
            //& bitsel ve operatörü
            //10010001
            //01001001
            byte a = 145;
            byte b = 73;
            int c  = (a&b);
            Console.WriteLine(c);
            
            byte a = 145;
            byte x = 255;
            int c= (a & x);//=a
            Console.WriteLine(c);
            */
            /*
            //00001010 10 un bitsel karşılığı
            //01100011 99 un bitsel karşılığı
            byte b = 10;
            byte c = 99;
            Console.WriteLine("ilk değer -> {0}", c);

            c = (byte)(c ^ b);                                   //00001010 ^ 01100011
            Console.WriteLine("ilk XOR ->{0}", c);               //birici XOR 01101001, yani 105

            c = (byte)(c ^ b);                                   //00001010 ^ 01101001 
            Console.WriteLine("ikinci XOR ->{0}", c);            //ikinci XOR 01100011, yani 99
            */

            /*
            //<< sola kaydırma operatörü
            byte b = 130;
            byte c = (byte)(b << 1);

            Console.WriteLine("b={0}", b);
            Console.WriteLine("c={0}", c);

            //>> sağa kaydırma operatörü
            byte d = 11;
            byte e = (byte)(d >> 1);

            Console.WriteLine("b={0}", b);
            Console.WriteLine("c={0}", c);
            */

            /*
            //= atama operatörü
            a= a+b yerine a+=b
            a=a/b yerine a/=b
            a=a^b yerine a^=b
            */

            /*
            //özel amaçlı operatörler
            // ? c# ta 3 operand alan tek operatördür.genellikle ternary operatör olarak adlandırılır. 
            //koşul? doğru_değer:yanlış_değer

            int sayi;
            Console.WriteLine("Kalem sayısını girin : ");
            sayi =  Convert.ToInt32(Console.ReadLine());
            string str = "kalem";
            str = str + (sayi == 1 ? " " : "ler");
            Console.WriteLine(str);
            */

            /*
            //typeof(class)
            //degisken.GetType()
            int sayi = 1;
            Console.WriteLine("typeof(int) : " + typeof(int));
            Console.WriteLine("sayi.GetType() : " + sayi.GetType());

            Kisi kisi = new Kisi();
            kisi.Ad = "Ahmet";
            Console.WriteLine("typeof(Kisi)" + typeof(Kisi));
            Console.WriteLine("kisi.GetType()" + kisi.GetType());
            */

            /*
            //if yapısı
            int a = 5;
            int b = 7;
            if (a < b)
                Console.WriteLine("1. Deyim");
            else
                Console.WriteLine("2. Deyim");



            
            int not;
            Console.WriteLine("Notunuzu giriniz(0-100) : ");
            not = Convert.ToInt32(Console.ReadLine());

            if (not < 0 || not > 100 || not.GetType()!=a.GetType())
            {
                Console.WriteLine("Yanlış not girdiniz.");
            }
            else if (not > 90)
                Console.WriteLine("Notnuz:A");
            else if (not > 80)
                Console.WriteLine("Notnuz:B");
            else if (not > 70)
                Console.WriteLine("Notnuz:C");
            else if (not >= 50)
                Console.WriteLine("Notnuz:D");
            else
                Console.WriteLine("Dersi Geçemediniz.");
            //                                                     |    
            //if ile almadığım örnek var arada, bu kendi örneğim   v
            int birinci, ikinci; float sonuc = 0;

            Console.Write("Birinci sayınız: ");
            birinci = Convert.ToInt32(Console.ReadLine()); Console.Clear();

            Console.Write("Yapılacak işlemi seçiniz (+,-,*,/) :");
            string islem = Console.ReadLine(); Console.Clear();

            Console.Write("İkinci Sayınız: ");
            ikinci = Convert.ToInt32(Console.ReadLine()); Console.Clear();


            if (islem == "+")
            {
                sonuc = birinci + ikinci;
            }
            if (islem == "-")
            {
                sonuc = birinci - ikinci;
            }
            if (islem == "*")
            {
                sonuc = birinci * ikinci;
            }
            if (islem == "/")
            {
                if (ikinci == 0)
                    Console.WriteLine("Bölen 0 olamaz");
                else
                    sonuc = (float)birinci / ikinci;
            }
            Console.Clear(); Console.Write(sonuc);
            */

            /*
            int a = 1;
            switch (a)
            {
                case 1:
                    Console.Write("a değişleninin değeri{0}", a);
                    break;
                case 2:
                    Console.Write("a değişkeninin değeri{0}", a);
                    break;
                default:
                    break;
            }
            */
            /*
            int a = 2;
            switch(a)
            {
                case 1:
                case 2:
                    Console.WriteLine("Case1 ve case2");
                    break;
                case 3:
                    Console.WriteLine("Case 3");
                    break;
                default:
                    break;

            }
            */


            
            int birinci, ikinci; float sonuc=0;

            Console.Write("Birinci sayınız: ");
            birinci = Convert.ToInt32(Console.ReadLine()); Console.Clear();

            Console.Write("1 - Toplama \n2 - Çıkarma \n3 - Çarpma \n4 - Bölme\nYapmak istediğiniz işlemi giriniz: ");

            int islem = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("İkinci Sayınız: ");
            ikinci = Convert.ToInt32(Console.ReadLine()); Console.Clear();

            switch (islem)
            {
                case 1:
                    {
                        sonuc = birinci + ikinci;
                    }
                    break;
                case 2:
                    {
                        sonuc = birinci - ikinci;

                    }
                    break;
                case 3:
                    {
                        
                        sonuc = birinci * ikinci;
                    }
                    break;
                case 4:
                    {
                        if (ikinci == 0)
                            Console.WriteLine("Bölen 0 olamaz.");
                        sonuc = (float)birinci / ikinci;
                        
                    }
                    break;
                default:
                    Console.WriteLine("işlem hatası!");
                    break;
            }
            Console.WriteLine("Sonuç: {0}", sonuc);
        }


    }
}
