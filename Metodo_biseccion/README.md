# Método de Bisección

El método de bisección es un algoritmo cerrado de búsqueda de raíces para funciones continuas en un intervalo $[a, b]$, fundamentado en el Teorema del Valor Intermedio (Teorema de Bolzano). Si una función continua cumple que $ f(a) \cdot f(b) < 0 $, se garantiza la existencia de al menos una raíz en el intervalo. El método divide iterativamente el intervalo a la mitad hasta converger a la raíz con una tolerancia prefijada.

### Integrantes del equipo (Tarea 5):
* **Alan Bauza Alfonso** - [@alanbalfonso](https://github.com/alanbalfonso)
* **Ángel Andrés Hernández Lizardo** - [@AngelLizardo-Waggamer](https://github.com/AngelLizardo-Waggamer)
* **Luis Enrique Rodríguez Varela** - [@mrfuzball08](https://github.com/mrfuzball08)
* **Arturo Ardura Palacios** - [@ArturoArdura](https://github.com/ArturoArdura)
* **Dilan Rubén Salcedo Rosado** - [@Dylntsu](https://github.com/Dylntsu)

## Formula

Dada la función implementada:
$$
f(x) = 2x^2 + 5x - 1
$$

Definida en el intervalo inicial $[a, b] = [1, 2]$.

### 1. Cálculo del punto medio
En cada iteración $ i $, se calcula la aproximación de la raíz como el punto medio:

$$
x_r = \frac{a + b}{2}
$$

### 2. Estimación del Error
El error absoluto estimado en cada partición se define como la mitad de la longitud del intervalo actual:

$$
\epsilon_{abs} = \frac{|b - a|}{2}
$$

El error relativo porcentual se calcula respecto a la aproximación actual:

$$
\epsilon_{rel} (\%) = \frac{\epsilon_{abs}}{|x_r|} \times 100\%
$$

### 3. Criterio de Selección de Subintervalo
Se evalúa el cambio de signo para reducir el intervalo de búsqueda:
* Si $ f(a) \cdot f(x_r) < 0 $, la raíz se encuentra en la mitad izquierda:
$$
b = x_r
$$
* Si $ f(a) \cdot f(x_r) > 0 $, la raíz se encuentra en la mitad derecha:
$$
a = x_r
$$
* Si $ f(a) \cdot f(x_r) = 0 $, entonces $ x_r $ es la raíz exacta.

---

## Aplicación

El algoritmo itera hasta un máximo de $ n = 1000 $ iteraciones o hasta que el error o el valor de la función sea menor que la tolerancia preestablecida $\epsilon = 10^{-5}$ ($0.00001$).

En cada iteración se despliegan en consola los valores en una tabla con formato:
* Número de iteración ($ \# $)
* Extremo inferior ($ x_i = a $)
* Extremo superior ($ x_u = b $)
* Raíz aproximada ($ x_r $)
* Evaluaciones $ f(x_i) $, $ f(x_u) $ y $ f(x_r) $
* Error Absoluto y Error Relativo Porcentual

En C#, el criterio de parada y la reducción de intervalo se estructuran de la siguiente manera:

```csharp
// Criterio de parada por tolerancia
if (Math.Abs(fXr) < errorInicial || errorAbs < errorInicial) {
    Console.WriteLine($"\nNumero de iteraciones realizadas: {i + 1}");
    Console.WriteLine($"Raíz aproximada: {xr:F6}");
    break;
}

// Reducción del intervalo de búsqueda
if (fXi * fXr < 0) {
    b = xr;  // Subintervalo izquierdo [a, xr]
} else {
    a = xr;  // Subintervalo derecho [xr, b]
}
```

Donde:
* `a` ($ x_i $): Límite inferior del intervalo actual.
* `b` ($ x_u $): Límite superior del intervalo actual.
* `xr`: Punto medio calculado que representa la raíz estimada.
* `errorInicial`: Tolerancia máxima de error permitida ($\epsilon = 0.00001$).
* `fXr`: Valor de la función evaluada en el punto medio ($ f(x_r) $).
