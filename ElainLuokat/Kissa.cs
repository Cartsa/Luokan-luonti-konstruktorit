using System;
namespace ElainLuokat
{


public class Kissa : Elain
{
    public void Kissat()
        {

        }
    public void Kissat(string u_nimi, int u_Ika)
       {
         ElainNimi = u_nimi;
         ElainIka = u_Ika;
       }
    }
}