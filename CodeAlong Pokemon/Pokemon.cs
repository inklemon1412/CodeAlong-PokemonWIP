using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong_Pokemon
{
    internal class Pokemon
    {
        public string _name;
        public string _type;
        public int _strength;
        public int _health;

        public Pokemon(string Name, string Type, int Strength, int Health)
        {
            _name = Name;
            _type = Type;
            _strength = Strength;
            _health = Health;
        }
        public Pokemon()
        {

        }

        public void PokemonMenu(List<Pokemon> allPokemon)
        {
            PrintAllPokemon(allPokemon);
        }

        public void PrintAllPokemon(List<Pokemon> allPokemon)
        {

            foreach (var pokemon in allPokemon)
            {
                Console.WriteLine($"Pokemon Name: {pokemon._name}");
                Console.WriteLine($"Pokemon Type: {pokemon._type}");
                Console.WriteLine($"Pokemon Health: {pokemon._health}");
                Console.WriteLine($"Pokemon Strength: {pokemon._strength}");
            }
        }
        public void choosePokemon(List<Pokemon> allPokemon)
        {
            while (true)
            {

                Console.WriteLine("Which Pokemon would you like to choose?");
                var ChosenPokemon = Console.ReadLine();
                switch (ChosenPokemon)
                {
                    case "1":
                        ChooseEevee();
                        break;
                    case "Pikachu":
                        ChoosePikachu();
                        break;
                    case "Grovyle":
                        ChooseGrovyle();
                        break;

                }
            }

        }
        public void ChooseEevee()
        {

        }
        public void ChoosePikachu()
        {

        }
        public void ChooseGrovyle()
        {

        }
        public void FightMenu(List<Pokemon> allPokemon)
        {
            while (chosenPokemon._health  > 0 && enemyPokemon._health > 0) 
            {

            }
        }
    }
}

           
 

    

