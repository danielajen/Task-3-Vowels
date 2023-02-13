using System;

namespace Task_3_Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region setting variables
            string sentence = "";
            int vowels = 0;
            bool isvalid = true;
            #endregion
            //keep track of vowels so we know what's goin on just like we did in hangman with an array
            char[] all = { 'A', 'E', 'I', 'O', 'U'};
            bool[] found = new bool[5];
        

            Console.WriteLine("Enter a sentence:");
            sentence = Console.ReadLine();

            //get the letters in each sentence and make it a (inlude spaces)
            foreach (char a in sentence)
            {  
                if (!char.IsLetter(a) && !char.IsWhiteSpace(a))
                {
                    isvalid = false;
                }
            }

            // make sure they're words
            if (isvalid)
            { //each word
                foreach (char letter in sentence)
                {
                    // setting the caps lock on just like hangman
                    char up = char.ToUpper(letter);
                    if (char.IsLetter(up))
                    {
                        foreach (char vowel in all)
                        { // vowel array that we use to check which is missing and how many vowels they're
                            if (up == vowel)
                            {
                                found[Array.IndexOf(all, vowel)] = true;
                                vowels++;
                            }
                        }
                        

                    }
                }
                //display num of vowels and missing
                    Console.WriteLine("num of vowels: " + vowels);
                for ( int i =0; i < all.Length; i++)
                {
                    if(!found [i])
                    {
                        Console.WriteLine("missing " + all[i] + "");
                    }
                }
                }
            
            else
            {
                Console.WriteLine("invalid only input words for a sentence");
            }
        }
    }
}
               
                

     
    

