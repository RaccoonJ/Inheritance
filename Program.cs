using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolGameTemp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance");
            Console.WriteLine("-----------");
            Console.WriteLine("");

            //Instantiate Classes
            GameCharacter gameCharacter = new GameCharacter();
            Player player = new Player();
            Enemy enemy = new Enemy();

            gameCharacter.ShowStat();
            gameCharacter.TakeDamage(50);
            gameCharacter.ShowStat();

            player.ShowStat();
            player.TakeDamage(15);
            player.ShowStat();
            Console.WriteLine("Lives = " + player.Lives);
            
            enemy.ShowStat();
            enemy.TakeDamage(15);
            enemy.ShowStat();

            Console.WriteLine("Press any key to exit . . .");
            Console.ReadKey(true);
        }
    }
}
