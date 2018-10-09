using System;

public class Kissa
{
    int KissanIka;
    string KissanNimi;
    public Kissa()
	{
        KissanIka = 0;
        KissanNimi = "";
	}
    public Kissa(int u_KissanIka,string u_KissanNimi)
    {
        KissanIka = u_KissanIka;
        KissanNimi = u_KissanNimi;
    }
    public void asetaKissanNimi(string u_KissanNimi)
    {
        KissanIka = u_KissanNimi;
    }
    public string palautaKissanNimi()
    {
        return KissanNimi;
    }
    public int palautaKissanIka()
    {
        return KissanIka;
    }
}
