using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber6
{
    class Program
    {
        static void Main(string[] args)

            
        {
            string word;
            string sub1;
            string way = "way";
           // string[] word1;
            int wordCount = 0;
           char [] consonants = {'B','C','D', 'F', 'G','H','J', 'K', 'L', 'M','N','P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W','Y','X','Z' };
            //word1 = new string[word.Length];

            Console.WriteLine("Enter in a word so that I may translate from Pig Latin ==> to English");
            word = Console.ReadLine().ToLower();
          //  wordCount = word.Length;
            
           // word1 = new string[wordCount];
            
          //  for (int i = 0; i < word.Length; i++)
            {
                if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u')
                {
                    word += way;

                    Console.WriteLine(word);
                    Console.WriteLine("Do you want to translate another word? Y or No");
                }


                //else if ( word[0] == consonants[0] || word[0] == consonants[1] || word[0] == consonants[2] || word[0] == consonants[3] ||
                //    word[0] == consonants[4] || word[0] == consonants[5] || word[0] == consonants[6] || word[0] == consonants[7] || word[0] == consonants[8]
                //    || word[0] == consonants[9] || word[0] == consonants[10] || word[0] == consonants[11] || word[0] == consonants[12] 
                //    || word[0] == consonants[13] || word[0] == consonants[14] ||word[0] == consonants[15] || word[0] == consonants[16]
                //    || word[0] == consonants[17] || word[0] == consonants[18] || word[0] == consonants[19] || word[0] == consonants[20] )
                //{

                //}
                else
                {
                    char[] vowels = {'a','e', 'i', 'o', 'u' };
                    int index = word.IndexOfAny(vowels);                    //Grabs the vowel and whatever is after it
                   Console.WriteLine(word.Substring(index) + word.Substring(0,index));      //subString(0,index) grabs the beginning of the word all the way up too the vowel
                    


                }
                //for (int i = 0; i < word.Length; i++)
                //{
                //    if (word[0] == consonants[0] || word[0] == consonants[1] || word[0] == consonants[2] || word[0] == consonants[3] ||
                //  word[0] == consonants[4] || word[0] == consonants[5] || word[0] == consonants[6] || word[0] == consonants[7] || word[0] == consonants[8]
                //   || word[0] == consonants[9] || word[0] == consonants[10] || word[0] == consonants[11] || word[0] == consonants[12] 
                //   || word[0] == consonants[13] || word[0] == consonants[14] ||word[0] == consonants[15] || word[0] == consonants[16]
                //    || word[0] == consonants[17] || word[0] == consonants[18] || word[0] == consonants[19] || word[0] == consonants[20])
                //    {
                //        while(word.Length > 0)
                //        {
                //            word.IndexOfAny(consonants, 0, word.Length);

                //        }
                       
                //    }
                //}
            }
            //if (word.IndexOf(word) == '' )
            //{

            //}

        }
    }
}
