using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

namespace Tehtava11
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList OlioLista = new ArrayList();
            String[] nimiarray = {"Henri","Mikko","Petteri","Julius","Lebron","Timo","Juhani","Liisa","Marja","Kirsi","Jussi","Kaija","Minna","Minttu","Siina","Riina"};
            Random rnd = new Random();
            int k = 1;
            Console.WriteLine("Anna numero");
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i < num+1; i++)
            {
                if (i % 4 == 0 & i != 0)
                {
                    Hevonen heppa = new Hevonen();
                    heppa.asetaElaimenNimi(nimiarray[rnd.Next(0,15)]);
                    heppa.asetaElaimenIka(rnd.Next(1, 30));
                    heppa.asetaOnLihanSyoja(false);
                    heppa.AsetaSynnytys(true);
                    OlioLista.Add(heppa);
                    if (k == 3)
                    {
                        k = 1;
                    }
                    else
                    {
                        k++;
                    }
                }
                else
                {
                    if (k == 1)
                    {
                        Kissa kissa = new Kissa();
                        kissa.asetaElaimenNimi(nimiarray[rnd.Next(0, 15)]);
                        kissa.asetaElaimenIka(rnd.Next(1, 16));
                        kissa.asetaOnLihanSyoja(true);
                        kissa.AsetaSynnytys(true);
                        OlioLista.Add(kissa);
                        k++;
                    }
                    else if (k == 2)
                    {
                        Koira koira = new Koira();
                        koira.asetaElaimenNimi(nimiarray[rnd.Next(0, 15)]);
                        koira.asetaElaimenIka(rnd.Next(1, 14));
                        koira.asetaOnLihanSyoja(true);
                        koira.AsetaSynnytys(true);
                        OlioLista.Add(koira);
                        k++;
                    }
                    else if (k == 3)
                    {
                        Papukaija papukaija = new Papukaija();
                        papukaija.asetaElaimenNimi(nimiarray[rnd.Next(0, 15)]);
                        papukaija.asetaElaimenIka(rnd.Next(1, 80));
                        papukaija.asetaOnLihanSyoja(false);
                        papukaija.AsetaMuniminen(true);
                        OlioLista.Add(papukaija);
                        k = 1;
                    }
                    else
                    {
                        Console.WriteLine("Error Error Error Error");
                    }
                }
            }
            foreach(Elain elain in OlioLista)
            {
                Console.Write("Eläimen nimi on " + elain.palautaElaimenNimi());
                Console.Write(", se on " + elain.palautaElaimenIka() + " vuotta vanha ja");
                if (elain.palautaOnLihanSyoja())
                {
                    Console.Write(" se on lihansyöjä");
                }
                else
                {
                    Console.Write(" se on kasvissyöjä");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Kissat");
            foreach (Kissa elain in OlioLista.OfType<Kissa>())
            {
                Console.Write("Eläimen nimi on " + elain.palautaElaimenNimi());
                Console.Write(", se on " + elain.palautaElaimenIka() + " vuotta vanha,");
                if (elain.palautaOnLihanSyoja())
                {
                    Console.Write(" se on lihansyöjä");
                }
                else
                {
                    Console.Write(" se on kasvissyöjä");
                }
                if (elain.PalautaSynnytys())
                {
                    Console.Write(" ja synnyttää eläviä poikasia");
                }
                else
                {
                    Console.Write(" ja se ei synnytä eläviä poikasia");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Koirat");
            foreach (Koira elain in OlioLista.OfType<Koira>())
            {
                Console.Write("Eläimen nimi on " + elain.palautaElaimenNimi());
                Console.Write(", se on " + elain.palautaElaimenIka() + " vuotta vanha,");
                if (elain.palautaOnLihanSyoja())
                {
                    Console.Write(" se on lihansyöjä");
                }
                else
                {
                    Console.Write(" se on kasvissyöjä");
                }
                if (elain.PalautaSynnytys())
                {
                    Console.Write(" ja synnyttää eläviä poikasia");
                }
                else
                {
                    Console.Write(" ja se ei synnytä eläviä poikasia");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Papukaijat");
            foreach (Papukaija elain in OlioLista.OfType<Papukaija>())
            {
                Console.Write("Eläimen nimi on " + elain.palautaElaimenNimi());
                Console.Write(", se on " + elain.palautaElaimenIka() + " vuotta vanha,");
                if (elain.palautaOnLihanSyoja())
                {
                    Console.Write(" se on lihansyöjä");
                }
                else
                {
                    Console.Write(" se on kasvissyöjä");
                }
                if (elain.PalautaMuniminen())
                {
                    Console.Write(" ja se munii");
                }
                else
                {
                    Console.Write(" ja se ei muni");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Hevoset");
            foreach (Hevonen elain in OlioLista.OfType<Hevonen>())
            {
                Console.Write("Eläimen nimi on " + elain.palautaElaimenNimi());
                Console.Write(", se on " + elain.palautaElaimenIka() + " vuotta vanha,");
                if (elain.palautaOnLihanSyoja())
                {
                    Console.Write(" se on lihansyöjä");
                }
                else
                {
                    Console.Write(" se on kasvissyöjä");
                }
                if (elain.PalautaSynnytys())
                {
                    Console.Write(" ja synnyttää eläviä poikasia");
                }
                else
                {
                    Console.Write(" ja se ei synnytä eläviä poikasia");
                }
                Console.WriteLine();
            }
            Console.WriteLine(OlioLista.Count);
            Console.ReadKey();
        }
    }
}
