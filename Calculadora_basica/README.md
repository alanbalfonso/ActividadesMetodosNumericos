# Calculadora Básica

Este programa de consola en C# permite realizar operaciones aritméticas elementales entre dos números reales proporcionados por el usuario: suma, resta, multiplicación y división. Además, incluye control de flujo interactivo para repetir operaciones y validación de restricciones aritméticas como la división entre cero.

## Formula

Las operaciones fundamentales ejecutadas por el programa se definen formalmente de la siguiente manera:

* **Suma:**
$$
R = a + b
$$

* **Resta:**
$$
R = a - b
$$

* **Multiplicación:**
$$
R = a \times b
$$

* **División:**
$$
R = \frac{a}{b}, \quad \text{con } b \neq 0
$$

## Aplicación

El programa solicita inicialmente el nombre del usuario y dos valores numéricos reales ($ a $ y $ b $). Posteriormente, solicita la selección de la operación deseada mediante su letra inicial: `s` (suma), `r` (resta), `m` (multiplicación) o `d` (división).

Para la operación de división, se evalúa previamente la condición de indeterminación matemática:

$$
b = 0 \implies \text{Indeterminación / Error aritmético}
$$

Por lo que, en C#, la validación para evitar una división indeterminada se expresa como:

```csharp
if (numero2 == 0)
{
    Console.WriteLine("No se puede dividir entre cero. Inicializando de nuevo el programa... \n");
    break;
}
```

Donde:
* `numero1`: Representa el numerador o primer operando $ a $.
* `numero2`: Representa el denominador o segundo operando $ b $.
* `resultado`: Almacena el valor resultante $ R $ de la operación seleccionada.

El programa se mantiene en ejecución continua dentro de una estructura iterativa `do-while` controlada por la variable booleana `repetirPrograma`, la cual se actualiza al consultar al usuario si desea continuar (`s`/`n`).
