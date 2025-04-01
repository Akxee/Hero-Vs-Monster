namespace HeroFightMonsters.Models
{
    public class Phantom : Monster
    {
        private Random random = new Random();

        public Phantom() : base("Phantom", 30, 10) { }

        public override void TakeDamage(int damage)
        {
            if (random.Next(0, 100) < 50) // 50% chance to dodge
            {
                Console.WriteLine($"{Name} dodged the attack!");
            }
            else
            {
                base.TakeDamage(damage);
            }
        }
    }
}
