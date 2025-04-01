using HeroFightMonsters.Models;
using HeroFightMonsters;
using System;

namespace HeroFightsMonsters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hero Fights Monsters!");
            Console.WriteLine("What's your name?");
            string playerName = Console.ReadLine();

            Hero hero = new Hero(playerName, 100, 10); 

            Console.WriteLine($"Welcome, {hero.Name}! Your adventure begins now.");

            CombatManager.GameLoop(hero);

            Console.WriteLine("Thank you for playing!");
        }
    }
}
