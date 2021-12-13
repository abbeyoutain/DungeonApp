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
            Description = "Ancient Hag description";
            HitChance = 6;
            BlockChance = 18;
            MaxLife = 30;
            Life = 30;
            AttackName = "Ancient Hag Attack";
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
