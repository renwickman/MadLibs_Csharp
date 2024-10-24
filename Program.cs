using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program makes short stories with blanks for the player to fill in that represent different parts of speech
      Author: Anthony Renwick
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Mad Libs is starting!");

      // Give the Mad Lib a title:
      string title = "Kind of a Funny Story";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.WriteLine("Enter your name:  ");
      string name = Console.ReadLine();

      Console.WriteLine($"Okay {name}, Enter 3 adjectives");
      Console.WriteLine("First adjective:");
      string adjective1 = Console.ReadLine();
      Console.WriteLine("Second adjective:");
      string adjective2 = Console.ReadLine();
      Console.WriteLine("Third adjective:");
      string adjective3 = Console.ReadLine();

      Console.WriteLine($"Here are your adjectives: {adjective1}, {adjective2}, {adjective3}");


      Console.WriteLine("Enter a verb: ");
      string verb1 = Console.ReadLine();
      Console.WriteLine($"Enter 2 nouns");
      Console.WriteLine("First noun:");
      string noun1 = Console.ReadLine();
      Console.WriteLine("Second noun:");
      string noun2 = Console.ReadLine();


      Console.WriteLine("Enter an animal:");
      string animal1 = Console.ReadLine();
      Console.WriteLine("Enter a food:");
      string food1 = Console.ReadLine();
      Console.WriteLine("Enter a fruit:");
      string fruit1 = Console.ReadLine();
      Console.WriteLine("Enter a superhero:");
      string superhero1 = Console.ReadLine();
      Console.WriteLine("Enter an country:");
      string country1 = Console.ReadLine();
      Console.WriteLine("Enter a dessert:");
      string dessert1 = Console.ReadLine();
      Console.WriteLine("Enter a year:");
      string year1 = Console.ReadLine();

      // The template for the story:

      string story = $"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal1}s were protesting to keep {food1} in stores. They began to {verb1} to the rhythm of the {noun1}, which made all the {fruit1}s very {adjective3}. Concerned, {name} texted {superhero1}, who flew {name} to {country1} and dropped {name} in a puddle of frozen {dessert1}. {name} woke up in the year {year1}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}
