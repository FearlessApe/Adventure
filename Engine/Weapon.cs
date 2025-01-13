using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon: Item
    {
        public int MinimumDamage { get; set; }

        public int MaximumDamage { get; set; }

        public Weapon(int ID, string NAME, string NAMEPlural, int MINIMUMDAMAGE, int MAXIMUMDAMAGE) : base(ID, NAME, NAMEPlural)
        {
            MinimumDamage = MINIMUMDAMAGE;
            MaximumDamage = MAXIMUMDAMAGE; 
        }
    }
}
