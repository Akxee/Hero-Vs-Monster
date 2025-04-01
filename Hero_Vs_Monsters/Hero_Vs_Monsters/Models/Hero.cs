using Hero_Vs_Monsters;

namespace HeroFightMonsters.Models
{
    public class Hero : Character
    {
        public Hero(string name, int health, int attackPoints)
            : base(name, health, attackPoints) { }
    }
}
