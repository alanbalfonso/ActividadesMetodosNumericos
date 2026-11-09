# Método de los Rectángulos (Integración Numérica)

El método de los rectángulos (suma de Riemann por el extremo izquierdo) permite aproximar el valor de una integral definida $\int_{a}^{b} f(x) \, dx$, representando el área geométrica bajo la curva como la suma de las áreas de una serie de rectángulos de base uniforme.

## Formula

Dada la función polinomial evaluada en el programa:
$$
f(x) = -x^3 + 10x^2 + 8x + 10
$$

Para aproximar la integral en el intervalo $[a, b]$ dividido en $ n $ rectángulos:

### 1. Cálculo de la base (tamaño de paso)
La base común de cada rectángulo se define dividiendo la amplitud del intervalo entre el número de rectángulos deseados:

$$
h = \Delta x = \frac{b - a}{n}
$$

### 2. Altura y área de cada rectángulo
Tomando el extremo izquierdo de cada subintervalo como altura:
$$
x_i = a + i \cdot h, \quad \forall i \in \{0, 1, \dots, n-1\}
$$
$$
A_i = h \cdot f(x_i)
$$

### 3. Integral definida aproximada (Área total)
El área acumulada total es la sumatoria de las áreas individuales:

$$
\int_{a}^{b} f(x) \, dx \approx \sum_{i=0}^{n-1} A_i = h \sum_{i=0}^{n-1} f(x_i)
$$

---

## Aplicación

El programa solicita por teclado:
1. En cuántos rectángulos se dividirá la función ($ n $).
2. El límite inferior de integración ($ a $).
3. El límite superior de integración ($ b $).

Posteriormente, genera una tabla detallada con los valores de cada rectángulo, la ordenada $ f(x_i) $, el área individual y el área acumulada progresiva.

En C#, la acumulación del área se implementa con el siguiente ciclo `while`:

```csharp
baseRectangulo = (limite_sup - limite_inf) / partesRectangulo;
x = limite_inf;

int iteracion = 1;
while (x < limite_sup)
{
    // Función f(x) = -x^3 + 10x^2 + 8x + 10
    alturaRectangulo = -Math.Pow(x, 3) + 10 * Math.Pow(x, 2) + 8 * x + 10;
    double areaRectangulo = baseRectangulo * alturaRectangulo;
    area += areaRectangulo;

    Console.WriteLine($"| {iteracion,10} | {x,10:F4} | {alturaRectangulo,10:F4} | {areaRectangulo,13:F4} | {area,12:F4} |");

    x += baseRectangulo;
    iteracion++;
}
```

Donde:
* `baseRectangulo`: Representa el ancho uniforme $ h $ de cada rectángulo.
* `x`: Coordenada de evaluación actual $ x_i $.
* `alturaRectangulo`: Altura evaluada $ f(x_i) $.
* `areaRectangulo`: Área individual del rectángulo actual ($ A_i = h \cdot f(x_i) $).
* `area`: Sumatoria acumulada que aproxima el valor de la integral definida.
* `limite_sup`: Límite superior $ b $ que actúa como condición de parada del bucle (`x < limite_sup`).
