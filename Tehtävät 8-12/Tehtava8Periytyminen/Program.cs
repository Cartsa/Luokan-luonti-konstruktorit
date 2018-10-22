using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Tehtava8Periytyminen
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa kissa = new Kissa();
            kissa.asetaElaimenNimi("Pekka");
            kissa.asetaElaimenIka(4);
            kissa.asetaOnLihanSyoja(true);
            Console.WriteLine("Kissan nimi on " + kissa.palautaElaimenNimi() + " ja sen ikä on " + kissa.palautaElaimenIka() + " ja sen lihansyönti tilanne on " + kissa.palautaOnLihanSyoja());
            Koira koira = new Koira();
            koira.asetaElaimenNimi("Balto");
            koira.asetaElaimenIka(7);
            koira.asetaOnLihanSyoja(true);
            Console.WriteLine("Koiran nimi on " + koira.palautaElaimenNimi() + " ja sen ikä on " + koira.palautaElaimenIka() + " ja sen lihansyönti tilanne on " + koira.palautaOnLihanSyoja());
            Console.ReadKey();
        }
    }
}