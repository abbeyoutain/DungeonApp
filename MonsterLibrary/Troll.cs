using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary; //added

namespace MonsterLibrary
{
    public class Troll : Monster
    {

        //fields

        //properties
        public bool IsAncient { get; set; }

        //constructors
        public Troll()
        {
            Name = "Ancient Troll";
            Description = "Fearsome green-skinned giants, trolls eat anything they can catch and devour. Only acid and fire can arrest the regenerative properties of a troll’s flesh.";
            HitChance = 6;
            BlockChance = 18;
            MaxLife = 30;
            Life = 30;
            AttackName = "Poison Claw";
            MaxDamage = 12;
            MinDamage = 2;

            IsAncient = true;
        }

        public Troll(string name, string description, int hitChance, int blockChance, int maxLife, int life, string attackName, int maxDamage, int minDamage)
            : base(name, description, hitChance, blockChance, maxLife, life, attackName, maxDamage, minDamage)
        {
            IsAncient = IsAncient;
        }//end FQ CTOR

        //methods
        public override string ToString()
        {
            return base.ToString() + (IsAncient ? "Ancient Troll" : "Troll");
        }//end ToString()

    }//end class
}//end namespace
