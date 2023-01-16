using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolGameTemp
{
    internal class GameCharacter
    {
        //fields
        public int health = 100;

        //methods
        public void TakeDamage(int hp)
        {
            health -= hp;
            if (health < 0)
                health = 0;
        }
        public void ShowStat()
        {
            Console.WriteLine("health = " + health);
        }
        
       
    }
}
