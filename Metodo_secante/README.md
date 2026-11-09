# Método de la Secante

El método de la secante es un algoritmo numérico abierto para encontrar raíces de funciones continuas. A diferencia del método de Newton-Raphson, no requiere calcular analíticamente la derivada de la función, ya que aproxima la pendiente de la recta tangente mediante una recta secante trazada entre dos puntos previos: $ x_{n-1} $ y $ x_n $.

### Integrantes del equipo (Tarea 6):
* **Alan Bauza Alfonso** - [@alanbalfonso](https://github.com/alanbalfonso)
* **Ángel Andrés Hernández Lizardo** - [@AngelLizardo-Waggamer](https://github.com/AngelLizardo-Waggamer)
* **Luis Enrique Rodríguez Varela** - [@mrfuzball08](https://github.com/mrfuzball08)
* **Arturo Ardura Palacios** - [@ArturoArdura](https://github.com/ArturoArdura)
* **Dilan Rubén Salcedo Rosado** - [@Dylntsu](https://github.com/Dylntsu)
* **Víctor Manuel Quiñones Gil**

## Formula

### 1. Aproximación de la Raíz
Dada la fórmula recurrente clásica del método de la secante:

$$
x_{n+1} = x_n - f(x_n) \left[ \frac{x_n - x_{n-1}}{f(x_n) - f(x_{n-1})} \right]
$$

En la implementación del programa, expresada con las variables de extremos y aproximación ($ X_1 $, $ X_u $ y $ X_r $):

$$
X_r = X_u - \frac{f(X_u)(X_u - X_1)}{f(X_u) - f(X_1)}
$$

### 2. Función evaluada
$$
f(x) = 2x^2 - 5x + 1
$$

Con valores iniciales configurados en el programa:
$$
X_1 = 0, \quad X_u = 1
$$

### 3. Estimación del Error
El error absoluto en cada iteración $ i \ge 1 $ se define como la diferencia respecto a la aproximación previa:

$$
\epsilon_{abs} = |X_r - X_{r, anterior}|
$$

El error relativo y el error relativo porcentual corresponden a:

$$
\epsilon_{rel} = \frac{\epsilon_{abs}}{|X_r|}
$$
$$
\epsilon_{\%} = \epsilon_{rel} \times 100\%
$$

---

## Aplicación

El algoritmo evalúa sucesivamente la función y actualiza los dos puntos base ($ X_1 \leftarrow X_u $, $ X_u \leftarrow X_r $). Para garantizar estabilidad numérica, valida que el denominador no sea cercano a cero ($ |f(X_u) - f(X_1)| < 10^{-10} $) y limita el proceso a un máximo de $100$ iteraciones.

El proceso iterativo se repite hasta que el error absoluto sea menor o igual a la tolerancia especificada ($\epsilon = 0.0001$). Por tanto, la condición delimitadora para el ciclo `do-while` es:

$$
\epsilon_{abs} > 0.0001
$$

En C#, el bucle se implementa de la siguiente manera:

```csharp
do {
    Fx1 = Funcion.EvaluarFuncion(X1);
    Fxu = Funcion.EvaluarFuncion(Xu);

    // Prevención de división por cero
    if (Math.Abs(Fxu - Fx1) < 1e-10) {
        Console.WriteLine("Error: División por cero. Fxu y Fx1 son iguales.");
        return;
    }

    Xr = Funcion.calcularXr(Xu, Fxu, X1, Fx1);
    Fxr = Funcion.EvaluarFuncion(Xr);

    if (i == 0) {
        ErrorAbsoluto = 1;
    } else {
        ErrorAbsoluto = Math.Abs(Xr - XrAnterior);
    }

    ErrorRelativo = ErrorAbsoluto / Xr;
    ErrorPorcentual = ErrorRelativo * 100;

    // Actualización de extremos para la siguiente iteración
    X1 = Xu;
    Xu = Xr;
    XrAnterior = Xr;
    i++;

    if (i > maxIteraciones) {
        Console.WriteLine("Error: El método no converge después de " + maxIteraciones + " iteraciones.");
        return;
    }
} while (ErrorAbsoluto > 0.0001);
```

Donde:
* `X1`: Primer punto inicial $ x_{n-1} $.
* `Xu`: Segundo punto inicial $ x_n $.
* `Xr`: Raíz calculada mediante la intersección de la recta secante con el eje $ x $ ($ x_{n+1} $).
* `Fx1` y `Fxu`: Evaluaciones $ f(X_1) $ y $ f(X_u) $.
* `ErrorAbsoluto`: Magnitud de cambio entre aproximaciones consecutivas $\epsilon_{abs}$.
* `0.0001`: Criterio de tolerancia prefijado ($\epsilon$).
