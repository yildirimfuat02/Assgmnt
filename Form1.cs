using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asgmnt
{
    public partial class Form1 : Form
    {
        List<int> TumTaslar = new List<int>();
        List<string> Oyuncu1 = new List<string>();
        //List<string> Oyuncu12 = new List<string>();
        string[] stringArray = new string[14];
        int[] intArray = new int[14];

        List<string> Oyuncu2 = new List<string>();
        List<string> Oyuncu3 = new List<string>();
        List<string> Oyuncu4 = new List<string>();

        List<int> Renkler = new List<int>();

        int Oyuncu1PerGiderseKalanTasSayisi = 0;
        int Oyuncu1CiftGiderseKalanTasSayisi = 0;
        int Oyuncu1KalanTasSayisi = 0;
        int Oyuncu1OkeySayisi = 0;

        int Oyuncu2PerGiderseKalanTasSayisi = 0;
        int Oyuncu2CiftGiderseKalanTasSayisi = 0;
        int Oyuncu2KalanTasSayisi = 0;
        int Oyuncu2OkeySayisi = 0;

        int Oyuncu3PerGiderseKalanTasSayisi = 0;
        int Oyuncu3CiftGiderseKalanTasSayisi = 0;
        int Oyuncu3KalanTasSayisi = 0;
        int Oyuncu3OkeySayisi = 0;

        int Oyuncu4PerGiderseKalanTasSayisi = 0;
        int Oyuncu4CiftGiderseKalanTasSayisi = 0;
        int Oyuncu4KalanTasSayisi = 0;
        int Oyuncu4OkeySayisi = 0;

        string Okey="";
        string renk;
        List<int> KalanTaslar = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int OnbesTas = 0;
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                if (i==0)
                {OnbesTas = 16;}
                else
                {OnbesTas = 14;}

                for (int j = 0; j < OnbesTas; j++)
                {
                    int Sayi = rnd.Next(0, 104);
                    Sayi = Sayi + 1;
                    if (TumTaslar.IndexOf(Sayi) == -1)
                    {

                        TumTaslar.Add(Sayi);

                        if (Enumerable.Range(0, 13).Contains(Sayi) || Enumerable.Range(53, 13).Contains(Sayi))
                        {
                            renk = "Sarı ";
                            if (Sayi > 50)
                            {
                                Sayi = Sayi - 52;
                            }
                        }
                        else if (Enumerable.Range(13, 13).Contains(Sayi) || Enumerable.Range(66, 13).Contains(Sayi))
                        {
                            renk = "Mavi ";
                            if (Sayi < 30)
                            {
                                Sayi = Sayi - 12;
                            }
                            else if (Sayi > 60)
                            {
                                Sayi = Sayi - 65;
                            }
                        }
                        else if (Enumerable.Range(26, 13).Contains(Sayi) || Enumerable.Range(79, 13).Contains(Sayi))
                        {
                            renk = "Siyah ";
                            if (Sayi < 45)
                            {
                                Sayi = Sayi - 25;
                            }
                            else if (Sayi > 70)
                            {
                                Sayi = Sayi - 78;
                            }
                        }
                        else if (Enumerable.Range(39, 13).Contains(Sayi) || Enumerable.Range(92, 13).Contains(Sayi))
                        {
                            renk = "Kırmızı ";
                            if (Sayi < 55)
                            {
                                Sayi = Sayi - 38;
                            }
                            else if (Sayi > 90)
                            {
                                Sayi = Sayi - 91;
                            }
                        }
                        else if (Sayi == 52 || Sayi == 104)
                        {
                            renk = "Sahte Okey";
                        }


                        if (i == 0)
                        {
                            if (j == 15)
                            {
                                if (renk != "Sahte Okey")
                                {
                                    Okey = renk + (Sayi );
                                }
                                else
                                {
                                    OnbesTas++;
                                }
                            }
                            else 
                            {
                                if (renk != "Sahte Okey")
                                {
                                    Oyuncu1.Add(renk + (Sayi ));
                                }
                                else
                                {
                                    Oyuncu1.Add(renk);
                                }
                            }
                        }
                        else if (i == 1)
                        {
                            if (renk != "Sahte Okey")
                            {
                                Oyuncu2.Add(renk + (Sayi ));
                            }
                            else
                            {
                                Oyuncu2.Add(renk);
                            }

                        }
                        else if (i == 2)
                        {
                            if (renk != "Sahte Okey")
                            {
                                Oyuncu3.Add(renk + (Sayi ));
                            }
                            else
                            {
                                Oyuncu3.Add(renk);
                            }
                        }
                        else if (i == 3)
                        {
                            if (renk != "Sahte Okey")
                            {
                                Oyuncu4.Add(renk + (Sayi ));
                            }
                            else
                            {
                                Oyuncu4.Add(renk);
                            }

                        }
                    }
                    else
                    {
                        j--;
                    }
                }
            }
            //Oyuncu12 = Oyuncu12.OrderBy(a => a[0]).ThenBy(a => a[1]).ToList();

            //Oyuncu1.Add("Siyah 5"); Oyuncu1.Add("Siyah 5"); Oyuncu1.Add("Kırmızı 8"); Oyuncu1.Add("Kırmızı 7"); Oyuncu1.Add("Kırmızı 6"); Oyuncu1.Add("Sarı 12");
            //Oyuncu1.Add("Sarı 12"); Oyuncu1.Add("Mavi 4"); Oyuncu1.Add("Mavi 4"); Oyuncu1.Add("Sarı 4"); Oyuncu1.Add("Mavi 13"); Oyuncu1.Add("Sahte Okey"); Oyuncu1.Add("Sahte Okey");


            stringArray = Oyuncu1.ToArray();
            Array.Sort(stringArray);
            Oyuncu1 = stringArray.ToList();

            stringArray = Oyuncu2.ToArray();
            Array.Sort(stringArray);
            Oyuncu2 = stringArray.ToList();

            stringArray = Oyuncu3.ToArray();
            Array.Sort(stringArray);
            Oyuncu3 = stringArray.ToList();

            stringArray = Oyuncu4.ToArray();
            Array.Sort(stringArray);
            Oyuncu4 = stringArray.ToList();
            //foreach (string str in stringArray) Console.Write(str + " ");

            Oyuncu1OkeySayisi = OkeyKontrol(Oyuncu1.ToArray());
            SahteOkeyleriCevirme(Oyuncu1.ToArray());
            Oyuncu1CiftGiderseKalanTasSayisi = CiftSayisi(Oyuncu1.ToArray(), Oyuncu1OkeySayisi);
            Oyuncu1PerGiderseKalanTasSayisi = PerSayisi(Oyuncu1.ToArray(), Oyuncu1OkeySayisi);
            Oyuncu1KalanTasSayisi = IzlenecekYol(Oyuncu1CiftGiderseKalanTasSayisi, Oyuncu1PerGiderseKalanTasSayisi);

            Oyuncu2OkeySayisi = OkeyKontrol(Oyuncu2.ToArray());
            SahteOkeyleriCevirme(Oyuncu2.ToArray());
            Oyuncu2CiftGiderseKalanTasSayisi = CiftSayisi(Oyuncu2.ToArray(), Oyuncu2OkeySayisi);
            Oyuncu2PerGiderseKalanTasSayisi = PerSayisi(Oyuncu2.ToArray(), Oyuncu2OkeySayisi);
            Oyuncu2KalanTasSayisi = IzlenecekYol(Oyuncu2CiftGiderseKalanTasSayisi, Oyuncu2PerGiderseKalanTasSayisi);

            Oyuncu3OkeySayisi = OkeyKontrol(Oyuncu3.ToArray());
            SahteOkeyleriCevirme(Oyuncu3.ToArray());
            Oyuncu3CiftGiderseKalanTasSayisi = CiftSayisi(Oyuncu3.ToArray(), Oyuncu3OkeySayisi);
            Oyuncu3PerGiderseKalanTasSayisi = PerSayisi(Oyuncu3.ToArray(), Oyuncu3OkeySayisi);
            Oyuncu3KalanTasSayisi = IzlenecekYol(Oyuncu3CiftGiderseKalanTasSayisi, Oyuncu3PerGiderseKalanTasSayisi);

            Oyuncu4OkeySayisi = OkeyKontrol(Oyuncu4.ToArray());
            SahteOkeyleriCevirme(Oyuncu4.ToArray());
            Oyuncu4CiftGiderseKalanTasSayisi = CiftSayisi(Oyuncu4.ToArray(), Oyuncu4OkeySayisi);
            Oyuncu4PerGiderseKalanTasSayisi = PerSayisi(Oyuncu4.ToArray(), Oyuncu4OkeySayisi);
            Oyuncu4KalanTasSayisi = IzlenecekYol(Oyuncu4CiftGiderseKalanTasSayisi, Oyuncu4PerGiderseKalanTasSayisi);


            Kazanan(Oyuncu1KalanTasSayisi, Oyuncu2KalanTasSayisi, Oyuncu3KalanTasSayisi, Oyuncu4KalanTasSayisi);
        }

        public void SahteOkeyleriCevirme(string[] array)
        {
            array = array.Select(s => s.Replace("Sahte Okey",Okey )).ToArray();
        }

        public void Kazanan(int Oyuncu1KalanTasSayisi,int Oyuncu2KalanTasSayisi,int Oyuncu3KalanTasSayisi,int Oyuncu4KalanTasSayisi)
        {

            int sayi;
            int enKucuk=15;
            int kazanan = 0;
            KalanTaslar.Add(Oyuncu1KalanTasSayisi); KalanTaslar.Add(Oyuncu2KalanTasSayisi); KalanTaslar.Add(Oyuncu3KalanTasSayisi); KalanTaslar.Add(Oyuncu4KalanTasSayisi);
            for (int i = 1; i < KalanTaslar.Count+1; i++)
            {
                sayi = Convert.ToInt32(KalanTaslar[i-1]);
                if (sayi < enKucuk)
                {
                    enKucuk = sayi;
                    kazanan = i;
                }
                else if (sayi == enKucuk)
                {
                    kazanan = 0;
                }
            }

            if (kazanan != 0)
            {
                Console.WriteLine("Oyunu kazanan "+kazanan+". oyuncu oldu.");
            }
            else
            {
                Console.WriteLine("Eşitlik durumu olduğundan kazanan yok.");
            }

         


        }
        public int IzlenecekYol(int Cift,int Per)
        {
            int Total = 0;
            if (Cift>Per)
            {Total = Per;}
            else
            {Total = Cift;}
            return Total;
        }

        public int OkeyKontrol(string[] array)
        {
            //int okeySayisi=0;
            int okeySayisi = (Array.FindAll(array, s => s.Equals(Okey))).Count();
            array = array.Select(s => s.Replace(Okey, "OKEY")).ToArray();
            return okeySayisi;
        }

        public int CiftSayisi(string[] array, int OkeySayisi)
        {
            int ciftSayisi = 0;
            var duplicates = array
           .GroupBy(p => p)
           .Where(g => g.Count() > 1)
           .Select(g => g.Key);
            ciftSayisi = duplicates.Count();
            if (OkeySayisi == 1)
            {
                ciftSayisi++;
            }
            else if (OkeySayisi == 2)
            {
                ciftSayisi = ciftSayisi + 2;
            }
            return array.Length-(ciftSayisi*2);
        }
        public int PerSayisi(string[] array, int OkeySayisi)
        {
            //int ilkSayi = 0;
            //int SonSayi = 0;
            //int ArrayUzunlugu = 0;
            int EksikTasSayisi = 0;
            int EldekiPerSayisi = 0;
            int KalanTasSayisi = array.Length;
            int FarklarToplamı = 0;

            //kırmızılar için
            var kirmizi = Array.FindAll(array, s => s.Contains("Kırmızı"));
            for (int i = 0; i < kirmizi.Length; i++)
            {
                Renkler.Add(Convert.ToInt32(kirmizi[i].Substring(kirmizi[i].IndexOf(' ') + 1)));
            }
            intArray = Renkler.ToArray();
            Array.Sort(intArray);
            for (int i = 0; i < intArray.Length-1; i++)
            {
                FarklarToplamı += intArray.ToArray()[i+1] - intArray.ToArray()[i];
            }
            EksikTasSayisi = FarklarToplamı - ((intArray.Length) - 1);
            if (EksikTasSayisi==0)
            {
                EldekiPerSayisi++;
                KalanTasSayisi = KalanTasSayisi - intArray.Length;
            }
            else if (OkeySayisi==1)
            {
                if (EksikTasSayisi==1)
                {
                    EldekiPerSayisi++;
                    OkeySayisi--;
                    KalanTasSayisi = KalanTasSayisi - (intArray.Length+1);
                }
            }
            else if (OkeySayisi == 2)
            {
                if (EksikTasSayisi == 1)
                {
                    EldekiPerSayisi++;
                    OkeySayisi--;
                    KalanTasSayisi = KalanTasSayisi - (intArray.Length + 1);
                }
                else if (EksikTasSayisi == 2)
                {
                    EldekiPerSayisi++;
                    OkeySayisi = OkeySayisi - 2;
                    KalanTasSayisi = KalanTasSayisi - (intArray.Length + 2);
                }
            }

            //Sarılar için
            Renkler.Clear();
            var sari = Array.FindAll(array, s => s.Contains("Sarı"));
            for (int i = 0; i < sari.Length; i++)
            {
                Renkler.Add(Convert.ToInt32(sari[i].Substring(sari[i].IndexOf(' ') + 1)));
            }
            intArray = Renkler.ToArray();
            Array.Sort(intArray);
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                FarklarToplamı += intArray.ToArray()[i + 1] - intArray.ToArray()[i];
            }
            EksikTasSayisi = FarklarToplamı - ((intArray.Length) - 1);
            if (EksikTasSayisi == 0)
            {
                EldekiPerSayisi++;
                KalanTasSayisi = KalanTasSayisi - (intArray.Length );
            }
            else if (OkeySayisi == 1)
            {
                if (EksikTasSayisi == 1)
                {
                    EldekiPerSayisi++;
                    OkeySayisi--;
                    KalanTasSayisi = KalanTasSayisi - (intArray.Length + 1);
                }
            }
            else if (OkeySayisi == 2)
            {
                if (EksikTasSayisi == 1)
                {
                    EldekiPerSayisi++;
                    OkeySayisi--;
                    KalanTasSayisi = KalanTasSayisi - (intArray.Length + 1);
                }
                else if (EksikTasSayisi == 2)
                {
                    EldekiPerSayisi++;
                    OkeySayisi = OkeySayisi - 2;
                    KalanTasSayisi = KalanTasSayisi - (intArray.Length + 2);
                }
            }
            //Maviler için
            Renkler.Clear();
            var mavi = Array.FindAll(array, s => s.Contains("Mavi"));
            for (int i = 0; i < mavi.Length; i++)
            {
                Renkler.Add(Convert.ToInt32(mavi[i].Substring(mavi[i].IndexOf(' ') + 1)));
            }
            intArray = Renkler.ToArray();
            Array.Sort(intArray);
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                FarklarToplamı += intArray.ToArray()[i + 1] - intArray.ToArray()[i];
            }
            EksikTasSayisi = FarklarToplamı - ((intArray.Length) - 1);
            if (EksikTasSayisi == 0)
            {
                EldekiPerSayisi++;
                KalanTasSayisi = KalanTasSayisi - (intArray.Length );
            }
            else if (OkeySayisi == 1)
            {
                if (EksikTasSayisi == 1)
                {
                    EldekiPerSayisi++;
                    OkeySayisi--;
                    KalanTasSayisi = KalanTasSayisi - (intArray.Length + 1);
                }
            }
            else if (OkeySayisi == 2)
            {
                if (EksikTasSayisi == 1)
                {
                    EldekiPerSayisi++;
                    OkeySayisi--;
                    KalanTasSayisi = KalanTasSayisi - (intArray.Length + 1);
                }
                else if (EksikTasSayisi == 2)
                {
                    EldekiPerSayisi++;
                    OkeySayisi = OkeySayisi - 2;
                    KalanTasSayisi = KalanTasSayisi - (intArray.Length + 2);
                }
            }
            //Siyahlar için
            Renkler.Clear();
            var siyah = Array.FindAll(array, s => s.Contains("Siyah"));
            for (int i = 0; i < siyah.Length; i++)
            {
                Renkler.Add(Convert.ToInt32(siyah[i].Substring(siyah[i].IndexOf(' ') + 1)));
            }
            intArray = Renkler.ToArray();
            Array.Sort(intArray);
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                FarklarToplamı += intArray.ToArray()[i + 1] - intArray.ToArray()[i];
            }
            EksikTasSayisi = FarklarToplamı - ((intArray.Length) - 1);
            if (EksikTasSayisi == 0)
            {
                EldekiPerSayisi++;
                KalanTasSayisi = KalanTasSayisi - (intArray.Length);
            }
            else if (OkeySayisi == 1)
            {
                if (EksikTasSayisi == 1)
                {
                    EldekiPerSayisi++;
                    OkeySayisi--;
                    KalanTasSayisi = KalanTasSayisi - (intArray.Length + 1);
                }
            }
            else if (OkeySayisi == 2)
            {
                if (EksikTasSayisi == 1)
                {
                    EldekiPerSayisi++;
                    OkeySayisi--;
                    KalanTasSayisi = KalanTasSayisi - (intArray.Length + 1);
                }
                else if (EksikTasSayisi == 2)
                {
                    EldekiPerSayisi++;
                    OkeySayisi = OkeySayisi - 2;
                    KalanTasSayisi = KalanTasSayisi - (intArray.Length + 2);
                }
            }

            //hala okey sayısı 2 ise
            if (OkeySayisi==2)
            {
                EldekiPerSayisi++;
                OkeySayisi = OkeySayisi - 2;
                KalanTasSayisi = KalanTasSayisi - (3);
            }
            return KalanTasSayisi;
        }
    }
}

