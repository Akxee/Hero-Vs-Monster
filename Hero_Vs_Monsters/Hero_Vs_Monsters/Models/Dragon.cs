using Hero_Vs_Monsters;

namespace HeroFightMonsters.Models
{
    public class Dragon : Monster
    {
        public Dragon() : base("Dragon", 50, 15) { }

        public override void Attack(Character opponent)
        {
            Console.WriteLine($"{Name} breathes fire!");
            base.Attack(opponent);
        }
    }
}
