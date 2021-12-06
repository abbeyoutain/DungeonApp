using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        //This class will not have fields, props, or any custom ctors.
        //This class is just a "warehouse" for different methods.

        public static void DoAttack(Character attacker, Character defender)
        {
            int diceRoll = new Random().Next(1, 21);

            if ((diceRoll + attacker.CalcHitChance()) >= (defender.CalcBlockChance()))
            {
                //If the attacker hits, calculate the damage
                int damageDealt = attacker.CalcDamage();

                //Assign the damage
                defender.Life -= damageDealt;

                //Write result to screen
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
            }//end if
            else
            {
                Console.WriteLine($"{attacker.Name} missed!");
            }//end else
        }//end DoAttack()

        public static void DoBattle(Player player, Monster monster)
        {
            //Player attacks first
            DoAttack(player, monster);

            //If Monster is alive, attacks second
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }//end if
        }//end DoBattle()

    }//end class
}//end namespace
