using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Armour : Item
    {
        public int Resistance {  get; set; }

        public int MagicResistance {  get; set; }

        public Armour(int ID, string NAME, string NAMEPlural, int RESISTANCE, int MAGICRESISTANCE) : base(ID, NAME, NAMEPlural)
        {
            Resistance = RESISTANCE;
            MagicResistance = MAGICRESISTANCE;
        }


    }
}
