using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster: Character
    {
        //fields
        private int _minDamage;

        //properties
        public string AttackName { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value <= MaxDamage)
                {
                    _minDamage = value;
                }//end if
                else
                {
                    _minDamage = 1;
                }//end else
            }//end set
        }

        //constructors
        public Monster()
        {

        }//end default CTOR

        public Monster(string name, string description, int hitChance, int blockChance,
            int maxLife, int life, string attackName, int maxDamage, int minDamage)
            : base(name, description, hitChance, blockChance, maxLife, life)
        {
            Name = name;
            Description = description;
            HitChance = hitChance;
            BlockChance = blockChance;
            MaxLife = maxLife;
            Life = life;
            AttackName = attackName;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
        }//end FQ CTOR

        //methods
        public override string ToString()
        {
            return $"This is a {Name}.\n" +
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
