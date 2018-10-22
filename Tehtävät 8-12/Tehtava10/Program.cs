using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Tehtava10
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira Musti = new Koira();
            Papukaija Polli = new Papukaija();
            Musti.asetaElaimenNimi("Musti");
            Musti.asetaElaimenIka(5);
            Polli.asetaElaimenNimi("Polli");
            Polli.asetaElaimenIka(2);
            Musti.AsetaSynnytys(true);
            Polli.AsetaMuniminen(true);
            string synnyttaa;
            if (Musti.PalautaSynnytys())
            {
                synnyttaa = "Se synnyttää eläviä poikasia";
            }
            else {
                synnyttaa = "Se ei synnytä eläviä poikasia, onko se edes nisäkäs"; 
                 }
            Console.Write("Koiran nimi on " + Musti.palautaElaimenNimi() + ", se on " + Musti.palautaElaimenIka() + " vuotta vanha ja " + synnyttaa);
            Console.WriteLine();
            Console.Write("Papukaijan nimi on " + Polli.palautaElaimenNimi() + ", se on " + Polli.palautaElaimenIka() + " vuotta vanha ja ");
            Polli.PalautaMuniminen();
            Console.ReadKey();
        }
    }
}
