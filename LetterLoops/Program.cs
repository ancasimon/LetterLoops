using System;
using System.Runtime.Serialization.Formatters;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a random word!");

            //1 - capture the word from the user:
            var userInput = Console.ReadLine();
            Console.WriteLine($"userInput: { userInput }");

            //2 - change the word into an array of single characters;
            char[] charArray = userInput.ToCharArray();
            Console.WriteLine($"charArray: { charArray }");

            var finalCharList = charArray;

            //3 - loop over each character in the new array and print it out (just once at this point!):
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
                var singleChar = charArray[i];
                finalCharList[i] = singleChar;
            }

            Console.WriteLine($"Your word is made up of:" + string.Join('-', finalCharList));
        }
    }
}
