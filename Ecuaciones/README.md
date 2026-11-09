# Solución de Ecuaciones por Búsqueda Exhaustiva e Incremental

Este programa implementa métodos numéricos de exploración por fuerza bruta y búsqueda incremental con discretización de paso para resolver ecuaciones algebraicas lineales, ecuaciones trascendentes trigonométricas y sistemas de ecuaciones lineales de $ 2 \times 2 $.

## Formula

### 1. Ecuación Lineal
Dada la igualdad:
$$
34 = 3x - 7 \implies 3x - 41 = 0
$$

La raíz teórica exacta es:
$$
x = \frac{41}{3} \approx 13.6667
$$

### 2. Ecuación Trigonométrica Trascendente
Se busca la raíz de la función no lineal:
$$
f(x) = \sin^2\left(\frac{x}{10}\right) - \cos\left(\frac{x}{20}\right) = 0
$$

Utilizando el **Teorema del Valor Intermedio (Teorema de Bolzano)**, existe al menos una raíz en el intervalo $[x_i, x_i + \Delta x]$ si ocurre un cambio de signo:
$$
f(x_i) \cdot f(x_i + \Delta x) < 0
$$

### 3. Sistema de Ecuaciones Lineales ($2 \times 2$)
Se resuelve el sistema simultáneo:
$$
\begin{cases}
3x + y = 1 \\
7x + 2y = 4
\end{cases}
$$

Cuya solución matricial analítica es $(x, y) = (2, -5)$.

---

## Aplicación

### Búsqueda de la Ecuación Lineal
El algoritmo discretiza el intervalo $[-100, 100]$ mediante incrementos finitos de $\Delta x = 0.01$. Se evalúan los extremos del subintervalo:
$$
\text{sol}_1 = 3x - 7, \quad \text{sol}_2 = 3(x + \Delta x) - 7
$$

Se detecta que el valor objetivo ($34$) ha sido cruzado cuando:

```csharp
if ((34 > sol1 && 34 < sol2) || (34 < sol1 && 34 > sol2))
{
    Console.WriteLine($"La solucion es: ${i}");
    break;
}
```

### Búsqueda Incremental en la Ecuación Trigonométrica
Se evalúa la función de forma secuencial con un paso $\Delta x = 0.01$. Al registrarse un producto negativo entre evaluaciones consecutivas, se confirma el cambio de signo:

```csharp
sol_1 = Math.Pow(Math.Sin(i / 10), 2) - Math.Cos(i / 20);
if (sol_1 * sol_2 < 0)
{
    Console.WriteLine($"La solucion es: ${i}");
    break;
}
sol_2 = sol_1;
```

### Exploración en Rejilla para el Sistema $2 \times 2$
Se anidan dos ciclos iterativos para recorrer los pares enteros $(x, y) \in [-100, 100) \times [-100, 100)$ con tamaño de paso $h = 1$:

```csharp
if (1 == 3 * x + y && 4 == 7 * x + 2 * y)
{
    Console.WriteLine($"x = {x}");
    Console.WriteLine($"y = {y}");
    break;
}
```

Donde:
* `step` o `paso`: Tamaño del incremento discreto $\Delta x$ entre cada iteración ($0.01$ para búsqueda continua y $1$ para búsqueda discreta).
* `sol_1` y `sol_2`: Evaluaciones sucesivas de la función para verificar el cambio de signo.
* `x` y `y`: Coordenadas exploradas dentro del espacio de búsqueda en la rejilla cartesiana.
