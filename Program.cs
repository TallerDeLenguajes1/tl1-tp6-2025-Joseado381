// Ejercicio 3.  Ingrese al Branch CalculadoraV2 para implementar las mejoras en la 
// calculadora.. Solicite al usuario un número y muestre por pantalla:  
// ●  El valor absoluto de un número  
// ●  El cuadrado 
// ●  La raíz cuadrada  
// ●  El seno 
// ●  El Coseno  
// ●  La parte entera de un tipo float.  
// Luego de esto solicite al usuario y determine
// ●  El maximo entre los dos numeros
// ●  El minimo entre los dos numeros


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
    Console.WriteLine("\nIngrese la operacion que desea realizar:\n\t 1)Valor Absoluto\n\t 2)Cuadrado\n\t 3)Raiz Cuadrada\n\t 4)Seno\n\t 5)Coseno\n\t 6) Parte entera de un tipo Float");

    if (int.TryParse(Console.ReadLine(), out int operacion) || operacion < 1 || operacion > 6)
    {
        flag = false;

        Console.WriteLine("Ingrese un numero:\n\t (Nota: Si ingresa un numero decimal, se tomara la parte entera del mismo)");

        bool boolA = double.TryParse(Console.ReadLine(), out double a);

        if (boolA)
        {
            switch (operacion)
            {
                case 1:
                    Console.Write($"El valor absoluto de({a}) es {Math.Abs(a)}");
                    break;
                case 2:
                    Console.Write($"La Raiz cuadrada de({a}) es {Math.Pow(a, 2)}");
                    break;
                case 3:
                    Console.Write($"El cuadrado de({a}) es {Math.Sqrt(a)}");
                    break;
                case 4:
                    Console.Write($"El Seno de({a}) es {Math.Asin(a)}");
                    break;
                case 5:
                    Console.Write($"El Coseno de({a}) es {Math.Acos(a)}");
                    break;
                case 6:
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
