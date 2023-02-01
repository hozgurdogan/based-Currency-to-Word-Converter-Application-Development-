using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NESNE_ODEV1
{
    static class Class1
    {
        public static int buyuk_harf_sayisi(char[] parola, int uzunluk)
        { 
            //is.upper metodu ile büyük harf sayisi bulunur ve değikene atınır.
            int buyuk_harf_s = 0;
            for (int i = 0; i<uzunluk; i++)
            {
                if (char.IsUpper(parola[i]))
                {
                    buyuk_harf_s++;
                }
            }
            // Console.WriteLine("Buyuk harf sayisi:{0}",buyuk_harf_s);
            return buyuk_harf_s;
        }


        public static int kucuk_harf_sayisi(char[] parola, int uzunluk)
        {
            //is.lower metodu ile küçük harf sayisi hesaplanır ve değişkene atınır.

            int kucuk_harf_sayisi = 0;
            for (int i = 0; i < uzunluk; i++)
            {
                if (char.IsLower(parola[i]))
                {
                    kucuk_harf_sayisi++;
                }
            }
            //      Console.WriteLine("Kucuk harf sayisi:{0}",kucuk_harf_sayisi);


            return kucuk_harf_sayisi;

        }

        public static int rakam_sayisi(char[] parola, int uzunluk)
        {
            //isdigit metodu ile rakam sayisi bulunr rakam sayisi bulunur ve değikene atatnır.
            int rakam_sayisii = 0;
            for (int i = 0; i<uzunluk; i++)
            {
                if (char.IsDigit(parola[i]))
                {
                    rakam_sayisii++;
                };

            }
            //      Console.WriteLine("Rakam sayisi:{0}",rakam_sayisii);
            return rakam_sayisii;
        }
        public static int sembol_sayisi(char[] parola, int uzunluk)
        {
            // harf ve sayi dışındaki karakterleri değişkene atar .

            int sembolsayisi = 0;
            for (int i = 0; i<uzunluk; i++)
            {
                if (!char.IsLetterOrDigit(parola[i]))
                {
                    sembolsayisi++;
                }
            }
            //   Console.WriteLine("Sembol sayisi:{0}", sembolsayisi);


            return sembolsayisi;
        }
    }
}