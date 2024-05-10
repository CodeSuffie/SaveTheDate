namespace SaveTheDate.Models;

public class Person
{
    public string? Name { get; init; }

    public static Person operator +(Person a, Person b)
    {
        if ((a.Name == "Sophie" && b.Name == "Micky") || (a.Name == "Micky" && b.Name == "Sophie"))
        {
            return new Love();
        }

        return new Person();
    }

    public bool AmAvailableOn(DateTime date)
    {
        return true;
    }
}

public class Love : Person
{
    
}