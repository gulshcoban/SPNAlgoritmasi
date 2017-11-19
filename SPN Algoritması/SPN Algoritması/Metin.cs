using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SPN_Algoritması
{
    public class Metin
    {
        public string GirilecekMetin { get; set; }
        public string Anahtar { get; set; }
        public string SifrelenmisMetin { get; set; }
        public string CozulmusMetin { get; set; }
        public string Saniye { get; set; }

        public Metin(string girilecek_metin, string anahtar)
        {
            this.GirilecekMetin = girilecek_metin;
            this.Anahtar = anahtar;

        }
        public void MetinSifreleme()
        {
            int j = 0;
            string mesaj = "";
            string s1 = "";
            string s2 = "";
            string s3 = "";
            string s4 = "";
            for (int i = 0; i < GirilecekMetin.Length; i++)
            {
                //SifrelenmisMetin += Convert.ToChar(Convert.ToInt32(GirilecekMetin[i] + Convert.ToInt32(Anahtar[j])) % 351);
                
                if (j == Anahtar.Length)
                    j = 0;


                if (Convert.ToInt32(GirilecekMetin[i]) == Convert.ToInt32(Anahtar[j]))
                {
                    mesaj += 0;
                }
                else
                {
                    mesaj += 1;
                }
                j += 1;

            }
            for (int k = 0; k < 16; k++)
            {
                if (k < 4)
                {
                    s1 += mesaj[k];
                }
                if ((k >= 4) && (k < 8))
                {
                    s2 += mesaj[k];
                }
                if ((k >= 8) && (k < 12))
                {
                    s3 += mesaj[k];
                }
                if (k >= 12)
                {
                    s4 += mesaj[k];
                }
            }
        }




    }
}