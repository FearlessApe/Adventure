using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public int Gold { get; set; }

        public int Mana { get; set; }

        public int ExperiencePoints { get; set; }

        public int Level { get; set; }

        public List<InventoryItem> Inventory { get; set; }

        public List<PlayerQuest> Quest { get; set; }

        public Player(int currentHitPoints, int maximumHitPoints, int gold,
            int experiencePoints,int currentMana,int maximumMana, int level) : base(currentHitPoints, maximumHitPoints, currentMana, maximumMana)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Mana = currentMana;
            Level = level;
            Inventory = new List<InventoryItem>();
            Quest = new List<PlayerQuest>();
        }
    }
}