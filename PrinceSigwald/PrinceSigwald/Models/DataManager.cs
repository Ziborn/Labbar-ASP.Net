using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrinceSigwald.Models
{
    public static class DataManager
    {
        static List<Band> bandList = new List<Band>
        {
            new Band {Id = 1, Name = "Black Ingvars", Description = "Min kära lilla ponny"},
            new Band {Id = 2, Name = "Smurfhits", Description = "Blåbärssaft"},
            new Band {Id = 3, Name = "Eminem", Description = "Lose yourself"}
        };

        public static Band GetBand(string bandName)
        {
            return bandList.SingleOrDefault(b => b.Name == bandName);
        }

        public static Band[] GetAllBands()
        {
            return bandList.ToArray();
        }
    }
}
