/*
 * Integer Option = 0
Do
Display Menu Options
Enter Option
Switch(Option)
Case 1: Display Syntax Definition,
Case 2: Display Syntax Rules.
Case 3: Display Small Scale App Dev Definition,
Case 4: Display Document Design Definition,
Case 5: Display Coding Techniques Definition,
Case 6: Display Coding Standards Definition
Case 7: Quit
Default: Display error
While (option not equal to 7)



            Console.WriteLine("Select a definition/option from the following:" +
           "\n 1 - Syntax" +
           "\n 2 - Syntax Rules" +
           "\n 3 - Small Scale App Dev" +
           "\n 4 - Document Design Specification" +
           "\n 5 - Coding Techniques" +
           "\n 6 - Coding Standards" +
           "\n 7 - Exit Application");
 */
using System;

try
{
    // make sure the int option dosen't have anything assigned to it before the do block, in the psuedocode this is set as 0
    int option;
    do
    {
        // Display the menu
        Console.WriteLine("Select a definition/option from the following:" +
           "\n 1 - Syntax" +
           "\n 2 - Syntax Rules" +
           "\n 3 - Small Scale App Dev" +
           "\n 4 - Document Design Specification" +
           "\n 5 - Coding Techniques" +
           "\n 6 - Coding Standards" +
           "\n 7 - Exit Application");

        // now assign the int option with a console.Readline that parses any integers typed in
        option = int.Parse(Console.ReadLine());

        // so now any number from 1-7 that gets typed in will go into the switch case statement
        switch (option)
            {
                case 1:
                    Console.WriteLine("Syntax is the set of rules that define what the various combinations of symbols mean. This tells the computer how to read the code. Syntax refers to a concept in writing code dealing with a very specific set of words and a very specific order to those words when we give the computer instructions.");
                    break;
                case 2:
                    Console.WriteLine("Syntax rules are the guidelines that govern the structure and formatting of code in a programming language. They define the order and restrictions for words, punctuation, and symbols in a program. Following syntax rules helps ensure that code is written correctly and can be executed by a computer without errors.");
                    break;
                case 3:
                    Console.WriteLine("Small-scale application development is the process of creating a software application on a small scale. It involves a hybrid spiral methodology that combines aspects of both the waterfall and iterative models. The analysis phase is the waterfall portion of this hybrid, and it's where a software requirements document (SRD) is created. The SRD details the requirements for the application in a number of ways, including textual use-case sequences, a top-level state description, and a hardware interface list.");
                    break;
                case 4:
                    Console.WriteLine("Design Specifications describe how a system performs the requirements outlined in the Functional Requirements. Depending on the system, this can include instructions on testing specific requirements, configuration settings, or review of functions or code.");
                    break;
                case 5:
                    Console.WriteLine("Coding Technique refers to a method used to encode data by taking into account the structure and patterns within the data. It involves building a list of commonly occurring patterns and encoding them by transmitting their index in the list.");
                    break;
                case 6:
                    Console.WriteLine("Coding standards, also known as coding guidelines or programming style guides, are rules and conventions that developers follow when writing code. These rules define the code characteristics necessary to maintain a uniform codebase and facilitate collaboration among developers.");
                    break;
                case 7:
                // case 7 exits the program so we can just do return; instead of break to do this
                return;
                default:
                    Console.WriteLine("Error");
                    break;
            }
    }
    // so the while block will do the statements above as long as option is not equal to 7 which means exiting
    while (option != 7);
} catch (Exception ex) 
{
    // if any exceptions occur put them into the catch block and print it out into the console
    Console.WriteLine(ex.Message);
}
