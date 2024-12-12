/* This was created by Keanu Farro: 12/12/2024
 * Program name: UV Index
 * This application checks the value of the UV index
 * and determines what to print out to the user from a switch case statement depending
 * on the UV index level, this will also display the colour of the UV index in the console by changing
 * the colour of the output text in the console
*/

// print a message that says to press enter to start the flowrate console program
Console.WriteLine("Press Enter to run the program! If at any time you want to exit the program type in '0' ");

// on default set the programRunning bool to false
bool programRunning = false;

/* create a var to set the programInput to console.ReadLine() so whatever button gets clicked 
 * after the console.Writeline will be read by the compiler essentially
 */
var programInput = Console.ReadLine();

// so to ensure that the enter button or any other button gets pressed in the console to set the
// programRunning bool to true, we can do if the var programInput is not equal to null then set programRunning to true
// 
if (programInput != null)
{
    programRunning = true;
}

while (programRunning == true)
{
    try
    {
        // output message to let the user know to input a UV index into the console
        Console.Write("Enter a UV Index: ");

        // declare UV index variable as a var then parse whatever is entered into the console as an integer,
        // so according to the psuedocode, reading the UVIndex from the keyboard
        var uvIndex = int.Parse(Console.ReadLine());

        // create a switch case statement with the uv index variable as the parameter for the statement
        switch (uvIndex)
        {
            case 1 or 2:
                Console.WriteLine("Green: Low");
                break;
            case 3 or 4 or 5:
                Console.WriteLine("Yellow: Moderate");
                break;
            case 6 or 7:
                Console.WriteLine("Orange: High");
                break;
            case 8 or 9 or 10:
                Console.WriteLine("Red: Very High");
                break;
            case >= 11:
                Console.WriteLine("Purple: Extreme");
                break;
            case 0:
                programRunning = false;
                return;
            default:
                Console.WriteLine("Error");
                break;

        }
    }
    catch (Exception ex)
    {
        // display any exceptions if they do occur in the console
        Console.WriteLine($"{ex.Message}");
    }
}
