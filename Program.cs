// Ejercicio 3.  Ingrese al Branch CalculadoraV2 para implementar las mejoras en la 
// calculadora.. Solicite al usuario un número y muestre por pantalla:  
// ●  El valor absoluto de un número  
// ●  El cuadrado 
// ●  La raíz cuadrada  
// ●  El seno 
// ●  El Coseno  
// ●  La parte entera de un tipo float.  


Console.WriteLine(@"
   ____    _    _     ____ _   _ _        _    ____   ___  ____      _     __     ______  
  / ___|  / \  | |   / ___| | | | |      / \  |  _ \ / _ \|  _ \    / \    \ \   / /___ \ 
 | |     / _ \ | |  | |   | | | | |     / _ \ | | | | | | | |_) |  / _ \    \ \ / /  __) |
 | |___ / ___ \| |__| |___| |_| | |___ / ___ \| |_| | |_| |  _ <  / ___ \    \ V /  / __/ 
  \____/_/   \_\_____\____|\___/|_____/_/   \_\____/ \___/|_| \_\/_/   \_\    \_/  |_____|
                                                                                          
");
bool flag;
do
{
    Console.WriteLine("\nIngrese la operacion que desea realizar:\n\t 1)Valor Absoluto\n\t 2)Cuadrado\n\t 3)Raiz Cuadrada\n\t 4)Seno\n\t 5)Coseno\n\t 6) Parte entera de un tipo Float");

    if (int.TryParse(Console.ReadLine(), out int operacion))
    {
        flag = false;

        Console.WriteLine("Ingrese dos numeros:");

        bool boolA = int.TryParse(Console.ReadLine(), out int a);
        bool boolB = int.TryParse(Console.ReadLine(), out int b);

        if (boolA && boolB)
        {
            switch (operacion)
            {
                case 1:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("");
                    break;
                case 3:

                    Console.WriteLine("");
                    break;
                case 4:
                    
                    Console.WriteLine("");
                    break;
            }
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