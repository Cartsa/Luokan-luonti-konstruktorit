using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Luokan_luonti_konstruktorit
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa mirri = new Kissa();
            mirri.ElainNimi = "Pekka";
            Console.WriteLine(mirri.ElainNimi);
            mirri.asetaElaimenNimi("Manu");
            Console.WriteLine(mirri.ElainNimi);
            Console.WriteLine(mirri.ElainIka);
            Kissa miina = new Kissa();
            miina.asetaElaimenNimi("Miina");
            miina.asetaElaimenIka(7);
            string testi = miina.palautaElaimenNimi();
            Console.WriteLine("Uuden Elaimen nimi on " + testi + " ja ikä on " + miina.palautaElaimenIka());
            Console.WriteLine("Syötä Elaimen ikä");
            miina.asetaElaimenIka(int.Parse(Console.ReadLine()));
            Console.WriteLine("Elaimen ikä on " + miina.palautaElaimenIka());
            Console.WriteLine("Syötä Elaimen nimi");
            miina.asetaElaimenNimi(Console.ReadLine());
            Console.WriteLine("Elaimen nimi on " + miina.palautaElaimenNimi());
            Console.WriteLine();

            Kissa Anneli = new Kissa();
            Anneli.asetaElaimenNimi("Anneli");
            Console.WriteLine("Toisen Elaimen nimi on " + Anneli.palautaElaimenNimi());
            Console.WriteLine("Yritämme nyt vaihtaa Elaimen nimeksi Hilda");
            Anneli.asetaElaimenNimi("Hilda");
            Console.WriteLine("Elaimen nimi on " + Anneli.palautaElaimenNimi());
            Console.ReadKey();
        }
    }
}