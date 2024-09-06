using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3_E3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize variables to store value for multiple iterations
            string userString = "";
            int input = 0;
            //Prints out title of program
            Console.WriteLine("String Manipulation Program");
            //Divides for better visibility
            Console.WriteLine("");
            do 
            {
                //Method that prints out options for user
                promptMessage();
                //Convert user input to integer variable called "input"
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 4) //Able to leave do-while loop
                {
                    break;
                }
                //Divides for better visibility
                Console.WriteLine("");
                //Prompts user to enter a string
                Console.Write("Enter a string: ");
                //User input converted to string variable called "userString" and stores in memory
                userString = Console.ReadLine();
                switch (input)
                {
                    case 1:
                        //String variable created that stores the method's output
                        string reversed = ReverseString(userString);
                        //Prints out the method's reversed string 
                        Console.WriteLine($"{reversed}");
                        break;
                    case 2:
                        //Method that counts how many vowels in string
                        CountVowels(userString);
                        break;
                    case 3:
                        //Method that checks a string if it is a palindrome
                        isPalindrome(userString);
                        break;
                }
            } while (input != 4); //Escape condition for program; input does not equal "4"
        }
        //Method that prints out all user options
        public static void promptMessage()
        {
            //Gives user options on what to do with string
            Console.WriteLine("1. Reverse String");
            Console.WriteLine("2. Count Vowels");
            Console.WriteLine("3. Is it a Palindrome?");
            Console.WriteLine("4. Quit Program");
            //Prompts user to choose option above
            Console.Write("Select an option: ");
        }
        //Reverses string from user input
        public static string ReverseString(string userString)
        {
            //Stores userString in an array called userArray
            char[] userArray = userString.ToCharArray();
            //Class that reverses all characters in array
            Array.Reverse(userArray);
            //Returns the array as a string to display as a string and not an array
            return new string(userArray);
        }
        //Count how many vowels from user input
        public static string CountVowels(string userString)
        {
            //Intialize variable to hold value
            int vowels = 0;
            //Lower all characters in string for case structure to count properly
            userString = userString.ToLower();
            //Checks each character in string for vowels
            foreach (char c in userString)
            {
                switch (c)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowels = vowels + 1; //Any vowels found will be added to variable and stored until all characters are checked
                        break;
                }
            }
            //Outputs how many vowels found in user's string
            Console.WriteLine($"The number of vowels in this string is: {vowels}");
            return userString;
        }
        //Checks if string is a palindrome
        public static string isPalindrome(string userString)
        {
            //Creates a new variable called "newUserString" which lowers all characters and stores in an array
            string newUserString = new string (userString.ToLower().ToCharArray());
            //Intialize variables to check each characters with variables: left, right, and flagPalindrome
            int left = 0; //Starting variable for check
            int right = userString.Length - 1; //Starting variable for check
            bool flagPalindrome = true; //Stays true unless proven wrong by if statement
            while (left < right) 
            { 
                //Characters are each checked to see if each side matchs; if not then flag variable "flagPalindrome" becomes false
                if (newUserString[left] != newUserString[right])
                {
                    flagPalindrome = false;
                }
                left++; //Increases left variable to next character until they meet in middle
                right--; //Decreases right variable to next character until they meet in middle
            }
            //True statement if string is a palindrome
            if (flagPalindrome)
            {
                //Prints out string is a palindrome
                Console.WriteLine($"The word {userString} IS a palindrome.");
            }
            //False statement if string is not a palindrome
            else
            {
                //Prints out string is not a palindrome
                Console.WriteLine($"The word {userString} is NOT a palindrome.");
            }
            return userString;
        }
    }
}
