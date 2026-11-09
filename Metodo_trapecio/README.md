# Método del Trapecio

Este programa calcula numéricamente la aproximación de una integral definida $\int_{a}^{b} f(x) \, dx$ mediante la **regla del trapecio compuesta**. El programa solicita interactivamente al usuario en cuántos trapecios se deberá dividir la función, así como los límites inferior ($ a $) y superior ($ b $).

La función objetivo $ f(x) $ se encuentra implementada en el código dentro del método modular:

```csharp
funcionDeEquis(double x)
```

## Formula

El método del trapecio compuesto utiliza desde su definición formal la siguiente ecuación de cuadratura:

$$
\int_{a}^{b} f(x) \, dx \approx \frac{h}{2} \left[ f(x_0) + 2\displaystyle\sum_{i=1}^{n-1} f(x_i) + f(x_n) \right]
$$

### 1. Tamaño de paso (Base del trapecio)
Dado un intervalo $[a, b]$ dividido en $ n $ trapecios uniformes:

$$
h = \frac{b - a}{n}
$$

### 2. Área de cada trapecio individual
Para cada subintervalo $[x_i, x_{i+1}]$ donde $ x_i = a + i \cdot h $ y $ x_{i+1} = x_i + h $:

$$
A_i = \frac{h}{2} \left[ f(x_i) + f(x_{i+1}) \right]
$$

### 3. Función evaluada en el código
$$
f(x) = -x^3 + 10x^2 + 8x + 10
$$

---

## Aplicación

El programa solicita en consola:
1. Cantidad de trapecios ($ n $).
2. Límite inferior de integración ($ a $).
3. Límite superior de integración ($ b $).

A continuación, itera calculando las áreas individuales de cada trapecio e imprimiendo una tabla con el valor de la abscisa $ x_i $, la ordenada $ f(x_i) $, el área del trapecio actual y el área acumulada progresiva.

En C#, la función de integración se implementa de la siguiente manera:

```csharp
static double integralTrapecio(double a, double b, int n)
{
    double h = (b - a) / n;
    double areaAcumulada = 0.0;

    Console.WriteLine("\nTabla de valores de x");
    Console.WriteLine("-------------------------------------------------------------------------");
    Console.WriteLine("| Trapecio | valor de x |    f(x)    | Área Trapecio  | Área Acumulada  |");
    Console.WriteLine("-------------------------------------------------------------------------");

    for (int i = 0; i < n; i++)
    {
        double xi = a + i * h;
        double xip1 = xi + h;

        double fxi = funcionDeEquis(xi);
        double fxip1 = funcionDeEquis(xip1);

        double areaTrapecio = (h / 2.0) * (fxi + fxip1);
        areaAcumulada += areaTrapecio;

        Console.WriteLine($"| {i + 1,8} | {xi,10:F4} | {fxi,10:F4} | {areaTrapecio,14:F4} | {areaAcumulada,15:F4} |");
    }

    return areaAcumulada;
}
```

Donde:
* `a`: Límite inferior de integración.
* `b`: Límite superior de integración.
* `n`: Número de divisiones o trapecios especificados por el usuario.
* `h`: Ancho o altura común de los trapecios ($ \frac{b - a}{n} $).
* `xi` y `xip1`: Puntos extremos izquierdo ($ x_i $) y derecho ($ x_{i+1} $) de cada trapecio.
* `areaTrapecio`: Área del trapecio individual $ A_i = \frac{h}{2}(f(x_i) + f(x_{i+1})) $.
* `areaAcumulada`: Sumatoria total acumulada que representa el área bajo la curva aproximada.
