Console.WriteLine(@"
   ___   _   _    ___ _   _ _      _   ___   ___  ___    _   
  / __| /_\ | |  / __| | | | |    /_\ |   \ / _ \| _ \  /_\  
 | (__ / _ \| |_| (__| |_| | |__ / _ \| |) | (_) |   / / _ \ 
  \___/_/ \_\____\___|\___/|____/_/ \_\___/ \___/|_|_\/_/ \_\
");
bool flag;
do
{
    Console.WriteLine("\nIngrese la operacion que desea realizar: \n\t 1) Suma \n\t 2)Resta \n\t 3)Multiplicacion \n\t 4)Dividir\n\t");

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