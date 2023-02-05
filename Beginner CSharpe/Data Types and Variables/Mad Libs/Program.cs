
namespace MadLibs
{
    class Program
    {
        static void Main()
        {
            /*
            This program is a fill in the blanks game
            Author: Razi Ullah
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Starting Mad Libs...");

            // Give the Mad Lib a title:
            string title = "TITLE: Political Degradation";
            Console.WriteLine(title);

            // Define user input and variables:
            Console.Write("Enter a Name : ");
            string name = Console.ReadLine();
            //---------------------------------------------
            Console.WriteLine("Enter 3 Adjectives...");

            Console.Write("Adjective # 1 : ");
            string adj1 = Console.ReadLine();

            Console.Write("Adjective # 2 : ");
            string adj2 = Console.ReadLine();

            Console.Write("Adjective # 3 : ");
            string adj3 = Console.ReadLine();
            //---------------------------------------------
            Console.WriteLine("Enter 1 Verb...");

            Console.Write("Verb # 1 : ");
            string verb = Console.ReadLine();
            //---------------------------------------------
            Console.WriteLine("Enter 2 Nouns...");

            Console.Write("Noun # 1 : ");
            string noun1 = Console.ReadLine();

            Console.Write("Noun # 2 : ");
            string noun2 = Console.ReadLine();
            //---------------------------------------------
            Console.Write("Enter an Animal : ");
            string animal = Console.ReadLine();
            //---------------------------------------------
            Console.Write("Enter a Food : ");
            string food = Console.ReadLine();
            //---------------------------------------------
            Console.Write("Enter a Fruit : ");
            string fruit = Console.ReadLine();
            //---------------------------------------------
            Console.Write("Enter a Superhero : ");
            string superhero = Console.ReadLine();
            //---------------------------------------------
            Console.Write("Enter a Country : ");
            string country = Console.ReadLine();
            //---------------------------------------------
            Console.Write("Enter a Dessert : ");
            string dessert = Console.ReadLine();
            //---------------------------------------------
            Console.Write("Enter a Year : ");
            string year = Console.ReadLine();
            //---------------------------------------------
            // The template for the story:

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";

            // Print the story:
            Console.WriteLine(story);
        }
    }
}
