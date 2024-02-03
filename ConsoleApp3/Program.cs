using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        private static int le20;

        static void Main(string[] args)
        {
            Console.WriteLine(0.5 - 0.1 - 0.1 - 0.1 - 0.1 - 0.1);
            Console.WriteLine(3.14 + le20 - le20);
            Console.WriteLine(3.14 + (le20 - le20));
            Console.WriteLine();
            //***********************************************************
            double x = 1 / 2;// int oldugu icin 0 yazdirir
            Console.WriteLine(x);
            //  stringler
            char c = 'a';
            Console.WriteLine((int)c);//char int cevirdik casting islemi
            Console.WriteLine((char)(c + 1));// a dan sonraki harfi yazdırır b
            Console.WriteLine();
           //  *****************************************************
            int b = 65;// a demek integer degeri char a cevirme
            Console.WriteLine((char)(b));
            string d = "a";
            Console.WriteLine(d +"baa" );// sonuna ekleme yapıyor
            Console.WriteLine(d + 5);//sayılarda tırnaga gerek yok
            Console.WriteLine();
           //********************************************************************
            int y = 2;
            Console.WriteLine(y < 1);//bool
            //   Console.WriteLine(1 < y < 3); boyle kullanilmaz yanlis 
            Console.WriteLine(y > 1 && y < 3);
            Console.WriteLine(++y);//3
            Console.WriteLine(y++);//3
            Console.WriteLine(y);//4
            Console.WriteLine();
           //***********************************************************************
            bool e = true;
            bool f = false;
            Console.WriteLine(e || f && !e);//true 
            Console.WriteLine(3 + 5 * 4 % 3 - 2);
            Console.WriteLine();
            //*****************************************************************
            Console.WriteLine("bir sayı gir");
            d = Console.ReadLine();
            b = int.Parse(d);// d string int donustur
            Console.WriteLine(d + 3);//2 girerswn yanına ekler 23 yazar
            Console.WriteLine(b + 3);//5
            Console.WriteLine(d);
            Console.WriteLine();
            //********************************************************************
            b = 5;

           //  Console.WriteLine("{ 0} ----------{ 1}", b, d);//b ve d yi  parantez ici gibi yazar
            double g = 4.567;
            //  Console .WriteLine ("{ 0,1:0#.##}",g); ciktı =04,57
            // console .writeline ("{o} ({1,5:F2})",name,bmi); arthur (21.51) kac haneli
            Random h = new Random();
            b = h.Next(10,20); //10 20 arasi rasgele sayı uretır [10.20) 20 dahıl degıl .double uretmek istersen h.nextdouble yaz
            Console.WriteLine(b);
          
            int ı = 1;//dizilerde deger atama
            int   i= ı;//dizilerde kopyalama ,siğ kopyalama
            ı = 2;
            Console .WriteLine (i);
            Console.WriteLine();
            //***************************************************************************
            int[] j = new int[4];
            j[0] = 1;
            j[1] = 68;
            j[2] = 24;
            j[3] = 56;
            int[] A = { 100, 200, 300, 400 };
            Array.Copy(j, A, 2);
            foreach (int a in A)
            {
                Console.WriteLine(a);
            }
          
            Console.ReadLine();
        }
    }
}
