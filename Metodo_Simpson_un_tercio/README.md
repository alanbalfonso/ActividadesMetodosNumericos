# Regla de Simpson 1/3

La regla de Simpson 1/3 compuesta es un método de cuadratura numérica de Newton-Cotes cerrado que aproxima el valor de una integral definida $\int_{a}^{b} f(x) \, dx$ interpolando la función mediante polinomios cuadráticos (parábolas) de Lagrange sobre pares consecutivos de subintervalos.

## Formula

### 1. Parámetros de Discretización
El intervalo $[a, b]$ se divide en un número **par** de subintervalos $ n $:

$$
h = \frac{b - a}{n}, \quad \text{con } n \pmod 2 = 0
$$

Los puntos nodales se calculan de forma equiespaciada:

$$
x_j = a + j \cdot h, \quad \forall j \in \{0, 1, \dots, n\}
$$

### 2. Regla Compuesta de Simpson 1/3
Evaluando las parábolas sobre cada par de segmentos adyacentes $[x_{2j-2}, x_{2j}]$:

$$
\int_{a}^{b} f(x) \, dx \approx \frac{h}{3} \sum_{j=1}^{n/2} \left[ f(x_{2j-2}) + 4f(x_{2j-1}) + f(x_{2j}) \right]
$$

O en su forma expandida tradicional:

$$
\int_{a}^{b} f(x) \, dx \approx \frac{h}{3} \left[ f(x_0) + 4\sum_{k=1, \text{impar}}^{n-1} f(x_k) + 2\sum_{k=2, \text{par}}^{n-2} f(x_k) + f(x_n) \right]
$$

### 3. Función y Parámetros del Programa
* **Función a integrar:**
$$
f(x) = x \sin(x)
$$
* **Límites de integración:**
$$
a = 1, \quad b = 4, \quad n = 8
$$

---

## Aplicación

Para aplicar la regla de Simpson 1/3, es un requisito matemático indispensable que el número de subintervalos $ n $ sea par, de modo que cada segmento parabólico cubra exactamente 2 franjas contiguas de ancho $ h $.

En C#, la validación de paridad y el cálculo numérico se estructuran así:

```csharp
static float Simpson(float a, float b, int n)
{
    float h = (b - a) / n;
    float[] x = new float[n + 1];
    float sum = 0;

    x[0] = a;

    for (int j = 1; j <= n; j++)
    {
        x[j] = a + h * j;
    }

    for (int j = 1; j <= n / 2; j++)
    {
        sum += F(x[2 * j - 2]) + 4 * F(x[2 * j - 1]) + F(x[2 * j]);
    }

    return sum * h / 3;
}
```

Condición en el flujo de ejecución principal:

```csharp
if (n % 2 == 0)
{
    Console.WriteLine("Resultado para la integral: ");
    Console.WriteLine(Simpson(a, b, n));
}
else
{
    Console.WriteLine("n debería ser un número par");
}
```

Donde:
* `a` y `b`: Límites inferior y superior del intervalo de integración ($[1, 4]$).
* `n`: Número de subintervalos ($8$). Debe cumplir $n \pmod 2 == 0$.
* `h`: Tamaño de paso o espaciado uniforme entre puntos nodales.
* `x`: Arreglo de coordenadas $ x_j $ generadas a lo largo del intervalo.
* `sum * h / 3`: Factor multiplicador característico de la regla de Simpson 1/3.
