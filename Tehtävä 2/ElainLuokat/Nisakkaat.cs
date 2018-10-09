﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Nisakkaat : Elain
    {
        bool SynnyttaaPoikasia;
        public Nisakkaat()
        {

        }
        public void AsetaSynnytys(bool u_poikii)
        {
            SynnyttaaPoikasia = u_poikii;
        }
        public bool PalautaSynnytys()
        {
            if (SynnyttaaPoikasia)
            {
                Console.Write("Se synnyttää eläviä poikasia");
            } else
            {
                Console.Write("Se ei synnytä eläviä poikasia, onko se edes nisäkäs?");
            }
            return SynnyttaaPoikasia;
        }
    }
}
