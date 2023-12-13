using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyFighter
{
    public class Hero: Character
    {
        public Hero(string name, int health, int attackPoints, int defensePoints): base(name, health, attackPoints, defensePoints)
        {

        }
        public Roles Role { get; set; } = Roles.Warrior;
    }

    //elenco tipizzato
    public enum Roles
    {
        Warrior, Cleric, Rogue, Mage
    }
}
