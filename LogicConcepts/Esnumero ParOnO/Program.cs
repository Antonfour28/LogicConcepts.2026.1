
var numberString = string.Empty;

do
{
    Console.WriteLine("Ingrese un número o la plabra Salir para salir: ");
    numberString = Console.ReadLine();
    if (numberString!.ToLower() == "salir")
    {
        continue;
    }


    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine("El numero es par. ");
        }
        else
        {
            Console.WriteLine("El numero es impar. ");
        }
    }
    else
    {
        Console.WriteLine("El valor ingresado, no es un número válido. Intente nuevamente.");
    }
} while (numberString!.ToLower() != "salir");
Console.WriteLine("Game Over. ");