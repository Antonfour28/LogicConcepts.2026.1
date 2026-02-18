namespace Share;

public static class ConsoleExtentions
{
    public static int GetIntFromConsole(string masaage)

    {
        Console.Write(masaage);
        var numberString = Console.ReadLine();
        if (int.TryParse(numberString, out int numberInt)) ;

        {
            return numberInt;
        }

    }


    public static string? GetValidOptions(string message, List<string> options)
    {
        Console.Write(message);
        var answer = Console.ReadLine();
        if (options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)))
        {
            return answer;
        }
        return null;
    }
}
   