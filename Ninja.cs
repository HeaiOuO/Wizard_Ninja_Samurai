using System;
using System.Collections.Generic;

namespace wizard
{
    public class Ninja : Human
    {
        public Ninja(string n): base(n)
        {
            dexterity = 175;
        }
        public void Steal(object target)
        {
            Human enemy = target as Human;
            if(enemy != null)
            {
                attack(enemy);
                health -= 10;
            }
        }
        public void get_away()
        {
            health -= 5;
        }
    }
}
