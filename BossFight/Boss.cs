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
            var rnd = random.Next(0, 31);
            return rnd;
        }
        public void Figth(Hero hero)
        {
            if (_stamina > 0)
            {
                _stamina -= 10;
                int strength = GiveBossStrength();
                hero._health -= strength;
                Console.WriteLine($"Boss has hit hero for {strength} damage!");
            }
            else if (_stamina <= 0)
            {
                Recharge();
            }
        }
    }
}
