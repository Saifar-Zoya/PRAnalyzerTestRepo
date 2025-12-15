// ========================================
// FILE 1: Utils.cs
// Tests: CS, IDE, SA
// ========================================
public class Utils
{
    // Existing method
    public void DoSomething()
    {
        int x; // unused variable → CS0168 or IDE0059
    }

    // Unused private method
    private void UnusedMethod() { } // triggers warning: method never used

    // New method with unused parameters
    public void ProcessData(string input, int count)
    {
        int localVar; // unused variable
        // input and count are not used → triggers CS0168/CS0219
    }

    // Method with potential null reference
    public void PrintMessage(string? message)
    {
        Console.WriteLine(message.Length); // possible null reference warning
    }

    // Method with bad naming (camelCase instead of PascalCase)
    public void badNamingMethod()
    {
        int y; // unused variable
    }
}

// StyleCop example: naming rule (should trigger SA1300 / SA1310)
public class stylecopClass
{
    public int my_field = 5; // Should be PascalCase or private → SA1300/SA1307
}
