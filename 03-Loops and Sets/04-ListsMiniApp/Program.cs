List<string> rosterClassStudenys = new List<string>();
bool addMoreStudents = true;


do
{
    Console.WriteLine("Add a Student name to the Roster Class :");

    var studentName = Console.ReadLine();
    rosterClassStudenys.Add(studentName);

    Console.Write("Do you want to Add More Students to The Class ? Y or N : ");
    var answer = Console.ReadLine();
    
    if (answer.ToUpper() == "Y")
    {
        addMoreStudents = true;
    }
    else
        addMoreStudents = false;
} while (addMoreStudents);