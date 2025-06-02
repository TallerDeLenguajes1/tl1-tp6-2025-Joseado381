string texto = "";
Console.WriteLine("Ingrese un texto con ',': \n");
texto = Console.ReadLine();
int longitud = texto.Length;
Console.WriteLine($"La longitud de su texto es: {longitud} \n");
Console.WriteLine($"Los caracteres recorridos por el foreach son: \n");
foreach (char c in texto)
{
    Console.WriteLine($"{c} \n");
}
Console.WriteLine("Ingrese una palabra a buscar en el texto: ");
string ocurrencia = Console.ReadLine();
if (texto.Contains(ocurrencia))
{
    Console.WriteLine($"La palabra está en la frase: {texto}");
}
else
{
    Console.WriteLine($"La palabra NO está en la frase: {texto}");
}
string mayuscula = texto.ToUpper();
Console.WriteLine($"El texto en mayúsculas es: {mayuscula}");
string minuscula = texto.ToLower();
Console.WriteLine($"El texto en minúsculas es: {minuscula}");
string separador = ",";
Console.WriteLine($"El texto separado por '{separador}' es: ");
string[] partes = texto.Split(separador);
foreach (string parte in partes)
{
    Console.WriteLine(parte);
} 

string texto2;
Console.WriteLine("Ingrese un 2do texto: ");
texto2 = Console.ReadLine();
string NuevoTexto = texto + " " + texto2;
Console.WriteLine($"El texto concatenado es: {NuevoTexto}");
Console.WriteLine($"Los caracteres recorridos por el foreach son: \n");
foreach (char c in texto)
{
    Console.WriteLine($"{c} \n");
}

Console.WriteLine("Ingrese dos numeros: ");
string numero = Console.ReadLine();
bool boolA = int.TryParse(numero, out int num1);
numero = Console.ReadLine();
bool boolB = int.TryParse(numero, out int num2);
Console.WriteLine($"La suma de los numeros {num1} y {num2} es: {num1 + num2}");

Console.WriteLine("Ingrese una ecuación simple (ejemplo: 582+2):");
string ecuacion = Console.ReadLine();
double resultado = 0;
char operador = ' ';
if (ecuacion.Contains("+")) operador = '+';
else if (ecuacion.Contains("-")) operador = '-';
else if (ecuacion.Contains("*")) operador = '*';
else if (ecuacion.Contains("/")) operador = '/';
else
{
    Console.WriteLine("Ecuación no válida.");
    return;
}

switch (operador)
{
    case '+':
        string[] sumaPartes = ecuacion.Split('+');
        if (sumaPartes.Length == 2)
        {
            if (double.TryParse(sumaPartes[0], out double a) && double.TryParse(sumaPartes[1], out double b))
            {
                resultado = a + b;
                Console.WriteLine($"El resultado es: {resultado}");
            }
            else
            {
                Console.WriteLine("Los operandos no son válidos.");
            }
        }
        else
        {
            Console.WriteLine("Formato de suma incorrecto.");
        }
        break;
    case '-':
        string[] restaPartes = ecuacion.Split('-');
        if (restaPartes.Length == 2)
        {
            if (double.TryParse(restaPartes[0], out double a) && double.TryParse(restaPartes[1], out double b))
            {
                resultado = a - b;
                Console.WriteLine($"El resultado es: {resultado}");
            }
            else
            {
                Console.WriteLine("Los operandos no son válidos.");
            }
        }
        else
        {
            Console.WriteLine("Formato de resta incorrecto.");
        }
        break;
    case '*':
        string[] multiplicacionPartes = ecuacion.Split('*');
        if (multiplicacionPartes.Length == 2)
        {
            if (double.TryParse(multiplicacionPartes[0], out double a) && double.TryParse(multiplicacionPartes[1], out double b))
            {
                resultado = a * b;
                Console.WriteLine($"El resultado es: {resultado}");
            }
            else
            {
                Console.WriteLine("Los operandos no son válidos.");
            }
        }
        else
        {
            Console.WriteLine("Formato de multiplicación incorrecto.");
        }
        break;
    case '/':
        string[] divisionPartes = ecuacion.Split('/');
        if (divisionPartes.Length == 2)
        {
            if (double.TryParse(divisionPartes[0], out double a) && double.TryParse(divisionPartes[1], out double b))
            {
                if (b != 0)
                {
                    resultado = a / b;
                    Console.WriteLine($"El resultado es: {resultado}");
                }
                else
                {
                    Console.WriteLine("No se puede dividir por cero.");
                }
            }
            else
            {
                Console.WriteLine("Los operandos no son válidos.");
            }
        }
        else
        {
            Console.WriteLine("Formato de división incorrecto.");
        }
        break;

    default:
        Console.WriteLine("Operador no reconocido.");
        return;
}