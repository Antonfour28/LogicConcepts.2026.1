
using Share;

var answer = string.Empty;
var options = new List<string>() { "si", "no" };

do
{

    var number = ConsoleExtentions.GetIntFromConsole(" Ingrese el numero Entero diferente de cero. ");   

    if (number == 0) 
    {
        continue;
    }

        if (number  % 2 == 0)
        {
            Console.WriteLine($"El numero {number}, es par. ");
        }
        else
        {
            Console.WriteLine($"El numero {number}, es impar. ");
        }

        do 
        {
            answer = ConsoleExtentions.GetValidOptions("¿Desea ingresar otro numero? (si/no) ", options);
        } while (!options.Any(X => X.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("si", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over. ");


