using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {

        //ask the user to enter a string
        //string random = "29535123p48723487597645723645";
        Console.WriteLine("Please, enter a string:\n");
        string random = Console.ReadLine();
        Console.WriteLine(); //add a new line after the entered string

        char curr, start, next;
        int idxstart, idxnext;
        bool found;
        string substr;

        //go through each character of the string
        for (int i = 0; i < random.Length; i++)
        {
            curr = random[i];

            //find the potential start of the substring (which starts and ends with a digit)
            if (char.IsDigit(curr) && i < random.Length - 1)
            {
                idxstart = i;
                start = curr;
                substr = start.ToString();
                idxnext = i + 1;
                next = random[idxnext];
                found = false;

                //check if next char is a digit
                if (char.IsDigit(next))
                {
                    if (start == next)
                    {
                        //handle special case (same digit twice on a row)
                        found = true;
                        substr += next;
                    }
                    else
                    {
                        //go through the string looking for a matching digit until the string ends or the next char is not a digit
                        substr += next;
                        idxnext += 1;
                        while(!found && idxnext < random.Length && char.IsDigit(random[idxnext])){
                            next = random[idxnext];
                            if (start == next)
                            {
                                found = true;
                                substr += next;
                            }
                            else
                            {
                                substr += next;
                                idxnext++;
                            }
                        }
                    }
                }
                //when last digit is found the substring gets printed 
                if (found)
                {
                    //numbers.Add(substr);
                    HighlightPart(random, substr, idxstart);
                }
            }
        }
    }

    //new method to distinguish the main task to the more graphic one
    static void HighlightPart(string random, string part, int startIndex)
    {
        //the code continues only if the number is found
        if (startIndex != -1)
        {
            Console.Write(random.Substring(0, startIndex));

            //highlight the matching part
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
