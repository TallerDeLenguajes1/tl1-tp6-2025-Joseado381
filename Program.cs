

Console.WriteLine(@"
   ____    _    _     ____ _   _ _        _    ____   ___  ____      _     __     ______  
  / ___|  / \  | |   / ___| | | | |      / \  |  _ \ / _ \|  _ \    / \    \ \   / /___ \ 
 | |     / _ \ | |  | |   | | | | |     / _ \ | | | | | | | |_) |  / _ \    \ \ / /  __) |
 | |___ / ___ \| |__| |___| |_| | |___ / ___ \| |_| | |_| |  _ <  / ___ \    \ V /  / __/ 
  \____/_/   \_\_____\____|\___/|_____/_/   \_\____/ \___/|_| \_\/_/   \_\    \_/  |_____|
                                                                                          
");
bool flag;
bool valido1 = false, valido2 = false;
do
{
    Console.WriteLine("\nIngrese la operacion que desea realizar:\n\t 1) Suma \n\t 2)Resta \n\t 3)Multiplicacion \n\t 4)Dividir\n\t 5)Valor Absoluto\n\t 6)Cuadrado\n\t 7)Raiz Cuadrada\n\t 8)Seno\n\t 9)Coseno\n\t 10) Parte entera de un tipo Float");

    if (int.TryParse(Console.ReadLine(), out int operacion) || operacion < 1 || operacion > 10)
    {
        flag = false;

        Console.WriteLine("Ingrese dos numeros:");

        bool boolA = int.TryParse(Console.ReadLine(), out int a);
        bool boolB = int.TryParse(Console.ReadLine(), out int b);
        
        Console.WriteLine("Ingrese un numero:\n\t (Nota: Si ingresa un numero decimal, se tomara la parte entera del mismo)");

        bool boolA = double.TryParse(Console.ReadLine(), out double a);

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
                    Console.Write($"El valor absoluto de({a}) es {Math.Abs(a)}");
                    break;
                case 6:
                    Console.Write($"La Raiz cuadrada de({a}) es {Math.Pow(a, 2)}");
                    break;
                case 7:
                    Console.Write($"El cuadrado de({a}) es {Math.Sqrt(a)}");
                    break;
                case 8:
                    Console.Write($"El Seno de({a}) es {Math.Asin(a)}");
                    break;
                case 9:
                    Console.Write($"El Coseno de({a}) es {Math.Acos(a)}");
                    break;
                case 10:
                    Console.Write($"La Parte entera  de({a}) es {Math.Floor(a)}");
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
