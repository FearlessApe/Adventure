using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public class Spell
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ManaCost { get; set; }

        public int Effect_ID { get; set; }

        public int Effect_amount { get; set; }

        public bool CombatSpells {  get; set; }

        public Spell(int ID, string NAME, int MANACOST, int EFFECT_ID, int EFFECT_AMOUNT, bool COMBATSPELLS) 
        {
            Id = ID;
            Name = NAME;
            ManaCost = MANACOST;
            Effect_ID = EFFECT_ID;
            Effect_amount = EFFECT_AMOUNT;
            CombatSpells = COMBATSPELLS;
        }
    }
}
