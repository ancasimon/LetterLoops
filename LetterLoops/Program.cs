using System;
using System.Linq;
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
            //Console.WriteLine($"userInput: { userInput }");

            //2 - change the word into an array of single characters;
            char[] charArray = userInput.ToCharArray();
            //Console.WriteLine($"charArray: { charArray }");

            //ALSO need to create a copy of the char array so that I can push the final result of each letter that I want to print into the appropiate index places in this array:
            var finalCharList = charArray.Select( c => c.ToString()).ToArray();
            //Console.WriteLine($"finalCharList when first copied: { finalCharList }");

            //3 - loop over each character in the new char array and print it out and then push each character into the new finalCharList I created as a copy above:
            for (int i = 0; i < charArray.Length; i++)
            {
                //Console.WriteLine(charArray[i]);
                var indexNum = i;
                var singleChar = string.Join("", Enumerable.Repeat(charArray[i], i+1));
                //Console.WriteLine(i);
                finalCharList[i] = UpperCaseFirst(singleChar);
            }

            static string UpperCaseFirst(string s)
            {
                //First - check for empty string:
                if (string.IsNullOrEmpty(s))
                {
                    return string.Empty;
                }
                //Return string with capitalized first letter.
                char[] a = s.ToCharArray();
                a[0] = char.ToUpper(a[0]);
                return new string(a);
            }

            Console.WriteLine($"Your word is made up of:" + string.Join('-', finalCharList));
        }

    }
}
