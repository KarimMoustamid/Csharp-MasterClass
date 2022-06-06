bool isValidAge;
int age;


// Runs the Code at least one time .    
do
{
    Console.WriteLine("What is your Age : ");
    string ageText = Console.ReadLine();

    isValidAge = int.TryParse(ageText, out age);
    if (!isValidAge)
    {
        Console.WriteLine("That was an invalid age.");
        // return;
    }
} while (isValidAge == false);

Console.WriteLine($"Your age id {age}.");

// while (true)
{
// Runs the Code 0 or more times     
}