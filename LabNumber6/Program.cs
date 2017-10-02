using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber6
{
    class Program
    {

        public static string takeWord(string word)      //Translate word in to pig latin
        {
            string way = "way";

            if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u')
            {
                word += way;

                Console.WriteLine(word);

                return word;
                validate(word);
            }
            else
            {
               // string display = "";
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                int index = word.IndexOfAny(vowels);                    //Grabs the vowel and whatever is after it
                Console.WriteLine(word.Substring(index) + word.Substring(0, index));
                return word ;
                validate(word);
            }
        }
         public static void validate(string word)
        {
            bool cont = true;
            string choice = "";
            Console.WriteLine("Do you want to translate another word? Y or N");

            choice = Console.ReadLine().ToUpper();
            if (choice == "Y")
            {
                return;
            }
            else if (choice == "N")
            {
                Console.WriteLine("Goodbye");
                System.Environment.Exit(1);
            }
            else if (choice != "Y" || choice != "N")
            {
              
                do                                          //If user puts anything else besides Y or N ask for correct input
                {
                    Console.WriteLine("You didnt put a valid answer, please enter right answer, Y or N");
                    choice = Console.ReadLine().ToUpper();
                    if (choice == "Y")
                    {
                        break;
                        
                    }
                    else if (choice == "N")
                    {
                        Console.WriteLine("Good bye..");
                        System.Environment.Exit(1); //Exit program
                        break;
                    }

                } while (choice != "Y" || choice !="N");
               
               
            }

        }


        static void Main(string[] args)
        {
            string word = "";
            string way = "way";
            string choice;
            bool cont = true;

           char [] consonants = {'B','C','D', 'F', 'G','H','J', 'K', 'L', 'M','N','P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W','Y','X','Z' };
        
            while (cont)
            {
                Console.WriteLine("Enter in a word so that I may translate from Pig Latin ==> to English");
                word = Console.ReadLine().ToLower();

                takeWord(word);
                validate(word);


            }

        }

    }


}
                

           
   