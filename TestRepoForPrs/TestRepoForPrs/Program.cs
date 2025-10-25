using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello PRAnalyzer!");

        int unusedVariable; // triggers CS0168 warning

        Utils utils = new Utils();
        utils.DoSomething();

        Database db = new Database();
        db.GetUser("admin");

        Logging logger = new Logging();
        logger.Log(null); // triggers nullability warning
    }
}
