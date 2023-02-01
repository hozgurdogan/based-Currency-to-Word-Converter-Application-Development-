
/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:ÖDEV 1
**				ÖĞRENCİ ADI............:Hasan Özgür Doğan
**				ÖĞRENCİ NUMARASI.......:G201210020
**              DERSİN ALINDIĞI GRUP...:A
****************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NESNE_ODEV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parola;

            int uzunluk;




            int kontrol = 1;

            //gerekli olan değişkenleri tanımlıyoruz.
            do
            {
                //do koşul ifadesini tanımlayarak koşulsuz bloğa girer
                int puan = 0;
                kontrol = 1;


                Console.WriteLine("lütfen test için paralanızı giriniz:");
                parola = Console.ReadLine();
                char[] karakterler = parola.ToCharArray(); //stirng olan prola ifadesinin char dizi elemanına convert ediyoruz.
                uzunluk = parola.Length;

                // var olan parolanın içeriğine ait bilgiler verilir...
                Console.Write("eleman sayisi:");
                uzunluk.ToString();
                Console.Write(uzunluk);
                Console.WriteLine();
                Console.WriteLine("Kucuk harf sayisi:{0}", Class1.kucuk_harf_sayisi(karakterler, uzunluk));
                Console.WriteLine("Büyük harf sayisi:{0}", Class1.buyuk_harf_sayisi(karakterler, uzunluk));
                Console.WriteLine("Rakam sayisi:{0}", Class1.rakam_sayisi(karakterler, uzunluk));
                Console.WriteLine("Sembol sayisi:{0}", Class1.sembol_sayisi(karakterler, uzunluk));
                for (int i = 0; i < uzunluk; i++) //boşluk kontrolu yapıyoruz
                {
                    //eger boşluk içeren bi karater varsa kontrol 0 dönüşür.
                    if (karakterler[i] == ' ')
                    {
                        kontrol = 0;

                    }


                }

                Console.WriteLine();

                if (kontrol==1) //eger boşluk içermeyen bi şifreyse diğer koşullara bakılır.
                {

                    if (uzunluk >= 9)   //şifrenin 9  karakterden ve daha fazla olmasına bakılıyor
                    {
                        if (uzunluk == 9)   // gerekli olan puanlama sistemi yapılıyor.
                        {
                            puan = puan + 10;
                        }
                        int kucuk_harf_sayisi = Class1.kucuk_harf_sayisi(karakterler, uzunluk);
                        int buyuk_harf_sayisi = Class1.buyuk_harf_sayisi(karakterler, uzunluk);
                        int rakam_sayisi = Class1.rakam_sayisi(karakterler, uzunluk);
                        int sembol_Sayisi = Class1.sembol_sayisi(karakterler, uzunluk);
                        if (kucuk_harf_sayisi != 0 && buyuk_harf_sayisi != 0 && rakam_sayisi != 0 && sembol_Sayisi != 0)
                        {
                            //gerekli olan karakter sayilari denetleniyor..
                            for (int i = 0; i < uzunluk; i++)   // ve yine boşluk içeren karakter varsa  kontrol değeri 0'a dönüyor.
                            {

                                if (karakterler[i] == ' ')
                                {
                                    kontrol = 0;

                                }


                            }
                            Console.WriteLine();


                            if (kontrol == 1) //ve şifre olma konusunda sıkıntı yoksa (kontrol 1 ise) gerekli olan puanlamalar yapılır...
                            {


                                if (kucuk_harf_sayisi > 0)
                                {
                                    if (kucuk_harf_sayisi == 1)
                                    {
                                        puan = puan + kucuk_harf_sayisi * 10;

                                    }
                                    else if (kucuk_harf_sayisi >= 2)
                                    {
                                        puan = puan + 2 * 10;


                                    }

                                }

                                if (buyuk_harf_sayisi > 0)
                                {
                                    if (buyuk_harf_sayisi == 1)
                                    {
                                        puan = puan + buyuk_harf_sayisi * 10;

                                    }
                                    else if (buyuk_harf_sayisi >= 2)
                                    {
                                        puan = puan + 2 * 10;


                                    }

                                }
                                if (rakam_sayisi > 0)
                                {
                                    if (rakam_sayisi == 1)
                                    {
                                        puan = puan + rakam_sayisi * 10;

                                    }
                                    else if (rakam_sayisi >= 2)
                                    {
                                        puan = puan + 2 * 10;


                                    }

                                }

                                if (sembol_Sayisi != 0)
                                {
                                    puan = puan + sembol_Sayisi * 10;
                                }



                                if (puan>=100)
                                {
                                    puan=100;
                                }

                                Console.WriteLine();

                                Console.WriteLine("ŞİFRE GÜVENLİK PUANINIZ:{0}", puan);
                                if (puan < 70)
                                {
                                    Console.WriteLine("güvenirlik puanı 70 in altında");
                                    Console.WriteLine("Bu şifre kabul edilmez");
                                    kontrol = 0;

                                }
                                else if (puan > 70 && puan < 90)
                                {
                                    Console.WriteLine("Bu şifre kabul edilir");
                                }

                                else if (puan >= 90)
                                {
                                    Console.WriteLine("Bu şifre kabul edilir ve güçlü");
                                }
                            }

                        }
                        else // ve kontrol 0 sa şifre kabul edilemez ilgisi çıkar.
                        {
                            kontrol = 0;
                            Console.WriteLine("Bu şifre kabul edilmez....");
                            Console.WriteLine("Uyarı 9 karakter ve üzeri ise büyük harf, küçük harf, rakam ve sembol sayısının hiçbiri sıfır olmamalı");
                        }


                    }



                    if (uzunluk < 9)
                    {
                        kontrol = 0;
                        Console.WriteLine("Bu şifre kullanılmaz....");
                        Console.WriteLine("Şifre 9 karater altında!!!!!");
                    }

                }
                else if (kontrol == 0)
                {
                    Console.WriteLine("bu şifre kullanılamaz");
                    Console.WriteLine("Şifre boluk karakteri içermemeli....");

                }

                Console.WriteLine("");

            } while (kontrol == 0);
            Console.ReadKey();
        }
    }
}