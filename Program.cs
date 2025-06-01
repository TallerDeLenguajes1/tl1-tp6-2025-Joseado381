
Console.WriteLine(@"
  ______     ___       __        ______  __    __   __          ___       _______   ______   .______          ___   ____    ____  ___      __  
 /      |   /   \     |  |      /      ||  |  |  | |  |        /   \     |       \ /  __  \  |   _  \        /   \  \   \  /   / |__ \    /_ | 
|  ,----'  /  ^  \    |  |     |  ,----'|  |  |  | |  |       /  ^  \    |  .--.  |  |  |  | |  |_)  |      /  ^  \  \   \/   /     ) |    | | 
|  |      /  /_\  \   |  |     |  |     |  |  |  | |  |      /  /_\  \   |  |  |  |  |  |  | |      /      /  /_\  \  \      /     / /     | | 
|  `----./  _____  \  |  `----.|  `----.|  `--'  | |  `----./  _____  \  |  '--'  |  `--'  | |  |\  \----./  _____  \  \    /     / /_   __| | 
 \______/__/     \__\ |_______| \______| \______/  |_______/__/     \__\ |_______/ \______/  | _| `._____/__/     \__\  \__/     |____| (__)_| 
                                                                                                                                               
");
int a = 0, b = 0;
double c = 0;
bool flag, boolA, boolB;
bool valido1 = false, valido2 = false;
do
{
    Console.WriteLine("\nIngrese la operacion que desea realizar:\n\t 1) Suma \n\t 2)Resta \n\t 3)Multiplicacion \n\t 4)Dividir\n\t 5)Valor Absoluto\n\t 6)Cuadrado\n\t 7)Raiz Cuadrada\n\t 8)Seno\n\t 9)Coseno\n\t 10) Parte entera de un tipo Float");

    if (int.TryParse(Console.ReadLine(), out int operacion) || operacion < 1 || operacion > 10)
    {
        flag = false;

        if (operacion < 6)
        {
            Console.WriteLine("Ingrese dos numeros:");

            boolA = int.TryParse(Console.ReadLine(), out a);
            boolB = int.TryParse(Console.ReadLine(), out b);
        }
        else
        {
            Console.WriteLine("Ingrese un numero:\n\t (Nota: Si ingresa un numero decimal, se tomara la parte entera del mismo)");

            boolA = double.TryParse(Console.ReadLine(), out c);
        }

        if (boolA)
        {
            switch (operacion)
            {
                case 1:
                    int resultadoSuma = a + b;
                    Console.WriteLine("El resultado de la suma: " + resultadoSuma);
                    break;
                case 2:
                    int resultadoResta = a - b;
                    Console.WriteLine("El resultado de la resta: " + resultadoResta);
                    break;
                case 3:
                    int resultadoProducto = a * b;
                    Console.WriteLine("El resultado del producto: " + resultadoProducto);
                    break;
                case 4:
                    int resultadoDivision = a / b;
                    int resultadoResto = a % b;
                    Console.WriteLine("El resultado de la division: " + resultadoDivision);
                    Console.WriteLine("El resto es: " + resultadoResto);
                    break;
                case 5:
                    Console.Write($"El valor absoluto de({c}) es {Math.Abs(c)}");
                    break;
                case 6:
                    Console.Write($"La Raiz cuadrada de({c}) es {Math.Pow(c, 2)}");
                    break;
                case 7:
                    Console.Write($"El cuadrado de({c}) es {Math.Sqrt(c)}");
                    break;
                case 8:
                    Console.Write($"El Seno de({c}) es {Math.Asin(c)}");
                    break;
                case 9:
                    Console.Write($"El Coseno de({c}) es {Math.Acos(c)}");
                    break;
                case 10:
                    Console.Write($"La Parte entera  de({c}) es {Math.Floor(c)}");
                    break;
            }
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese dos numeros para determinar el menor y el mayor \n");
            do
            {
                valido1 = int.TryParse(Console.ReadLine(), out int x);
                valido2 = int.TryParse(Console.ReadLine(), out int y);
                if (valido1 && valido2) {
                    Console.WriteLine($"El mayor es {Math.Max(x, y)} y el menor es {Math.Min(x, y)}");
                } else
                {
                    Console.WriteLine("Ingrese un dato valido \n");
                }
            } while (!valido1 || !valido2);

            Console.WriteLine("Desea Realizar otro calculo? Y/N");

            string repeticion = Console.ReadLine();
            if (repeticion == "Y" || repeticion == "y")
            {
                flag = true;
            }
        }
    }
    else
    {
        Console.WriteLine("Ingrese una opcion valida");
        flag = true;
    }

} while (flag);
