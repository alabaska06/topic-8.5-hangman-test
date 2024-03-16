namespace topic_8._5_hangman_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word, displayWord, guessedLetters;
            int tries, randomIndex;
            bool done, found;
            tries = 0;
            done = false;

            List<string> words = new List<string>();
            words.Add("COMPUTER");
            words.Add("PNEUMONIA");
            words.Add("LUXURY");
            words.Add("KIOSK");
            words.Add("STRETCH");
            words.Add("IVORY");
            words.Add("AWKWARD");
            words.Add("DUPLEX");

            Random generator = new Random();
            randomIndex = generator.Next(0, words.Count);
            word = words[randomIndex];
            guessedLetters = "";

            displayWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                displayWord += "_";
            }

            Console.WriteLine("Welcome to Hangman Lite!\n\nGuess letters to find the secret word. \n\nYou have six tries.\n");

            while (!done)
            {

                found = false;
                Console.WriteLine($"Guessed letters: {guessedLetters}");
                Console.WriteLine("Please make your guess:\n");
                char guess = char.ToUpper(Console.ReadLine()[0]);
                Console.Clear();

                if (guessedLetters.Contains(guess))
                {
                    Console.WriteLine("You've already guessed this letter. Please guess another.");
                }
                else
                {
                    guessedLetters += guess;
                    found = false;
                }

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == guess)
                    {
                        displayWord = displayWord.Remove(i, 1).Insert(i, guess.ToString());
                        found = true;
                    }
                }
                if (!found)
                {
                    tries++;
                }
                switch (tries)
                {
                    case 0:
                        hangmanOne();
                        Console.WriteLine($"\n    {displayWord}\n");
                        break;
                    case 1:
                        hangmanTwo();
                        Console.WriteLine($"\n    {displayWord}\n");
                        break;
                    case 2:
                        hangmanThree();
                        Console.WriteLine($"\n    {displayWord}\n");
                        break;
                    case 3:
                        hangmanFour();
                        Console.WriteLine($"\n    {displayWord}\n");
                        break;
                    case 4:
                        hangmanFive();
                        Console.WriteLine($"\n    {displayWord}\n");
                        break;
                    case 5:
                        hangmanSix();
                        Console.WriteLine($"\n    {displayWord}\n");
                        break;
                    case 6:
                        hangmanSeven();
                        Console.WriteLine($"\nYou have lost.\n\nThe word was {word}.");
                        done = true;
                        break;   
                }


                if (displayWord == word)
                {
                    Console.WriteLine("Congratulations! You guessed the word correctly!");
                    done = true;
                }

            }
            static void hangmanOne()
            {
                Console.WriteLine("     +---+\r\n     |   |\r\n         |\r\n         |\r\n         |\r\n         |\r\n   =========");
            }
            static void hangmanTwo()
            {
                Console.WriteLine("     +---+\r\n     |   |\r\n     O   |\r\n         |\r\n         |\r\n         |\r\n   =========");
            }
            static void hangmanThree()
            {
                Console.WriteLine("     +---+\r\n     |   |\r\n     O   |\r\n     |   |\r\n         |\r\n         |\r\n   =========");
            }
            static void hangmanFour()
            {
                Console.WriteLine("     +---+\r\n     |   |\r\n     O   |\r\n    /|   |\r\n         |\r\n         |\r\n   =========");
            }
            static void hangmanFive()
            {
                Console.WriteLine("     +---+\r\n     |   |\r\n     O   |\r\n    /|\\  |\r\n         |\r\n         |\r\n   =========");
            }
            static void hangmanSix()
            {
                Console.WriteLine("     +---+\r\n     |   |\r\n     O   |\r\n    /|\\  |\r\n    /    |\r\n         |\r\n   =========\r\n");
            }
            static void hangmanSeven()
            {
                Console.WriteLine("     +---+\r\n     |   |\r\n     O   |\r\n    /|\\  |\r\n    / \\  |\r\n         |\r\n   =========");
            }
        }
    }
    
}
