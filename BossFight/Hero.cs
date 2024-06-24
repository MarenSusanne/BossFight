using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    internal class Hero : GameCharacter
    {
        public Hero(int health, int streangth, int stamina) : base(health, stamina)
        {
            _strength = streangth;
        }
        public void Figth(Boss boss)
        {
            if (_stamina > 0)
            {
                _stamina -= 10;
                var damageTaken = _strength;
                boss.LooseHealth(damageTaken);
                Console.WriteLine($"Hero has hit boss for {_strength} damage!");
                Console.WriteLine($"Boss has {boss._health} health left");
            }
            else if (_stamina <= 0) 
            {
                Recharge();
            }
        }
    }
}
