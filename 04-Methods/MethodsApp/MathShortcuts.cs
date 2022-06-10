namespace DefaultNamespace;

public class MathShortcuts
{
    public static double Add(double x , double y)
    {
       // Console.WriteLine($"the value of {x} + {y} is equal to : " , x + y );
       double output = x + y;
       return output ;
        
    }

    public static void AddAll(double[] values)
    {
        double results = 0;

        foreach (var value in values)
        {
            results = +value;
        }
        
        Console.WriteLine($"The total result is {results}");
    }
}