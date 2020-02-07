using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    class Robot
    {
        //Member Variables (Has A)
        public string name;
        public int healthLevel;
        public int powerLevel;
        public string weaponType;
        public int weaponAttackPower;

        // Constructor (spawner)
        public Robot() 
        {
            this.name = name;
            int health = healthLevel;
            int energy = powerLevel;
            string weapon = weaponType;
            int attackpower = weaponAttackPower;
        }



        //Member Methods (Can Do)
        public void Strike() 
        {
            powerLevel -= 10;
            
        }

        public int Hit(Random random) 
        {
            random.Next(1, 100);
            int x = random.Next(1, 100);
            

            if (x >=70) 
            {
                healthLevel -= 15;
            }
            return healthLevel;
        }


    }
}
