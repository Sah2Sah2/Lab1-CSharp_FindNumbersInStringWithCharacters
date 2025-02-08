# Console Application - 1st Assignment for Programming with C#

## Overview

This repository contains a **console application** that is part of my school assignment for the course *Programming with C#*. This is the first course in the *.NET Cloud Developer* program at *IT Högskola*.
The task is to create a program that processes a string and identifies numeric substrings that begin and end with the same digit.
The program then highlights these substrings and sums up the total of all identified numbers.
This application was developed as part of my coursework and is intended to showcase my understanding of string manipulation and console applications.

## Assignment Instructions
*Disclaimer: The description of the assignment has been translated from the PDF provided by the school.*
### Task Description 
Create a console application that takes a text string as an argument to the Main method or prompts the user to input a string in the console.
The program must search the string for all substrings that are numbers starting and ending with the same digit, without any other non-numeric characters (such as letters or extra digits) appearing in between.
For example:
- 3463 is a valid number;
- 34363 is not valid because there is an additional 3 between the starting and ending digit;
- Strings containing letters, e.g., 95a9, are also invalid.
For each valid substring, the program should print the entire string with the valid substring highlighted in a different color.

### *Example Output*
For input "29535123p48723487597645723645", the output should look something like this (with the valid substrings highlighted in a different color):
      29535123p48723487597645723645
      29535123p48723487597645723645
      29535123p48723487597645723645
      29535123p48723487597645723645
      (...). 
After identifying and highlighting the valid substrings, the program should then sum all the valid numbers and display the total. An empty line should separate the total from the output above.

### *Example Total Output*
For the same input "29535123p48723487597645723645", the total output should be:
Total = 5836428677242

### **Requirements**
- The program must work correctly for any input string and highlight valid numeric substrings;
- The string can be entered manually by the user or passed as an argument to the Main method;
- The program should display the total sum of all valid numeric substrings.

## Project Details 
### Technologies Used
- C# (Console Application).

### Reflection
The first assignment for this course presented several challenges, especially when it came to coming up with a working solution that met all the requirements. 
I encountered difficulties while implementing the logic for identifying numeric substrings and highlighting them correctly. 
After some trial and error, I made several changes to my approach to meet the specifications more efficiently.
As you can see in the repository, there are two versions of the code: the initial version and the final one. 
The final version reflects the changes I made to improve functionality and ensure the program works as intended.
This process has helped me better understand string manipulation and refine my problem-solving techniques.

### How to Run
1) Clone the repository;
2) Open the solution in Visual Studio (or your preferred C# IDE);
3) Run the console application;
4) Input a string or provide it as an argument;
5) View the output, with valid numeric substrings highlighted and the total sum displayed.
