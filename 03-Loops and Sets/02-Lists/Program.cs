
List<string> colors = new List<string>();

colors.Add("black");
colors.Add("Red");
colors.Add("Green");
colors.Add("White");

Console.WriteLine(colors[^1]);
Console.WriteLine(colors[colors.Count - 1]);

foreach(var color in colors)
{
    Console.WriteLine(color);
}

// List<T> - generic 

string data = "Corey,Smith,Karim";
var lastNames = data.Split(",").ToList(); 
lastNames.Add("Jonas");