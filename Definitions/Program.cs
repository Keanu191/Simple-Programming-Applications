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

 */
using System;

bool displayMenu = false;

var programInput = Console.ReadLine();

if (programInput != null)
{
    displayMenu = true;
}

if (displayMenu)
{
    try
    {
        var option = int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("Select a definition/option from the following:" +
           "\n 1 - Syntax" +
           "\n 2 - Syntax Rules" +
           "\n 3 - Small Scale App Dev" +
           "\n 4 - Document Design Specification" +
           "\n 5 - Coding Techniques" +
           "\n 6 - Coding Standards" +
           "\n 7 - Exit Application");


            switch (option)
            {
                case 1:
                    Console.WriteLine("Syntax");
                    break;
                case 2:
                    Console.WriteLine("Syntax Rules");
                    break;
                case 3:
                    Console.WriteLine("Small Scale App Dev");
                    break;
                case 4:
                    Console.WriteLine("Document Design Specification");
                    break;
                case 5:
                    Console.WriteLine("Coding Techniques");
                    break;
                case 6:
                    Console.WriteLine("Coding Standards");
                    break;
                case 7:
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

        } while (option != 7);
    }
    catch (Exception ex)
    {
        Console.Write(ex.ToString());
    }

}

