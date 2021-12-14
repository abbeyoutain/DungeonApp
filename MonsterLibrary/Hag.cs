using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary; //added

namespace MonsterLibrary
{
    public class Hag : Monster
    {

        //fields

        //properties
        public bool IsAncient { get; set; }
        
        //constructors
        public Hag()
        {
            Name = "Ancient Hag";
            Description = "Hags represent all that is evil and cruel. Though they resemble withered crones, there is nothing mortal about these monstrous creatures, whose forms reflect only the wickedness in their hearts.";
            HitChance = 6;
            BlockChance = 18;
            MaxLife = 30;
            Life = 30;
            AttackName = "Vicious Curse";
            MaxDamage = 12;
            MinDamage = 2;

            IsAncient = true;
        }

        public Hag(string name, string description, int hitChance, int blockChance,
            int maxLife, int life, string attackName, int maxDamage, int minDamage)
            : base(name, description, hitChance, blockChance, maxLife, life, attackName, maxDamage, minDamage)
        {
            IsAncient = IsAncient;
        }//end FQ CTOR

        //methods
        public override string ToString()
        {
            return base.ToString() + (IsAncient ? "Ancient Hag" : "Hag");
        }//end ToString()

    }//end class
}//end namespace
