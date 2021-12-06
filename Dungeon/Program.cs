using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary; //added

namespace Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Queen Titania's Palace";
            Console.WriteLine(@"
When Queen Titania is away, the fey will play.

Her Majesty has traveled to another land and has sent you to her castle in the Feywild to make sure no mischievous or
malevolent creatures have taken to the place.
");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Welcome {userName}. Standing in the entrance hall, you begin your crusade of the palace.");
            Console.ReadLine();
            Console.Clear();

            //Create the Player and Monster objects (and any other objects we might need for the application).
            Player player = new Player(userName, "Description", 5, 18, 30, 30);
            int score = 0;

            Monster dryad = new Monster("Dryad", "Dryad description.", 2, 12, 20, 20, "Fey Charm", 4, 1);
            Monster ettercap = new Monster("Ettercap", "Ettercap description.", 2, 12, 14, 14, "Attack Name", 4, 1);
            Monster hag = new Monster("Hag", "Hag description.", 4, 16, 30, 30, "Vicious Mockery", 10, 2);
            Monster pixie = new Monster("Pixie", "Pixie description.", 2, 13, 12, 12, "Attack Name", 3, 1);
            Monster quickling = new Monster("Quickling", "Quickling description.", 1, 10, 5, 5, "Attack Name", 3, 1);
            //TODO Add the rest of the monsters and edit all.
            //Monster redcap = new Monster();
            //Monster troll = new Monster();
            //Monster willowisp = new Monster();

            Monster[] monsterArray = new Monster[] { dryad, dryad, ettercap, ettercap, hag, pixie, pixie, pixie, pixie,
                quickling, quickling, quickling, quickling };

            //Create a loop for the room and monster (outer loop).

            bool exit = false;
            do
            {
                //Get room description from a custom method that generates them.
                Console.Clear();
                Console.WriteLine(GetRoom());

                //Choose a Monster for the Player to battle.
                int randomIndex = new Random().Next(monsterArray.Length);
                Monster currentMonster = monsterArray[randomIndex];
                Console.WriteLine($"A {currentMonster.Name} appears! They attack you with their " +
                    $"{currentMonster.AttackName} attack.");

                //TODO 7. Create a loop for the user choice menu (inner loop).
                bool reload = false;
                do
                {
                    Console.WriteLine(@"
Choose an action: 
1. Attack
2. Flee
3. Player Info
4. Monster Info
5. Quit Game
");
                    //Capture user choice.
                    string userChoice = Console.ReadKey(true).Key.ToString();
                    Console.Clear();

                    //Perform an action based on their input.
                    switch (userChoice)
                    {
                        case "D1":
                        case "NumPad1":
                            //Attack/battle functionality.
                            Combat.DoBattle(player, currentMonster);

                            //If Player wins and add +1 to score.
                            if (currentMonster.Life <= 0)
                            {
                                Console.WriteLine($"You killed {currentMonster.Name}!\n" +
                                    $"Head to the next room...");
                                Console.ReadLine();
                                reload = true;
                                score += 1;
                            }//end if
                            break;

                        case "D2":
                        case "NumPad2":
                            //If Player flees, give the Monster a free attack.
                            Console.WriteLine($"{currentMonster.Name} attacks you as you flee!");
                            Combat.DoAttack(currentMonster, player);
                            Console.ReadLine();
                            reload = true;
                            break;

                        case "D3":
                        case "NumPad3":
                            //Display Player info.
                            //TODO Add turnary operator to display enemy/enemies.
                            Console.WriteLine($"{ player}\nYou've defeated {score} enemies.");
                            break;

                        case "D4":
                        case "NumPad4":
                            //Display Monster info.
                            Console.WriteLine(currentMonster);
                            break;

                        case "D5":
                        case "NumPad5":
                        case "Escape":
                            Console.WriteLine("Goodbye");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Thou hast chosen an invalid choice.");
                            break;
                    }//end switch

                    //Check Player Life
                    if (player.Life < 0)
                    {
                        player.Life = 0;
                    }//end if

                    if (player.Life <= player.MaxLife / 2 && player.Life > 0)
                    {
                        Console.WriteLine($"Careful! Your health is at {player.Life} / {player.MaxLife}!");
                    }//end if
                        
                    if (player.Life <= 0)
                    {
                        Console.WriteLine($"You are dead.\n" +
                            "Score: {score}");
                        exit = true;
                    }//end if

                } while (!reload && !exit); //While reload and exit are both NOT TRUE, keep looping.
            } while (!exit); //While exit is NOT TRUE, keep looping.

            Console.WriteLine("End of game.");

        }//end SVM

        private static string GetRoom()
        {
            //TODO Write Titania's Chambers and Guest Chambers.
            string[] rooms =
            {
                "A large archway opens up to a long room with floor to ceiling stained glass windows depicting scenes of fey creatures drinking and dancing. Soft moss covers the entire floor, and dominating the room is a throne made of a delicate willow tree.",
                "A colossal, roughly hewn trunk serves as the dining table in the center of the room set with fine gold plates and crystal and seats for over fifty guests.",
                "You open a set of elegantly carved double doors into the ballroom, a large room made of pale pink marble with water fountains and naiad statues about the room.",
                "You wind your way down to the kitchen. Dozens of pies and cakes cover the room’s surfaces, filling the air with the smells of sweet crust and warm berries.",
                "Titania's Chambers",
                "Guest Chambers",
                "In a quiet corner of the palace, you creak open the door to the library. Bookshelves made from organically shaped tree branches grow everywhere about the large room. Books, scrolls, ink, quills, and various baubles are tucked into the nooks and crannies of the room. A few giant toadstools have grown around the room, providing perfect seats for reading.",
                "You push open the heavy door and step into the treasury. Chests of emeralds and sapphires, velvet bags of gold coins, mannequins in intricately patterned silk dresses and robes, and more fill the room.",
                "You push open the heavy door and step into the armory. The room is filled with rows of golden elven armor, intricately carved wooden stands lined with elegant rapiers, velvet bandoliers of bejeweled daggers, and more.",
                "You crack open an exterior wooden door to open air. You’re in the garden. Brightly colored bulbs in blues, purples, and pinks cover the ground. Fragrant fruit trees surround the perimeter, hung with exotic fruits."
            };

            Random rand = new Random();

            int indexNbr = rand.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;
        }//end GetRoom()

    }//end class
}//end namespace
