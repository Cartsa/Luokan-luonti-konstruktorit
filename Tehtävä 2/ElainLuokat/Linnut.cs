using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Linnut : Elain
    {
        bool Muniminen;
        public Linnut()
        {

        }
        public void AsetaMuniminen(bool u_Munii)
        {
            Muniminen = u_Munii;
        }
        public bool PalautaMuniminen()
        {
            if (Muniminen)
            {
                Console.Write("Se munii");
            }
            else
            {
                Console.Write("Se ei muni, onko se edes lintu?");
            }
            return Muniminen;
        }
    }
}
