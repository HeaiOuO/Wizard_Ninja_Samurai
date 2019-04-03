using System;
using System.Collections.Generic;

namespace wizard
{
    public class Human
    {
        public string name;
        public int strength{get; set;}
        public int intelligence{get; set;}
        public int dexterity{get; set;}
        public int health{get; set;}

        public Human(string person)
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string person, int str, int intel, int dex, int hp)
        {
            name = person;
            strength = str;
            strength = intel;
            dexterity = dex;
            health = hp;
        }
        public void attack(object obj)
        {
            Human enemy = obj as Human;
            if (enemy != null)
            {
                Console.WriteLine("Attack failed");
            }
            else{
                enemy.health -= strength * 5;
            }
        }
    }
}
