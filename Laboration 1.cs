using System;
using System.Collections.Generic; 

class Program
{
    static void Main(string[] args)
    {
        // Create a string called random 
        //string random to enter "abc12321def45654ghi789987jkl10201mno303pqr2020stu505tuv";

        //as the user to enter a string
        Console.WriteLine("Please, enter a string:\n");
        string random = Console.ReadLine();
        Console.WriteLine(); //add a new line after the entered string 

        // Store the number(s) temporarily
        string currentNumber = "";
        var numbers = new List<string>(); // List to store matching numbers

        // Check every char in the string in order to see if it is a number or not
        foreach (char c in random)
        {
            if (char.IsDigit(c))
            {
                //if char is a digit then it gets added to the list 
                currentNumber += c;
            }
            else
            {
                // Check if the criteria are met
                if (currentNumber.Length > 0 && currentNumber[0] == currentNumber[currentNumber.Length - 1])
                {
                    // Add the number to the list if it starts and ends with the same digit
                    numbers.Add(currentNumber);
                }

                // Prepare the currentNumber for the next round
                currentNumber = "";
            }
        }

        // Check for the last part of the string
        if (currentNumber.Length > 0 && currentNumber[0] == currentNumber[currentNumber.Length - 1])
        {
            numbers.Add(currentNumber); // Add the last number if it meets the criteria
        }

        // Print and highlight each matching number
        foreach (var number in numbers)
        {
            HighlightPart(random, number);
        }
    }

    //new method to distinguish the main task to the more graphic one 
    static void HighlightPart(string random, string part)
    {
        int startIndex = random.IndexOf(part);
        //the code continues only if the number is found
        if (startIndex != -1)
        {
            Console.Write(random.Substring(0, startIndex));

            // Highlight the matching part 
            Console.ForegroundColor = ConsoleColor.Blue;
            //print only the numbers which have a color applied 
            Console.Write(part);
            //color goes back to default
            Console.ResetColor();

            //print the final results 
            Console.WriteLine(random.Substring(startIndex + part.Length));
        }
    }
}
