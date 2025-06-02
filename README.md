[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)


# Respuestas del Ejercicio 4

### a)  
`string` es un **tipo por referencia**, pero se comporta como si fuera **inmutable**, o sea, **no se puede cambiar directamente**. Cuando se modifica una cadena, se crea una nueva en memoria.

---

### b) Secuencias de escape del tipo `string`:

| Secuencia | Significado                     |
|-----------|---------------------------------|
| `\n`      | Salto de línea (Enter)          |
| `\t`      | Tabulación (tab)                |
| `\"`      | Comilla doble literal           |
| `\\`      | Barra invertida literal (`\`)   |
| `\r`      | Retorno de carro (no muy usado) |
| `\b`      | Retroceso (backspace)           |
| `\0`      | Carácter nulo (null)            |

---

### c) Significado de los caracteres `@`, `$` y `$@` en cadenas:

- `@` → Hace que ignores las **secuencias de escape**, y puedas escribir **múltiples líneas** sin usar `\n`.
- `$` → Permite insertar **variables dentro del texto** (interpolación).
- `$@` → Combina ambos: permite variables **e interpolación**, y también escribir el texto sin preocuparse por caracteres especiales.

---

## Expresiones Regulares

### ¿Qué son y cómo funcionan las expresiones regulares?

Las **expresiones regulares** (regex) son patrones que permiten buscar, validar, extraer o reemplazar texto que cumple con un formato específico. Funcionan definiendo reglas sobre cómo debe ser una cadena para que coincida con el patrón.

---

### ¿Funcionan únicamente en C#?

No, las expresiones regulares **no son exclusivas de C#**. Se utilizan en muchos lenguajes de programación y herramientas, como Python, Java, JavaScript, PHP, Perl, Ruby, grep, sed, entre otros.

---

### ¿En qué casos son útiles? (3 ejemplos)

1. **Validación de datos:** Verificar si un email, teléfono, etc., tiene el formato correcto.
2. **Búsqueda y extracción:** Encontrar y extraer información específica dentro de un texto (por ejemplo, fechas o números).
3. **Reemplazo de texto:** Modificar partes de un texto que cumplen con un patrón, como eliminar espacios extra o reemplazar palabras.

---

### ¿Cómo se usan en C#?

En C#, se utiliza la clase `System.Text.RegularExpressions.Regex`. Ejemplo:

```csharp
using System.Text.RegularExpressions;

// Validar email
string email = "usuario@ejemplo.com";
bool esValido = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

// Extraer números de un texto
string texto = "Mi número es 12345";
Match match = Regex.Match(texto, @"\d+");
if (match.Success)
{
    Console.WriteLine(match.Value); // 12345
}
```
