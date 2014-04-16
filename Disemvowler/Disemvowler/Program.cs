using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvowler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling Disemowler with strings
            Disemvowler("Nickleback is my favorite band. Their songwriting can't be beat!");
            Disemvowler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvowler("I'm a code ninja, baby. I make the functions and I make the calls.");
            Console.ReadKey();
        }
        //Create Disemvoweler
        static void Disemvowler(string inString)
        {
            //Declaring variables
            var inVowels = "";
            var inConsenants = "";
            var newString = inString.ToLower();
            //For loop to test for vowels
            for (int i = 0; i < inString.Length; i++)
            {
                //If it's a vowel or special character...
                if (newString[i].ToString() == "a" || newString[i].ToString() == "e" || newString[i].ToString() == "i" || newString[i].ToString() == "o" || newString[i].ToString() == "u" || newString[i].ToString() == " " || newString[i].ToString() == "'" || newString[i].ToString() == "?" || newString[i].ToString() == "!" || newString[i].ToString() == "." || newString[i].ToString() == ",")
                {
                    //Add it to a variable called inVowels. If it's not a vowel.....
                    inVowels = inVowels + inString[i].ToString();
                }
                else
                {
                    //Add it to inConsenants
                    inConsenants = inConsenants + inString[i].ToString();
                }
            }
            //Print "Original: <the original string>
            //Print "Disemvowled: <the disemvowled strings>
            Console.WriteLine("Original: "+inString);
            Console.WriteLine("Disemvoweled: "+inConsenants);
        }
    }
}
