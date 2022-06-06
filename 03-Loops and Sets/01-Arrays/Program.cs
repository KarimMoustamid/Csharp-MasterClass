string[] firstNames = new string[5];

firstNames[0] = "Tim";
firstNames[1] = "Karim";
firstNames[2] = "Lora";
firstNames[3] = "Jonas";
firstNames[4] = "Stephen";

for (var i = 0; i < firstNames.Length; i++)
{
    Console.WriteLine(firstNames[i]);
}

string data = "Tim,Sue,Bob,Jane,Franck";

string[] firstNamesData = data.Split(",");

for (var i = 0; i < firstNamesData.Length; i++)
{
    Console.WriteLine(firstNamesData[i]);
}
