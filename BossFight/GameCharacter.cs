using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    internal class GameCharacter
    {
        public int _health { get; set; }
        public int _strength { get; set; }
        public int _stamina {  get; set; }
        public int maxStamina { get; set; }
        public GameCharacter(int health, int stamina)
        {
            _health = health;
            maxStamina = stamina;
            _stamina = maxStamina;
        }
        public void Recharge()
        {
            _stamina = maxStamina;
        }

    }



}
