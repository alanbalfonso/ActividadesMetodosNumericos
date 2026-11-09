# Metodo Newton Raphson

El método de Newton-Raphson nos permite encontrar la raíz de una función a partir de un límite inferior o aproximación inicial. Este número se conocerá más adelante como $ x_n $. Un nuevo número será generado en base a la primera derivada de la función entregada, y este se conocerá como $ x_{n+1} $, el cual pasadas las ejecuciones necesarias será el valor de la raíz que se encontró.

### Integrantes del equipo (Tarea 7):
* **Alan Bauza Alfonso** - [@alanbalfonso](https://github.com/alanbalfonso)
* **Ángel Andrés Hernández Lizardo** - [@AngelLizardo-Waggamer](https://github.com/AngelLizardo-Waggamer)
* **Luis Enrique Rodríguez Varela** - [@mrfuzball08](https://github.com/mrfuzball08)
* **Arturo Ardura Palacios** - [@ArturoArdura](https://github.com/ArturoArdura)
* **Dilan Rubén Salcedo Rosado** - [@Dylntsu](https://github.com/Dylntsu)
* **Víctor Manuel Quiñones Gil**

## Formula

$$
x_{n+1} = x_n - \left(\frac{f(x_n)}{f'(x_n)}\right)
$$

### Función implementada en el programa:
Dada la función cuadrática:
$$
f(x) = 2x^2 - 5x + 1
$$

Su primera derivada analítica es:
$$
f'(x) = 4x - 5
$$

---

## Aplicación

La manera de utilizar la fórmula es primero calcular la derivada de la función que se esté utilizando. Posteriormente, se evalúa la función original y la derivada usando el primer valor del intervalo que se nos dio para sustituir los valores en la fórmula. Finalmente, se evalúa la fórmula para obtener el siguiente número con el que ocupar la fórmula. Este proceso se repite hasta que la respuesta es lo suficientemente acertada.

Para calcular la exactitud se hace la siguiente operación:

$$
\epsilon_0 = |x_{n+1} - x_n|
$$

Se dice que la respuesta $$ x_{n+1} $$ es lo suficientemente acertada cuando:

$$
\epsilon_0 < \epsilon
$$

Por lo que, si se hace una función que repita la fórmula, la condición delimitadora para un ciclo `while` o `do-while` debería de ser:

$$
\epsilon_0 > \epsilon
$$

> **Nota:** Recordemos que $ \epsilon $ debe de ir dada en el planteamiento del problema. De no ser así, se puede asumir con un valor de $$ \epsilon = 0.001 $$

En C#, el código del ciclo iterativo se expresa así:

```csharp
do
{
    x = x1;

    float fdeX = f(x);
    float fPrimaX = df(x);

    x1 = x - f(x) / df(x);
    i++;

    // Imprimir los valores de la iteración actual
    Console.WriteLine($"{i,-3} | {x, -8:F8} | {fdeX, -8:F8} | {fPrimaX, -8:F8} | {x1, -8:F8} |{epsilon, -10:F8}");
} while (Math.Abs(x1 - x) > epsilon);
```

Donde:
* `x`: Corresponde al valor actual de la aproximación $ x_n $.
* `x1`: Corresponde a la nueva aproximación calculada $ x_{n+1} $.
* `Math.Abs(x1 - x)`: Equivale a la tolerancia calculada $ \epsilon_0 $.
* `epsilon`: Equivale a la tolerancia de error admisible dada ($ \epsilon $).
