string? readResult;
bool validEntry = false;
int numericValue = 0;
bool validNumber = false;
Console.WriteLine("Enter a Interger Sequence containing three to five Numbers");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        do
        {
            if (readResult.Length >= 3 && readResult.Length <=5)
            {
                validNumber = int.TryParse(readResult, out numericValue);
                if (validNumber== false)
                {
                    Console.WriteLine("please enter a Number");
                    readResult = Console.ReadLine();
                }
                else
                {
                    validEntry = true;
                }
            }
            else
            {
                Console.WriteLine("Your input has to be an Integer of three to five Numbers");
                readResult = Console.ReadLine();
            }
        }while ( (validNumber== false));
    }
} while (validEntry == false);

string? readInput;
bool validInput2= false;

Console.WriteLine("Hello, please Enter your Role e.g. User");
do
{
    readInput = Console.ReadLine();
    if (readInput != null)
    {
        if (readInput.Trim().ToLower() == "user")
        {
            validInput2 = true;
        }
        else if (readInput.Trim().ToLower() == "administrator")
        {
            validInput2 = true;
        }
        else if (readInput.Trim().ToLower() == "manager")
        {
            validInput2 = true;
        }
        else
        {
            Console.WriteLine($"{readInput} is not an accepted Input");
            validInput2 = false;
        }
    }
    else
    {
        Console.WriteLine("That was an invalid input");
    }
}while(validInput2==false);
Console.WriteLine($"Your Input ({readInput}) has been accepted");

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad.", "I like all three of the menu choices." };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine($"{mySentence},{myString}");
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
