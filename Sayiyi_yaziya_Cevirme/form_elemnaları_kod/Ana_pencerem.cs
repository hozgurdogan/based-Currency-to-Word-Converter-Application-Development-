

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form_elemnaları_kod
{
    class Ana_pencerem : Form
    {
        //gerekli olan değişkenleri tanımılıyorum
        private Label m_Xlabel;
        private Label m_Ylabel;
        private Button m_button;
        private TextBox m_texbox1;
        private Label m_Ylabel2;

        public int basamak_sayisi;
        public double girilen_sayi;
        public string girilen_sayi_str = "";
        public string virgul = ",";
        public string kurus;
        public Ana_pencerem() //Ana penceremin özeliklerini veriyorum
        {
            Height = 600;
            Width = 800;
            Text = "Fonksiyon Hesabı";
            form_elemaları_olsutur(); //Form elemanlarını oluturduğum fonksiyonu çağırıyorum...

        }

        public void form_elemaları_olsutur() //tüm elamanları oluşturup özelikerlini verdiğim fonksiyon
        {

            m_Xlabel = new Label();

            m_Xlabel.SetBounds(300, 200, 20, 50);
            m_Xlabel.Text = "X";
            Controls.Add(m_Xlabel);

            m_texbox1 = new TextBox();
            m_texbox1.SetBounds(360, 200, 150, 50);
            Controls.Add(m_texbox1);
            m_texbox1.TextChanged += M_texbox1_TextChanged;

            m_Ylabel = new Label();
            m_Ylabel.SetBounds(300, 250, 50, 50);
            m_Ylabel.Text = "Y";
            Controls.Add(m_Ylabel);

            m_Ylabel2 = new Label();
            m_Ylabel2.SetBounds(360, 250, 250, 50);
            m_Ylabel2.Text = "deneme";

            m_Ylabel2.Text = " ";
            Controls.Add(m_Ylabel2);

            m_button = new Button();
            m_button.SetBounds(330, 300, 100, 50);
            m_button.Text = "hesapla";
            Controls.Add(m_button);
            m_button.Click += M_button_Click;
            //özelikler ve eventsler tanımlandı....

        }

        private void M_texbox1_TextChanged(object? sender, EventArgs e) //texboxa da bi karakter değişince çalışan events...(burda daha çok basamak sayisi va max karakter sayisi kontrol ediliyor.

        {

            int basamaksayisi = 0;
            string degisken;
            basamaksayisi = m_texbox1.Text.Length;
            int max_karakter_sayisi = 6;

            bool result2 = m_texbox1.Text.Contains(virgul);
            if (result2 == true)
            {

                string girilen_sayi_basamk_hesabi_icin;
                girilen_sayi_basamk_hesabi_icin = m_texbox1.Text;

                basamaksayisi = m_texbox1.Text.Length;
                string kurus_verisi_basamk_icin;
                kurus_verisi_basamk_icin = girilen_sayi_basamk_hesabi_icin.Split(',').Last();

                int virgul_sonrasi_basamak_sayisi = kurus_verisi_basamk_icin.Length;
                int net_basamak_sayisi;
                net_basamak_sayisi = basamaksayisi - virgul_sonrasi_basamak_sayisi - 1;

                if (virgul_sonrasi_basamak_sayisi == 4)
                {

                    degisken = m_texbox1.Text.Substring(0, m_texbox1.Text.Length - 1);
                    m_texbox1.Text = degisken;
                    MessageBox.Show("max karater sayisi");
                }

                if (net_basamak_sayisi == max_karakter_sayisi)
                {

                    degisken = m_texbox1.Text.Substring(0, m_texbox1.Text.Length - 1);
                    m_texbox1.Text = degisken;
                    MessageBox.Show("max karater sayisi");

                }
            }
            else
            {

                if (m_texbox1.Text.Length == max_karakter_sayisi)
                {

                    degisken = m_texbox1.Text.Substring(0, m_texbox1.Text.Length - 1);
                    m_texbox1.Text = degisken;
                    MessageBox.Show("max karater sayisi");

                }
            }

        }

        private void M_button_Click(object? sender, EventArgs e) //butona tıkalnınca tetiklenen olaylar ,sayilara karşılık gelen yazıları ekrana çıktı veriyor.
        {
            //gerekli olan değişkenler tanımlanıyor.... 
            //ve gerekli olan convert olayları yapılıyor tip dönüşümü uyum için...

            girilen_sayi = Convert.ToDouble(m_texbox1.Text);

            girilen_sayi_str = Convert.ToString(girilen_sayi);

            m_Ylabel2.Text = "";

            double sayi;

            sayi = Convert.ToDouble(m_texbox1.Text);

            int sayi1 = Convert.ToInt32(sayi);
            //switch case yapısı için gerekli değişkenler tanımlanıyor....
            int on_binler, binler, yuzler, onlar, birler;
            //ve gerekli olan matematiksel işlemler yapılıyor...
            on_binler = sayi1 / 10000;

            binler = (sayi1 / 1000) % 10;

            yuzler = (sayi1 / 100) % 10;
            onlar = (sayi1 / 10) % 10;

            birler = sayi1 % 10;

            int tl_kontrol;

            if (sayi1 == 0) //grilen sayinin 0,.... gibi bir sayi olma durumunu kontrol ediyor eger böyle bi değişken varsa ona göre bi önelem alınıcak....
            {
                tl_kontrol = 0;
            }
            else
            {
                tl_kontrol = 1;
            }

            int kontrol = 0;

            if (on_binler != 0) //aynı şekilde girilen sayida onbinler kısmı içinde geçerli yoksa yazımda hata olucaktır.
            {
                kontrol = 1;
            }

            switch (on_binler) //değişkenlere karşılk gelen caseler içinde m_Ylabel2.text içine veriler teker teker yazılıcak.Taa ki birler basamapına kadar.
            {

                default:
                    return;
                case 0:
                    m_Ylabel2.Text = m_Ylabel2.Text + "";
                    break;
                case 1:
                    m_Ylabel2.Text = m_Ylabel2.Text + "on ";
                    break;
                case 2:
                    m_Ylabel2.Text = m_Ylabel2.Text + "yirmi  ";
                    break;
                case 3:
                    m_Ylabel2.Text = m_Ylabel2.Text + "otuz  ";
                    break;
                case 4:
                    m_Ylabel2.Text = m_Ylabel2.Text + "kırk ";
                    break;
                case 5:
                    m_Ylabel2.Text = m_Ylabel2.Text + "elli ";
                    break;
                case 6:
                    m_Ylabel2.Text = m_Ylabel2.Text + "altmış ";
                    break;
                case 7:
                    m_Ylabel2.Text = m_Ylabel2.Text + "yetmiş ";
                    break;
                case 8:
                    m_Ylabel2.Text = m_Ylabel2.Text + "seksen ";
                    break;
                case 9:
                    m_Ylabel2.Text = m_Ylabel2.Text + "doksan ";
                    break;
            }

            switch (binler)
            {
                default:
                    return;
                case 0:
                    {
                        if (kontrol == 1)
                        {
                            m_Ylabel2.Text = m_Ylabel2.Text + "bin";
                        }
                        break;
                    }
                case 1:
                    m_Ylabel2.Text = m_Ylabel2.Text + "bin";
                    break;
                case 2:
                    m_Ylabel2.Text = m_Ylabel2.Text + "iki bin";
                    break;
                case 3:
                    m_Ylabel2.Text = m_Ylabel2.Text + "üç bin";
                    break;
                case 4:
                    m_Ylabel2.Text = m_Ylabel2.Text + "dört bin";
                    break;
                case 5:
                    m_Ylabel2.Text = m_Ylabel2.Text + "beş bin";
                    break;
                case 6:
                    m_Ylabel2.Text = m_Ylabel2.Text + "altı bin";
                    break;
                case 7:
                    m_Ylabel2.Text = m_Ylabel2.Text + "yedi bin";
                    break;
                case 8:
                    m_Ylabel2.Text = m_Ylabel2.Text + "sekiz bin";
                    break;
                case 9:
                    m_Ylabel2.Text = m_Ylabel2.Text + "dokuz bin";
                    break;
            }

            switch (yuzler)
            {
                default:
                    return;
                case 0:
                    m_Ylabel2.Text = m_Ylabel2.Text + "";
                    break;
                case 1:
                    m_Ylabel2.Text = m_Ylabel2.Text + " yüz";
                    break;
                case 2:
                    m_Ylabel2.Text = m_Ylabel2.Text + " iki yüz";
                    break;
                case 3:
                    m_Ylabel2.Text = m_Ylabel2.Text + " üç yüz";
                    break;
                case 4:
                    m_Ylabel2.Text = m_Ylabel2.Text + " dört yüz";
                    break;
                case 5:
                    m_Ylabel2.Text = m_Ylabel2.Text + " beş yüz";
                    break;
                case 6:
                    m_Ylabel2.Text = m_Ylabel2.Text + " altı yüz";
                    break;
                case 7:
                    m_Ylabel2.Text = m_Ylabel2.Text + " yedi yüz";
                    break;
                case 8:
                    m_Ylabel2.Text = m_Ylabel2.Text + " sekiz yüz";
                    break;
                case 9:
                    m_Ylabel2.Text = m_Ylabel2.Text + " dokuz yüz";
                    break;
            }

            switch (onlar)
            {
                default:
                    return;
                case 0:
                    m_Ylabel2.Text = m_Ylabel2.Text + "";
                    break;
                case 1:
                    m_Ylabel2.Text = m_Ylabel2.Text + " on";
                    break;
                case 2:
                    m_Ylabel2.Text = m_Ylabel2.Text + " yirmi";
                    break;
                case 3:
                    m_Ylabel2.Text = m_Ylabel2.Text + " otuz";
                    break;
                case 4:
                    m_Ylabel2.Text = m_Ylabel2.Text + " kırk";
                    break;
                case 5:
                    m_Ylabel2.Text = m_Ylabel2.Text + " elli";
                    break;
                case 6:
                    m_Ylabel2.Text = m_Ylabel2.Text + " altmış";
                    break;
                case 7:
                    m_Ylabel2.Text = m_Ylabel2.Text + " yetmiş";
                    break;
                case 8:
                    m_Ylabel2.Text = m_Ylabel2.Text + " seksen";
                    break;
                case 9:
                    m_Ylabel2.Text = m_Ylabel2.Text + " doksan";
                    break;
            }

            switch (birler)
            {
                default:
                    return;

                case 0:
                    {
                        if (tl_kontrol == 1)
                            m_Ylabel2.Text = m_Ylabel2.Text + " tl ";
                        else
                        {
                            m_Ylabel2.Text = m_Ylabel2.Text + " ";
                        }
                        break;
                    }
                case 1:
                    m_Ylabel2.Text = m_Ylabel2.Text + " bir tl ";
                    break;
                case 2:
                    m_Ylabel2.Text = m_Ylabel2.Text + " iki tl ";
                    break;
                case 3:
                    m_Ylabel2.Text = m_Ylabel2.Text + " üç tl ";
                    break;
                case 4:
                    m_Ylabel2.Text = m_Ylabel2.Text + " dört tl ";
                    break;
                case 5:
                    m_Ylabel2.Text = m_Ylabel2.Text + " beş tl ";
                    break;
                case 6:
                    m_Ylabel2.Text = m_Ylabel2.Text + " altı tl ";
                    break;
                case 7:
                    m_Ylabel2.Text = m_Ylabel2.Text + " yedi tl ";
                    break;
                case 8:
                    m_Ylabel2.Text = m_Ylabel2.Text + " sekiz tl ";
                    break;
                case 9:
                    m_Ylabel2.Text = m_Ylabel2.Text + " dokuz tl ";
                    break;
            }

            /////////////////////////////////////////////////////////////////////////////////////
            //KURUŞ//
            ////////////////////////////////////////////////////////////////////////////////////

            //sayimiz kurus yani virgül içerirse  virgul_varmı degeri true dönücek ve ilgili kod bloguna giricek.
            //eger virgul_varmı degeri false ise bu bloklara girmeden devam edicek.
            kurus = girilen_sayi_str.Split(',').Last();
            int kurus_basamak_sayisi;
            kurus_basamak_sayisi = kurus.Length;

            bool virgul_varmı = girilen_sayi_str.Contains(virgul);

            if (virgul_varmı == true)
            {
                int kurus_int = Convert.ToInt32(kurus);
                int binler_kurus, yuzler_kurus, onlar_kurus, birler_kurus;

                //virgül sağı için yapılan işlemler aynı şekilde burda da devam ediyor.

                binler_kurus = (kurus_int / 1000) % 10;
                yuzler_kurus = (kurus_int / 100) % 10;
                onlar_kurus = (kurus_int / 10) % 10;
                birler_kurus = kurus_int % 10;

                switch (binler_kurus)
                {
                    default:
                        return;
                    case 0:
                        m_Ylabel2.Text = m_Ylabel2.Text + "";
                        break;
                    case 1:
                        m_Ylabel2.Text = m_Ylabel2.Text + "bin";
                        break;
                    case 2:
                        m_Ylabel2.Text = m_Ylabel2.Text + "iki bin";
                        break;
                    case 3:
                        m_Ylabel2.Text = m_Ylabel2.Text + "üç bin";
                        break;
                    case 4:
                        m_Ylabel2.Text = m_Ylabel2.Text + "dört bin";
                        break;
                    case 5:
                        m_Ylabel2.Text = m_Ylabel2.Text + "beş bin";
                        break;
                    case 6:
                        m_Ylabel2.Text = m_Ylabel2.Text + "altı bin";
                        break;
                    case 7:
                        m_Ylabel2.Text = m_Ylabel2.Text + "yedi bin";
                        break;
                    case 8:
                        m_Ylabel2.Text = m_Ylabel2.Text + "sekiz bin";
                        break;
                    case 9:
                        m_Ylabel2.Text = m_Ylabel2.Text + "dokuz bin";
                        break;
                }
                
                switch (yuzler_kurus)
                {
                    default:
                        return;
                    case 0:
                        m_Ylabel2.Text = m_Ylabel2.Text + "";
                        break;
                    case 1:
                        m_Ylabel2.Text = m_Ylabel2.Text + " yüz";
                        break;
                    case 2:
                        m_Ylabel2.Text = m_Ylabel2.Text + " iki yüz";
                        break;
                    case 3:
                        m_Ylabel2.Text = m_Ylabel2.Text + " üç yüz";
                        break;
                    case 4:
                        m_Ylabel2.Text = m_Ylabel2.Text + " dört yüz";
                        break;
                    case 5:
                        m_Ylabel2.Text = m_Ylabel2.Text + " beş yüz";
                        break;
                    case 6:
                        m_Ylabel2.Text = m_Ylabel2.Text + " altı yüz";
                        break;
                    case 7:
                        m_Ylabel2.Text = m_Ylabel2.Text + " yedi yüz";
                        break;
                    case 8:
                        m_Ylabel2.Text = m_Ylabel2.Text + " sekiz yüz";
                        break;
                    case 9:
                        m_Ylabel2.Text = m_Ylabel2.Text + " dokuz yüz";
                        break;
                }
                
                switch (onlar_kurus)
                {
                    default:
                        return;
                    case 0:
                        m_Ylabel2.Text = m_Ylabel2.Text + "";
                        break;
                    case 1:
                        m_Ylabel2.Text = m_Ylabel2.Text + " on";
                        break;
                    case 2:
                        m_Ylabel2.Text = m_Ylabel2.Text + " yirmi";
                        break;
                    case 3:
                        m_Ylabel2.Text = m_Ylabel2.Text + " otuz";
                        break;
                    case 4:
                        m_Ylabel2.Text = m_Ylabel2.Text + " kırk";
                        break;
                    case 5:
                        m_Ylabel2.Text = m_Ylabel2.Text + " elli";
                        break;
                    case 6:
                        m_Ylabel2.Text = m_Ylabel2.Text + " altmış";
                        break;
                    case 7:
                        m_Ylabel2.Text = m_Ylabel2.Text + " yetmiş";
                        break;
                    case 8:
                        m_Ylabel2.Text = m_Ylabel2.Text + " seksen";
                        break;
                    case 9:
                        m_Ylabel2.Text = m_Ylabel2.Text + " doksan";
                        break;
                }

                if (kurus_basamak_sayisi == 1) //0,4 gibi bi deger girildiğinde dört kuruş yazmasın kırık kuruş yazsın diye yapılan kontrol....
                {

                    switch (birler_kurus)
                    {
                        default:
                            return;
                        case 0:
                            {

                                m_Ylabel2.Text = m_Ylabel2.Text + " kuruş";

                                break;

                            }
                        case 1:
                            m_Ylabel2.Text = m_Ylabel2.Text + " on kuruş";
                            break;
                        case 2:
                            m_Ylabel2.Text = m_Ylabel2.Text + " yirmi kuruş";
                            break;
                        case 3:
                            m_Ylabel2.Text = m_Ylabel2.Text + " otuz kuruş";
                            break;
                        case 4:
                            m_Ylabel2.Text = m_Ylabel2.Text + " kırk kuruş";
                            break;
                        case 5:
                            m_Ylabel2.Text = m_Ylabel2.Text + " elli kuruş";
                            break;
                        case 6:
                            m_Ylabel2.Text = m_Ylabel2.Text + " altmış kuruş";
                            break;
                        case 7:
                            m_Ylabel2.Text = m_Ylabel2.Text + " yetmiş kuruş";
                            break;
                        case 8:
                            m_Ylabel2.Text = m_Ylabel2.Text + " seksen kuruş";
                            break;
                        case 9:
                            m_Ylabel2.Text = m_Ylabel2.Text + " doksan kuruş";
                            break;

                    }
                }
                else if (basamak_sayisi != 1)
                {

                    switch (birler_kurus)
                    {
                        default:
                            return;
                        case 0:
                            {

                                m_Ylabel2.Text = m_Ylabel2.Text + " kuruş";

                                break;

                            }
                        case 1:
                            m_Ylabel2.Text = m_Ylabel2.Text + " bir kuruş";
                            break;
                        case 2:
                            m_Ylabel2.Text = m_Ylabel2.Text + " iki kuruş";
                            break;
                        case 3:
                            m_Ylabel2.Text = m_Ylabel2.Text + " üç kuruş";
                            break;
                        case 4:
                            m_Ylabel2.Text = m_Ylabel2.Text + " dört kuruş";
                            break;
                        case 5:
                            m_Ylabel2.Text = m_Ylabel2.Text + " beş kuruş";
                            break;
                        case 6:
                            m_Ylabel2.Text = m_Ylabel2.Text + " altı kuruş";
                            break;
                        case 7:
                            m_Ylabel2.Text = m_Ylabel2.Text + " yedi kuruş";
                            break;
                        case 8:
                            m_Ylabel2.Text = m_Ylabel2.Text + " sekiz kuruş";
                            break;
                        case 9:
                            m_Ylabel2.Text = m_Ylabel2.Text + " dokuz kuruş";
                            break;

                    }
                }

            }

        }
    }
}