using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Questions = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        // =================== Plans to add later =======================
        // public static readonly List<Spell> Spells = new List<Spell>();
        // public static readonly List<Race> Races = new List<Race>();
        // public static readonly List<Buff> Buffs = new List<Buff>();

        //===============================================================

        // Item index -> 19

        // =================== Weapons ================================
        public const int Item_ID_Rusty_Sword = 1;
        public const int Item_ID_Club = 6;
        public const int Item_ID_Justifier_Sword = 11;
        public const int Item_ID_Comet_Bow = 12;
        public const int Item_ID_Oathbreaker_Sword = 18;

        // ================== Armor Items =============================
        public const int Item_ID_Cloth_Armor = 16;
        public const int Item_ID_Martial_Arts_Gi_Armor = 17;
        public const int Item_ID_Metal_Armor = 19;


        // ==================== Loot ==================================

        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_DRAGON_LORD_SKULL = 13;
        public const int ITEM_ID_LORD_OF_DEMON_REALM_HAND = 14;

        // =================== Healing items ==========================

        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_ADVANCED_HEALING_POTION = 15;

        // ================== MISC ITEMS =============================

        public const int ITEM_ID_ADVENTURER_PASS = 10;

        //============================================================

        // ================= Monster ==========================
        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GAINT_SPIDER = 3;
        public const int MONSTER_ID_DRAGON = 4;
        public const int MONSTER_ID_MAGICAN = 5;
        public const int MONSTER_ID_LORD_OF_DEMON_REALM = 6;

        //==================== QUEST ==============================



    }
}
