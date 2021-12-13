using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Character
    {
        //fields
        private int _life;

        //properties
        public string Name { get; set; }
        public string Description { get; set; }
        public int HitChance { get; set; }
        public int BlockChance { get; set; }
        public int MaxLife { get; set; }
        public int Life
        {
            get { return _life; }
            set
            {
                //Life should not be MORE than MaxLife
                if (value <= MaxLife)
                {
                    //good to go
                    _life = value;
                }//end if
                else if (value < 0)
                {
                    _life = 0;
                }//end else if
                else
                {
                    _life = MaxLife;
                }//end else
            }//end set
        }//end Life

        //constructors
        public Character()
        {

        }//end default CTOR

        public Character(string name, string description, int hitChance, int blockChance, int maxLife, int life)
        {
            Name = name;
            Description = description;
            HitChance = hitChance;
            BlockChance = blockChance;
            MaxLife = maxLife;
            Life = life;
        }//end FQ CTOR

        //methods
        public virtual int CalcHitChance()
        {
            return HitChance;
        }//end CalcHitChance()

        public virtual int CalcBlockChance()
        {
            return BlockChance;
        }//end CalcBlock()

        public virtual int CalcDamage()
        {
            return 0;
            //Will override this in Monster and Player
        }//end CalcDamage()

    }//end class
}//end namespace
