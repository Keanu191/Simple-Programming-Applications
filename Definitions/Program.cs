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
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                case 3:
                    Console.WriteLine("case 3");
                    break;
                case 4:
                    Console.WriteLine("case 4");
                    break;
                case 5:
                    Console.WriteLine("case 5");
                    break;
                case 6:
                    Console.WriteLine("case 6");
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
