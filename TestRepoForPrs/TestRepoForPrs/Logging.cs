// ========================================
// FILE 2: Logging.cs
// Tests: CS, CA Security
// ========================================
using System;
using System.IO;

public class Logging
{
    public void Log(string message)
    {
        string? nullableMessage = null;
        Console.WriteLine(nullableMessage.Length);
        // Null dereference → CS8602 (nullable warning)
    }

    public void ReadFile()
    {
        File.ReadAllText("C:\\temp\\file.txt");
        // CA1303 (Do not pass literals) or CA2000, depending on analyzers installed
    }
}
