using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    internal class Boss : GameCharacter
    {
        public Boss(int health, int stamina) : base(health, stamina)
        {
        }
        public static int GiveBossStrength()
        {
            Random random = new Random();
            var rnd = random.Next(0, 21);
            return rnd;
        }
        public void Figth(Hero hero)
        {
            if (_stamina > 0)
            {
                _stamina -= 10;
                int strength = GiveBossStrength();
                hero.LooseHealth(strength);
                Console.WriteLine($"Boss has hit hero for {strength} damage!");
                Console.WriteLine($"Hero has {hero._health} health left");
            }
            else if (_stamina <= 0)
            {
                Recharge();
            }
        }
    }
}
