using System;
using System.Collections.Generic;
using System.Text;

namespace TheGame
{
    public class GameCharacter
    {
        //properties & fields//

        public string Name { get; set; }

        public string Race { get; set; }

        public string CharacterType { get; set; }

        public string Weapon { get; set; }

       

        



        //constructors//
        public GameCharacter()
        {
        //empty constructor for villian creation later//
        }
        public GameCharacter(string name, string race, string weapon)
        {
            Name = name;
            Race = race;
            Weapon = weapon;
           
        }


        //methods//

        public string CharacterName()
        {
            Console.WriteLine("Well met young traveler, what is thy name?");
            string name = Console.ReadLine();
            return name;
        }

        public string BeginChracterCreation()
        {
            Console.WriteLine("Choose a race: Human, Elf, Goblin, Dwarf");

            string race = Console.ReadLine();

            switch (race)
            {
                case "human":
                case "Human":
                    Console.WriteLine("Humans, while weak show promise.");
                    break;

                case "Elf":
                case "elf":
                    if(race == "elf" || race == "Elf")
                    {
                        Console.WriteLine("You must choose between the dark, the light or are you just a half-elf?");
                        race = Console.ReadLine().ToLower();
                    }
                    Console.WriteLine("Interesting, very interesting");
                    break;

                case "Goblin":
                case "goblin":
                    Console.WriteLine("Goblins are fiesty and fierce creatures");
                    break;

                case "dwarf":
                case "Dwarf":
                    Console.WriteLine("Dwarvian warriors are the most cunning and resilent");
                    break;
            }

            return race;
        }




        public string WeaponSelection()
        {
            Console.WriteLine("Weapon choice: Sword and sheild, bow and arrows, Bo staff, or daggers");
            string userClass = Console.ReadLine();

            switch (userClass)
            {
                case "Sword and sheild":
                case "sword and sheild":
                case "sword":
                    Console.WriteLine("Ahhh, like the great Aurthur Pendragon you weild a great sword");
               break;

                case "bow and arrows":
                case "Bow and Arrows":
                case "bow":
                    Console.WriteLine("Hmmm, expert marksmen you say?");
                    break;

                case "Bo staff":
                case "staff":
                case "bo staff":
                    Console.WriteLine("You are strong and resilient like an oak");
                    break;

                case "Daggers":
                case "daggers":
                    Console.WriteLine("Be swift and nimble, young travler these will aid you well");
                    break;
            }

            return userClass;
        }



    }
}
