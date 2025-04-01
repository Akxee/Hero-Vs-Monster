using Hero_Vs_Monsters;

namespace HeroFightMonsters.Models
{
    public abstract class Monster : Character
    {
        public Monster(string name, int health, int attackPoints)
            : base(name, health, attackPoints) { }

    }
}
