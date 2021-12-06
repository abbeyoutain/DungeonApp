using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Player: Character
    {

        //fields

        //properties
        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public Armor EquippedArmor { get; set; }

        //constructors
        public Player(string name, string description, int hitChance, int blockChance, int maxLife, int life)
            : base(name, description, hitChance, blockChance, maxLife, life)
        {
            Name = name;
            Description = description;
            HitChance = hitChance;
            BlockChance = blockChance;
            MaxLife = maxLife;
            Life = life;

            //TODO race stats
            //switch (CharacterRace)
            //{
            //    case Race.Human:
            //        HitChance += 1;
            //        BlockChance += 1;
            //        Life += 1;
            //        MaxLife += 1;
            //        break;
            //    case Race.Elf:
            //        HitChance += 1;
            //        BlockChance += 1;
            //        Life += 1;
            //        MaxLife += 1;
            //        break;
            //    case Race.Orc:
            //        HitChance += 1;
            //        BlockChance += 1;
            //        Life += 1;
            //        MaxLife += 1;
            //        break;
            //    case Race.Goblin:
            //        HitChance += 1;
            //        BlockChance += 1;
            //        Life += 1;
            //        MaxLife += 1;
            //        break;
            //    default:
            //        break;
            //}//end switch
        }//end FQ CTOR

        //methods
        public override string ToString()
        {
            //TODO race descriptions
        //    string raceDescription = "";
        //    switch (CharacterRace)
        //    {
        //        case Race.Human:
        //            raceDescription = "Human";
        //            break;
        //        case Race.Elf:
        //            raceDescription = "Elf";
        //            break;
        //        case Race.Orc:
        //            raceDescription = "Orc";
        //            break;
        //        case Race.Goblin:
        //            raceDescription = "Goblin";
        //            break;
        //        default:
        //            break;
        //    }//end switch

            return $"You are {Name}.\n" +
                $"{Description}.\n" +
                $"Hit Chance: {HitChance}\n" +
                $"Block Chance: {BlockChance}\n" +
                $"Max Life: {MaxLife}\n" +
                $"Current Life: {Life}";
        }//end ToString()

        public override int CalcHitChance()
        {
            return base.CalcHitChance();
        }//end CalcHitChance()

        public override int CalcBlockChance()
        {
            return base.CalcBlockChance();
        }//end CalcBlockChance()

        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(1, 11);

            return damage;
        }//end CalcDamage()

    }//end class
}//end namespace
