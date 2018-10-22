using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Tehtava12
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa mirri = new Kissa();
            mirri.asetaElaimenNimi("Mirri");
            Kissa kissa = new Kissa();
            kissa.asetaElaimenNimi("Mouru");
            kissa.LisaaPentu("Miina",0);
            kissa.LisaaPentu("Manu", 1);
            kissa.LisaaPentu("Masa", 0);
            mirri.LisaaPentu("Mikke", 3);
            foreach (Kissa pentu in kissa.pennut)
            {
                Kissa Emo = pentu.palautaEmo();    
                Console.WriteLine("Kissan pennun nimi on " + pentu.palautaElaimenNimi() + ", se on " + pentu.palautaElaimenIka() + " vuotta vanha ja sen emo on " + Emo.palautaElaimenNimi());
            }
            foreach (Kissa pentu in mirri.pennut)
            {
                Kissa Emo = pentu.palautaEmo();
                Console.WriteLine("Kissan pennun nimi on " + pentu.palautaElaimenNimi() + ", se on " + pentu.palautaElaimenIka() + " vuotta vanha ja sen emo on " + Emo.palautaElaimenNimi());
            }
            Console.ReadKey();
        }
    }
}
