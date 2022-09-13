namespace TestDateFormat;

/// <summary>
/// El programa principal.
/// </summary>
public static class Program
{
    /// <summary>
    /// Punto de entrada al programa principal.
    /// </summary>
    public static void Main()
    {
        string testDate = "15/11/2003";
        Console.WriteLine($"{testDate} se convierte en {DateFormatter.ChangeFormat(testDate)}");
    }
}