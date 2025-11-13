namespace MadLibs;

class Program
{
    static void Main(string[] args)
    {
        string[] wordPrompts = ["Please enter an Adjective: ", "Please enter a Plural Noun: ", "Please enter a Verb (Past Tense): ", "Please enter a Noun (Singular): ", "Please enter an Adverb: ", "Please enter an exclamation: ", "Please enter a color: "];
        string[] words = new string[7];
        string? input = "";
        int storyNumber = 0;
        
        Console.WriteLine("Hello and Welcome to Mad Libs!");
        Console.WriteLine();
        Console.WriteLine("You can choose one of 5 stories.");


        while ((storyNumber < 1 || storyNumber > 5))
        {
            Console.WriteLine("Which story would you like to use? (Enter a number between 1 and 5)");
            input = Console.ReadLine();
            int.TryParse(input, out storyNumber);
        }
		
		Console.WriteLine("Great choice!. Let's get started.");
		
		for(var i = 0; i < wordPrompts.Length; i++) {
			Console.WriteLine(wordPrompts[i]);
			words[i] = Console.ReadLine().Trim();
			
			if(words[i].ToLower() != words[i]) {
				words[i] = words[i].ToLower();
			}
		}
		
        string[] stories = [
	        $"Dating is tough, so here are a few {words[0]} tips.\nOn your first date, make sure to bring a bouquet of live {words[1]} and one single, bright {words[6]} {words[3]}.\nWhen you arrive, tell a joke that you {words[2]} {words[4]} during lunch.\nIf the date is going badly, just shout {words[5]}! and run away.\nThey'll definitely call you back for another try at that thrilling experience.", 
	        $"Our mission to the far side of the moon was going smoothly until the {words[0]} Captain Zorp decided to sneeze near the main control panel.\nSuddenly, the ship {words[2]} uncontrollably, veering sharply away from the planned trajectory.\nThe computers flashed {words[6]}, warning us to act {words[4]}.\nLuckily, we had a backup plan involving a dozen {words[1]} and one essential {words[3]}.\nWe quickly deployed them.\n{words[5]}, we were safe! Though slightly traumatized, we managed to land, and Captain Zorp promised never to eat spicy chili before a launch again.", 
	        $"Today, I attempted to make the world’s most {words[0]} lasagna.\nI was supposed to layer the dish with {words[1]}, but I accidentally {words[2]} the entire container of cheese right onto the floor.\nI looked down and saw the cheese mixing with a bright {words[6]} puddle.\nMy only working kitchen appliance, the {words[3]}, suddenly began buzzing {words[4]}.\n{words[5]}, I decided the recipe was a failure! Despite the chaos, I grabbed a spoon and ate it all anyway.", 
	        $"After three years of digging, the {words[0]} Dr. Penelope Featherbottom, a renowned Archaeologist, finally found the hidden entrance to the legendary Tomb of Gork.\nShe {words[2]} the giant stone door {words[4]} and stepped inside.\nThe interior was littered with ancient {words[1]} and, sitting on a pedestal, was the royal prize: a small {words[3]}.\nIt was painted a vibrant {words[6]} and guarded by two small, glowing statues.\n{words[5]}! Dr. Featherbottom knew this was the find of the century!", 
	        $"The bell rang, signaling the arrival of the substitute teacher.\nShe was wearing a truly {words[0]} shirt and carrying two massive piles of {words[1]}.\nHer first instruction was for everyone to find a small {words[3]} and hold it in their hands.\nThe teacher then {words[2]} the instructions on the whiteboard {words[4]}.\nWhen she turned around, the class saw a huge, messy smear of {words[6]} paint on the back of her jacket.\n{words[5]}, this was going to be an unforgettable day."];

        Console.WriteLine();
        Console.WriteLine("Here is your story.");
		Console.WriteLine(stories[storyNumber-1]);
        
    }
}