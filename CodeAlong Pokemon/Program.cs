/*
 Du skal lage et utvalg av forskjellige pokemon med ulik styrke og helse som lever i pokemonworld. 
Brukeren skal kunne velge en av disse han ønsker å spille med.
Motstanderen velges så tilfeldig blant utvalget som er igjen.
Disse to skal kjempe mot hverandre til en av dem har 0 i helse. 
Consollen logger ut hvor mye helse de har igjen for hvert slag. Brukeren skal også kunne velge å “fange en ny pokemon” som blir med i utvalget hans.
 */
using CodeAlong_Pokemon;

Pokemon pokemon = new Pokemon();
List<Pokemon> allPokemon = new List<Pokemon>()
            {
                new Pokemon("Pikachu", "Electric", 40, 50),
                new Pokemon("Eevee", "Normal", 20, 10),
                new Pokemon("Grovyle", "Grass", 60, 100),
            };
Main();

void Main()
{
    while (true)
    {
        Console.Clear();

        Console.WriteLine("What would you like to do?");

        MainMenu();
    }
}
void MainMenu()
{
    Console.WriteLine("1) See Pokemon");
    Console.WriteLine("2) Choose a pokemon to fight with");

    var userInput = Console.ReadLine();
    switch (userInput)
    {
        case "1":
        pokemon.PokemonMenu(allPokemon); 
           break;
        case "2":
        pokemon.choosePokemon(allPokemon);
           break;
        case "3":
       pokemon.FightMenu(allPokemon);
    break;
            
        
        
        
        
    }
}
