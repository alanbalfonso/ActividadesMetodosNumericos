# Solución Exhaustiva de Sistema de Ecuaciones

Este programa implementa un método numérico de búsqueda exhaustiva por fuerza bruta en cuadrícula (grid search) para encontrar la solución entera de un sistema de dos ecuaciones lineales con dos incógnitas ($ 2 \times 2 $).

## Formula

El sistema de ecuaciones planteado es:

$$
\begin{cases}
2x + 3y = 13 \\
4x - y = 5
\end{cases}
$$

### Solución analítica exacta
Multiplicando la segunda ecuación por $3$ y sumándola a la primera:

$$
(2x + 3y) + 3(4x - y) = 13 + 3(5) \implies 14x = 28 \implies x = 2
$$

Sustituyendo en la segunda ecuación:

$$
4(2) - y = 5 \implies 8 - y = 5 \implies y = 3
$$

Por tanto, el vector solución exacto es:

$$
\begin{bmatrix}
x \\
y
\end{bmatrix}
=
\begin{bmatrix}
2 \\
3
\end{bmatrix}
$$

### Criterio de Proximidad por Valor Absoluto
Dado que en métodos numéricos discretos se evalúa la cercanía de las igualdades a una tolerancia prefijada, la condición de convergencia se define como:

$$
| (2x + 3y) - 13 | < \epsilon \quad \land \quad | (4x - y) - 5 | < \epsilon
$$

Donde se establece una tolerancia permisible de $\epsilon = 1$.

---

## Aplicación

El algoritmo recorre un espacio bidimensional acotado $ x \in [-100, 100) $ e $ y \in [-100, 100) $ mediante dos ciclos anidados con un incremento entero de paso $ \Delta = 1 $.

En cada par de coordenadas $(x, y)$, se evalúan los residuos de ambas ecuaciones simultáneamente. Al encontrarse el par que satisface el criterio de cercanía, se imprimen las coordenadas y se interrumpe la búsqueda.

En C#, la implementación se expresa de la siguiente forma:

```csharp
double step = 1;
for (double x = -100; x < 100; x = x += step){
    for (double y = -100; y < 100; y = y += step){
        //! si al restar menos la igualdad en la ecuacion y al comparar con 1 es menor entonces es correcto
        if (Math.Abs((2 * x + 3 * y) - 13) < 1 && Math.Abs((4 * x - y) - 5) < 1) {
            Console.WriteLine("El resultado es: ");
            Console.WriteLine($"x = {x}");  
            Console.WriteLine($"y = {y}");
            break;
        }
    }
}
```

Donde:
* `x` e `y`: Variables de decisión iteradas en el rango de búsqueda $[-100, 100)$.
* `step`: Tamaño de paso de la cuadrícula ($\Delta = 1$).
* `Math.Abs(...)`: Función de valor absoluto utilizada para calcular el residuo o error respecto al término independiente.
* `< 1`: Tolerancia de error establecida ($\epsilon = 1$).
