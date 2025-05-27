bool esNumero;
do
{
    Console.WriteLine("Ingrese una cadena de numeros para ivertirlos:");
    string texto = Console.ReadLine();

    int invertido = 0, aux = 0;

    esNumero = int.TryParse(texto, out int numero);

    if (esNumero)
    {
        while (numero > 0)
        {
            aux = numero % 10;
            invertido = invertido * 10 + aux;
            numero /= 10;
        }
        Console.WriteLine("El numero invertido es: " + invertido);
    }else
    {
        Console.WriteLine("La cadena ingresada no es un numero");
    }
    
} while (esNumero == false);