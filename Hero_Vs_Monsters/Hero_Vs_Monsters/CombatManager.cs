namespace HeroFightMonsters
{
    using HeroFightMonsters.Models;
    using System;

    public class CombatManager
    {
        private static readonly Random random = new Random();

        // randomly generate monsters
        public static Monster GenerateRandomMonster()
        {
            int choice = random.Next(0, 3);

            return choice switch
            {
                0 => new Goblin(),
                1 => new Dragon(),
                _ => new Phantom(),
            };
        }

        // turn based combat logic
        public static bool Combat(Hero hero, Monster monster)
        {
            Console.WriteLine($"\nYou encounter a monster: {monster.Name} (HP: {monster.Health}, Attack: {monster.AttackPoints})");

            while (hero.IsAlive() && monster.IsAlive())
            {
                // heros turn
                Console.WriteLine("\nYour Turn:");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Run Away");
                Console.Write("Choose your action: ");

                string action = Console.ReadLine();

                if (action == "1")
                {
                    hero.Attack(monster);
                    if (!monster.IsAlive())
                    {
                        Console.WriteLine($"You defeated the {monster.Name}!");
                        return true; // hero won
                    }

                    // monsters turn
                    Console.WriteLine($"\n{monster.Name}'s Turn:");
                    monster.Attack(hero);
                    if (!hero.IsAlive())
                    {
                        Console.WriteLine("You were defeated...");
                        return false; // hero lost
                    }
                }
                else if (action == "2")
                {
                    Console.WriteLine("You ran away!");
                    return true; // hero ran away
                }
                else
                {
                    Console.WriteLine("Invalid Input, try again!");
                }
            }

            return hero.IsAlive(); // returns if hero is alive after combat
        }

        // game ending conditions
        public static void GameLoop(Hero hero)
        {
            int monstersDefeated = 0;
            int monstersToDefeat = 3;

            Console.WriteLine($"\nWelcome, {hero.Name}! Your quest is to defeat {monstersToDefeat} monsters.");

            while (hero.IsAlive() && monstersDefeated < monstersToDefeat)
            {
                Monster monster = GenerateRandomMonster();
                bool combatResult = Combat(hero, monster);

                if (combatResult && hero.IsAlive())
                {
                    monstersDefeated++;
                    Console.WriteLine($"\nMonsters Defeated: {monstersDefeated}/{monstersToDefeat}");
                }
                else
                {
                    break; // end the game if the hero dies or runs away
                }
            }

            if (!hero.IsAlive())
            {
                Console.WriteLine("Game Over! You were defeated.");
            }
            else if (monstersDefeated == monstersToDefeat)
            {
                Console.WriteLine($"Congratulations, {hero.Name}! You have defeated {monstersToDefeat} monsters and won the game!");
            }
            else
            {
                Console.WriteLine("Game Over!"); // for any other reason the game ended
            }
        }
    }
}