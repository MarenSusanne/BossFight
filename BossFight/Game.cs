using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    internal class Game
    {
        public void StartBattle(Hero hero, Boss boss) 
        {                
            int i = 1;
            bool inFigth = true;
            while (inFigth)
            {
                Console.WriteLine($"Round: {i}");
                hero.Figth(boss);
                boss.Figth(hero);
                i++;
                if (hero._health <= 0)
                {
                    Console.WriteLine("The boss has defeated the hero!");
                    inFigth=false;
                }
                if(boss._health <= 0)
                {
                    Console.WriteLine("The hero has defeated the boss!");
                    inFigth=false;
                }

            }
        }
    }
}
