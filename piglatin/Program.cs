using System.Runtime.ExceptionServices;
using System.Xml.Serialization;

namespace piglatin
{
    internal class Program
    {
        static void Main()
        {

            while (true)
            {


                Console.WriteLine("Enter a word to convert to pig latin!");
                string input = Console.ReadLine().ToLower();



                while (input == string.Empty)
                {
                    Console.WriteLine("You must enter a word!");
                    input = Console.ReadLine();
                    continue;
                }


                // running piglatin 
                string piglatin = ToPigLatin(input);
                Console.WriteLine(piglatin);


                // run program again

                if (RunAgain() == false)
                    break;
            }
        }

        public static string ToPigLatin(string word)
        {
            string result = string.Empty;
            string pigSuffixVowelFirst = "way";
            string pigSuffixConstanantsFirst = "ay";

            string vowels = "aeiouAEIOU";

            if (vowels.Contains(word.First()))
            {
                result = word + pigSuffixVowelFirst;
            }
            else
            {
                int count = 0;
                string end = string.Empty;
                foreach (char c in word)
                {
                    if (!vowels.Contains(c))
                    {
                        end += c;
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                result = word.Substring(count) + end + pigSuffixConstanantsFirst;
            }
            return result;
        }


        static bool RunAgain()
        {
            Console.WriteLine("Would you like to convert another sentence? Y/N");
            string restart = Console.ReadLine().ToLower();
            if (restart == "y")
            {
                return true;
            }
            else if (restart == "n")
            {
                // ends the program
                Console.WriteLine(" Have a great day !");
                return false;
            }
            else
            {
                // runs the program again
                Console.WriteLine(" Im sorry, im not sure what that meant.");
                return RunAgain();
            }

        }

    }
}