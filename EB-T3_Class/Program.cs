using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int KapiSayisi = 4;
            //string ArabaModel = "Renault";
            //string ArabaRengi = "Kırmızı";



            Araba Araba1 = new Araba(4, "Renault", "Kırmızı");

            Console.WriteLine("Araba Rengi : " + Araba1.ArabaRengi);
            Console.WriteLine("Araba Modeli : " + Araba1.ArabaModel);
            Console.WriteLine("Kapı Sayısı : " + Araba1.KapiSayisi);

            //Araba1.KapiSayisi = 4;
            //Araba1.ArabaRengi = "Kırımızı";
            //Araba1.ArabaModel = "Renault";

            //Araba1.KapilariKilitle();
            //Araba1.MotorCalistir();

            //Console.WriteLine("Arabanın Kapı Sayısı : " + Araba1.KapiSayisi);
            //Console.WriteLine("Arabanın Rengi : " + Araba1.ArabaRengi);
            //Console.WriteLine("Arabanın Modeli : " + Araba1.ArabaModel);

            Console.ReadLine();

        }
    }
}
