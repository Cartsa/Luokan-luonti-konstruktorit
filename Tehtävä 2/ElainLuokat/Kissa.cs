using System;
using System.Collections;
using System.Collections.Generic;
namespace ElainLuokat
{


public class Kissa : Nisakkaat
{
    public List<Kissa> pennut = new List<Kissa>();
        public Kissa Emo;
    public Kissa()
        {

        }
    public Kissa(string u_nimi, int u_ika)
        {
            asetaElaimenNimi(u_nimi);
            asetaElaimenIka(u_ika);
        }
        public Kissa(string u_nimi, int u_ika,Kissa u_emo)
        {
            asetaElaimenNimi(u_nimi);
            asetaElaimenIka(u_ika);
            asetaEmo(u_emo);
        }
        public void LisaaPentu(string u_pentunimi, int u_ika=0)
        {
            Emo = this;
            pennut.Add(new Kissa(u_pentunimi,u_ika,Emo));
        }
    public Kissa palautaEmo()
        {
                return Emo;
        }
        public void asetaEmo(Kissa u_emo)
        {
            Emo = u_emo;
        }
    }
}