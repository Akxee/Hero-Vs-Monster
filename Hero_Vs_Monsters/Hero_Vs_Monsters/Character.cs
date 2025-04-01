namespace Hero_Vs_Monsters
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPoints { get; set; }

        public Character(string name, int health, int attackPoints)
        {
            Name = name;
            Health = health;
            AttackPoints = attackPoints;
        }

        public virtual void Attack(Character opponent)
        {
            opponent.TakeDamage(AttackPoints);
            Console.WriteLine($"{Name} attacks {opponent.Name} for {AttackPoints} damage.");
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} takes {damage} damage! Remaining HP: {Health}");
        }

        public bool IsAlive()
        {
            return Health > 0;
        }
    }
}
