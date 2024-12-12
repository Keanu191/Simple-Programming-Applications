/* This was created by Keanu Farro: 12/12/2024
 * Program name: Flowrate
 * This application checks the value of the flowrate
 * and determines what to print out to the user depending on how high or low
 * the integer value of the flowrate is
*/

// print a message that says to press enter to start the flowrate console program
Console.WriteLine("Press Enter to run the program!");

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

// here we want to do a while loop to ensure that after a integer is entered into the console the
// application dosen't close as this will be annoying to open/close the app multiple times to make this work

// so as we can see we can just do while programRunning is set to true which assumes that the enter button has been clicked then do the functions
while (programRunning == true)
{
    Console.WriteLine("Enter flowrate: ");

    // declare flowrate as an integer
    var flowrateInput = Console.ReadLine();

    // we will put the if/else statements in a try catch block as if we get exceptions from the users fault for entering non int values
    // we can just print out the exceptions and move on rather than having to open the app again!
    try
    {
        // if the flowRate is less than 75 output message that its low alongside the current flowrate
        if (int.Parse(flowrateInput) < 75)
        {
            Console.WriteLine("Warning Flow Rate Low, current Flow Rate: " + flowrateInput);
        }
        // else if the flow rate is more than 120 output message that its high alongside the current flowrate
        else if (int.Parse(flowrateInput) > 120)
        {
            Console.WriteLine("Warning Flow Rate High, current Flow Rate: " + flowrateInput);
        }
        // else if the flow rate isn't higher than 120 or lower than 75 then display a message that the flowrate is fine with the current flow rate
        else
        {
            Console.WriteLine("FLOW Rate OK, current Flow Rate: " + flowrateInput);
        }

        Console.ReadLine();
    } catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
}

