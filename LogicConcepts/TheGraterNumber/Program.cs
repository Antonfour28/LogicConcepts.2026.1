using Share;

internal class Program
{
    private static void Main(string[] args)
    {
        var answer = string.Empty;
        var options = new List<string>() { "si", "no" };

        do
        {

            Console.Write(" Ingrese 3 números diferentes. ");
            var a = (int)ConsoleExtentions.GetIntFromConsole("Ingrese el primer numero: ");
            var b = (int)ConsoleExtentions.GetIntFromConsole("Ingrese el segundo numero: ");
            var c = (int)ConsoleExtentions.GetIntFromConsole("Ingrese el tercer numero: ");

            if (a > b && a > c)
            {
                Console.WriteLine($"El numero {a}, es el mayor. ");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"El numero {b}, es el mayor. ");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine($"El numero {c}, es el mayor. ");
            }

            do
            {
                answer = ConsoleExtentions.GetValidOptions("¿Desea ingresar otro numero? (si/no) ", options);
            } while (!options.Any(X => X.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

        } while (answer!.Equals("si", StringComparison.CurrentCultureIgnoreCase));

        Console.WriteLine("Game Over. ");
    }
}