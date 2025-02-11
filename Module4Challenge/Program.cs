using System;  // rememebring to take note of how these programs are initially set up to use in VSCode. Environments are very differet
namespace Module4Challenge // namespace is name of the space the project is in 
{
    class Program // name of program
    {
        static void Main(string[] args) // dont forget your main method
        {
            Console.WriteLine("Prepare for The Random Dad Joke Generator!");
            TwoRandomDadJokes(); // calling the method which will contain the array, the random class, the operators, vriables and print statement
            //todo notes below
            // use Random to access array by index - used this code to verify jokes. Can be accessed via string/joke. 
            /*foreach (string joke in dadJoke)
                {
                //string joke = dadJoke[a];
                Console.WriteLine($"{joke}");
                }
            */ 
            
            // use random and index to print random dad joke
            void TwoRandomDadJokes() // method created to obtain two random dadjokes
            {
                string[] dadJokes = new string[12] {
                "Hey, pull my finger\n",
                "\"belches\"\n", 
                "Here I got you this!\n *hands you a rock* \n You rock!\n", 
                "Did you hear about the weather today? They said it was going to be windy\n *farts*\n", 
                "It's noon somewhere! *slams glass of MetaMucil*\n", 
                "Happy 19th birthday buddy! (just turned 24)\n", 
                "Do you know how I met your mother? You don't? Okay, when you find out please let me know buddy. Remember when I slept on the couch for a month last fall? I'm going to write it down this time.\n", 
                "MATH homework?? ...\n..go ask your mother\n", 
                "Knock, knock!\n Who's there?\n Not me, nice try debt collectors!\n", 
                "Locked in? The only thing I'm locked into is this interest rate! 9% APR? What is this, the '20s?\n", 
                "Your brakes are running out?? You better run after them, you need those!\n", 
                "Hi hungry I'm Kevin, get a job.\n"
                };
            // dad jokes above, format is easier to read and \n allows output to be more readable as well
                
                Console.WriteLine("Would you like to hear two Dad Jokes? (Y/N)"); // code used from Microsoft learn, dice game, changed methods and returns to match current program. placed code inside 
                if (AnotherJoke()) // method to call method
                {
                    TellJoke();
                }

                bool AnotherJoke()  // method to check user input
                {
                    string response = Console.ReadLine();
                    return response.ToLower().Equals("y");
                }

                void TellJoke() // main portion of method used to actually access array and use random class
                {
                    var tell = true;

                    while (tell) 
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Random rand = new Random();
                            int index = rand.Next(dadJokes.Length);
                            Console.WriteLine($"Dad Joke {index}:\n {dadJokes[index]}");
                            i++;
                        
                        }
                    Console.WriteLine("\nHear more jokes? (Y/N)"); // output to ask user if they would like to hear more, 
                    tell = AnotherJoke();
                    }
                }
            // practice code
                /*foreach (string joke in dadJokes)
                {
                    for (int i = 0; i < 13; i++)
                    {
                        string jokeOne = randomJoke.ToString();
                        string jokeTwo = randomJoke.ToString();
                        Console.WriteLine($"{jokeOne}\n {jokeTwo}");
                    }*/
                           // ask user to hear another (Y/N)
            //int randomDadJoke = rnd.Next(1, 13); - template - use for later
        
            }
        }
    }
}


/* final notes section:
*/