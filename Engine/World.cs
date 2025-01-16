using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();
        public static readonly List<Spell> Spells = new List<Spell>();


        // Item index -> 21

        // =================== Weapons ================================
        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_JUSTIFIER_SWORD = 11;
        public const int ITEM_ID_COMET_BOW = 12;
        public const int ITEM_ID_OATHBREAKER_SWORD = 19;

        // ================== Armour Items =============================
        public const int ITEM_ID_CLOTH_ARMOUR = 17;
        public const int ITEM_ID_MARTIAL_ARTS_GI_ARMOUR = 18;
        public const int ITEM_ID_TURTLE_HERMIT_GI_AMROUR = 20;
        public const int ITEM_ID_METAL_ARMOR = 21;


        // ==================== Loot ==================================

        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_DRAGON_SKULL = 13;
        public const int ITEM_ID_LORD_OF_DEMON_REALM_HAND = 14;
        public const int ITEM_ID_LORD_OF_DEMON_REALM_SKULL = 15;

        // =================== Healing items ==========================

        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_ADVANCED_HEALING_POTION = 16;

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
        //INDEX : 5

        public const int QUEST_ID_CLEAR_FIELD = 1;
        public const int QUEST_ID_ALCHEMIST_GARDEN = 2;
        public const int QUEST_ID_HIDDEN_CHEST = 3;
        public const int QUEST_ID_DRAGON_NEST = 4;
        public const int QUEST_ID_SLAY_THE_DEMON_LORD = 5;

        // ================= LOCATION ==============================
        public const int LOCTAION_ID_HOME = 1;
        public const int LOCTAION_ID_OPEN_FIELD = 2;
        public const int LOCTAION_ID_TOWN_SQUARE = 3;
        public const int LOCTAION_ID_BRIDGE = 4;
        public const int LOCTAION_ID_SPIDER_FIELD = 5;
        public const int LOCTAION_ID_ALCHEMIST_HUT = 6;
        public const int LOCTAION_ID_DRAGONS_NEST = 7;
        public const int LOCATION_ID_DEMON_CAVE = 8;


        //============================ SPELLS EFFECT ====================================
        // INDEX: 7
        public const int SPELL_EFFECT_ID_DAMAGE = 1;
        public const int SPELL_EFFECT_ID_HEAL = 2;
        public const int SPELL_EFFECT_ID_RAISE_HP = 3;
        public const int SPELL_EFFECT_ID_RAISE_STRENGTH = 4;
        public const int SPELL_EFFECT_ID_RESTORE_MANA = 5;
        public const int SPELL_EFFECT_ID_TELEPORT = 6;
        public const int SPELL_EFFECT_ID_INVISIBLE = 7;


        //====================== SPELLS ========================== 
        //INDEX : 7
        public const int SPELL_ID_FIREBALL = 1;
        public const int SPELL_ID_FROSTICE = 2;
        public const int SPELL_ID_TELEPORT = 3;
        public const int SPELL_ID_ENDURANCE = 4;
        public const int SPELL_ID_HOLY_NOVA = 5;
        public const int SPELL_ID_RESTORE_HEALTH = 6;
        public const int SPELL_ID_RESTORE_MANA = 7;

        static World()
        {
            PopulateItems();
            PopulateSpells();
            PopulateMonster();
            PopulateQuests();
            PopulateLocation();
        }

        private static void PopulateSpells()
        { // SPELL ID, SPELL NAME, SPELL MANA COST, SPELL EFFECT ID, SPELL DAMAGE, COMBAT SPELL, CUSTOM EFFECT
            Spells.Add(new Spell(SPELL_ID_FIREBALL, "Fireball", 5, SPELL_EFFECT_ID_DAMAGE, 15, true));
            Spells.Add(new Spell(SPELL_ID_FROSTICE, "Frostice", 5, SPELL_EFFECT_ID_DAMAGE, 15, true));
            Spells.Add(new Spell(SPELL_ID_HOLY_NOVA, "Holy Nova", 50, SPELL_EFFECT_ID_DAMAGE, 100, true));
            Spells.Add(new Spell(SPELL_ID_RESTORE_HEALTH, "Heal", 10, SPELL_EFFECT_ID_HEAL, 10, true));
            Spells.Add(new Spell(SPELL_ID_RESTORE_MANA, "Restore Mana", 0, SPELL_EFFECT_ID_RESTORE_MANA, 20, true));
            Spells.Add(new Spell(SPELL_ID_ENDURANCE, "Endurance", 30, SPELL_EFFECT_ID_RAISE_HP, 100, false));
        }


        // =================== Set Items =======================
        private static void PopulateItems()
        {
            // For Weapon = Id, Name, Nameplural, Mindamage, Maxdamage
            // For Armour = Id, Name, Nameplural, Resistance, MagicResistance
            // For Item = Id, Name, Nameplural

            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "Rusty sword", 2, 6));
            Items.Add(new Weapon(ITEM_ID_CLUB, "Wooden Club", "Wooden Club", 1, 5));
            Items.Add(new Weapon(ITEM_ID_JUSTIFIER_SWORD, "Justifier Sword", "Justtifier Sword", 3, 8));
            Items.Add(new Weapon(ITEM_ID_COMET_BOW, "Comet Bow", "Comet Bow", 5, 10));
            Items.Add(new Weapon(ITEM_ID_OATHBREAKER_SWORD, "Oathbreaker Sword", "Oathbreaker Sword", 50, 100));


            Items.Add(new Armour(ITEM_ID_CLOTH_ARMOUR, "Cloth Armour", "Cloth Armour", 5, 0));
            Items.Add(new Armour(ITEM_ID_MARTIAL_ARTS_GI_ARMOUR, "Martial Arts Gi", "Martial Arts Gi", 15, 5));
            Items.Add(new Armour(ITEM_ID_TURTLE_HERMIT_GI_AMROUR, "Turtle Hermit Gi", "Turtle Hermit Gi", 30, 15));
            Items.Add(new Armour(ITEM_ID_METAL_ARMOR, "Metal Armour", "Metal Armour", 50, 50));


            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat Tail", "Rat Tail"));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Piece of fur"));
            Items.Add(new Item(ITEM_ID_SNAKESKIN, "Snake Skin", "Snake Skin"));
            Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake Fang", "Snake Fang"));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider Silk", "Spider Silk"));
            Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider Fang", "Spider Fang"));
            Items.Add(new Item(ITEM_ID_DRAGON_SKULL, "Dragon skull", "Dragon Skull"));
            Items.Add(new Item(ITEM_ID_LORD_OF_DEMON_REALM_HAND, "Demon Realm Hand", "Demon Realm Hand"));
            Items.Add(new Item(ITEM_ID_LORD_OF_DEMON_REALM_SKULL, "Demon Realm Skull", "Demon Realm Skull"));

        }

        // =============================================

        private static void PopulateMonster()
        {
            Monster Rat = new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 3, 3, 0, 0);
            Rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            Rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));

            Monster Snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3, 0, 0);

            Monster GiantSpider = new Monster(MONSTER_ID_GAINT_SPIDER, "Giant Spider", 20, 5, 40, 10, 10, 0, 0);

            Monster Dragon = new Monster(MONSTER_ID_DRAGON, "Dragon", 35, 50, 50, 25, 25, 35, 50);

            Monster Magican = new Monster(MONSTER_ID_MAGICAN, "Magican", 5, 25, 150, 35, 35, 50, 50);

            Monster LordDemon = new Monster(MONSTER_ID_LORD_OF_DEMON_REALM, "Lord of Demon Realm", 150, 500, 1000, 100, 100, 50, 150);

        }

        // =============================================

        private static void PopulateQuests()
        {
            // ==================== Alchemist Garden ========================================
            Quest clearAlchemistGarden =
                new Quest(
                QUEST_ID_ALCHEMIST_GARDEN, 
                "Clear the Alchemist's Garden",
                "Kill the rats in the Alchemist graden and bring back 4 rat tails. You will receive a healing potion and 10 gold coins.", 20, 10);
            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 4));
            clearAlchemistGarden.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);
            // ==============================================================================

            // ===================== Open Field Quest =======================================
            Quest clearOpenField =
                new Quest(
                    QUEST_ID_CLEAR_FIELD,
                    "Clear the farmer's field",
                    "Kill the snakes in the farmer's field and bring back 4 snake fangs. You will receive an adventuer's pass and 20 gold coins.", 20, 20);
            clearOpenField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKE_FANG), 4));
            clearOpenField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKESKIN), 2));
            clearOpenField.RewardItem = ItemByID(ITEM_ID_ADVENTURER_PASS);
            // ==============================================================================

            // ====================== Hidden Chest Quest ==========================================
            Quest findHiddenChest =
                new Quest(
                    QUEST_ID_HIDDEN_CHEST,
                    "Find the hidden chest",
                    "There are rumors of hidden treasures somewhere, I need to find it", 
                    30, 
                    100, 
                    ItemByID(ITEM_ID_OATHBREAKER_SWORD));
            findHiddenChest.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_LORD_OF_DEMON_REALM_HAND), 1));


            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearOpenField);
            Quests.Add(findHiddenChest);
        }

        // =============================================

        private static void PopulateLocation()
        {

        }

        // =============================================

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if(monster.ID == id)
                {
                    return monster;
                }
            }
            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach(Quest quest in Quests)
            {
                if(quest.ID == id)
                {
                    return quest;
                }
            }
            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach(Location location in Locations)
            {
                if(location.ID == id)
                {
                    return location;
                }
            }
            return null;
        }

    }
}
