using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Engine
{
    public class LivingCreature
    {
        public int CurrentHitPoints { get; set; }
        public int MaximumHitPoints { get; set; }

        public int CurrentMana {  get; set; }
        public int MaximumMana {  get; set; }

        public LivingCreature(int currentHitPoints, int maximumHitPoints, int currentMana, int maximumMana) { 
            
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
            CurrentMana = currentMana;
            MaximumMana = maximumMana;
        }
    }
}
