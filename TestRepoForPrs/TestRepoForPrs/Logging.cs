using System;

public class Logging
{
    public void Log(string message)
    {
        string? nullableMessage = null;
        Console.WriteLine(nullableMessage.Length); // potential null reference warning
    }
}
