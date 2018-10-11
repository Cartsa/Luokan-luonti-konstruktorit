using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Elain
    {
        public int ElainIka;
        public string ElainNimi;
        private bool onLihanSyoja;
        public Elain()
        {

        }
        public Elain(string u_nimi,int u_ika)
        {
            ElainNimi = u_nimi;
            ElainIka = u_ika;
        }
        public void asetaElaimenIka(int u_ElaimenIka)
        {
            if (u_ElaimenIka < 0)
            {
                Console.WriteLine("Ikä on negatiivinen!");
                return;
            }
            else
            {
                ElainIka = u_ElaimenIka;
            }
        }
        public void asetaElaimenNimi(string u_ElaimenNimi)
        {
            ElainNimi = u_ElaimenNimi;
        }
        public string palautaElaimenNimi()
        {
            return ElainNimi;
        }
        public int palautaElaimenIka()
        {
            return ElainIka;
        }
        public void asetaOnLihanSyoja(bool SyoLihaa)
        {
            onLihanSyoja = SyoLihaa;
        }
        public bool palautaOnLihanSyoja()
        {
            return onLihanSyoja;
        }
    }
}
