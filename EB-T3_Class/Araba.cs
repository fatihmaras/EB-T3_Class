using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB_T3_Class
{
    public class Araba
    {
        public int KapiSayisi;
        public string ArabaModel;
        public String ArabaRengi;


        public Araba(int XkapiSayisi, String XarabaModel, String XarabaRengi)
        {
            KapiSayisi = XkapiSayisi;
            ArabaModel = XarabaModel;
            ArabaRengi = XarabaRengi;

        }


        public void MotorCalistir()
        {
            Console.WriteLine("Motor Çalışıyor...");
        }

        public void KapilariKilitle()
        {
            Console.WriteLine("Kapılar Kilitleniyor...");
        }
    }
}
