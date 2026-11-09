# Método de Runge-Kutta de 4to Orden (RK4)

El método de Runge-Kutta de cuarto orden (RK4) es un algoritmo numérico explícito y de alta precisión para resolver problemas de valor inicial (PVI) en ecuaciones diferenciales ordinarias (EDO) de primer orden:

$$
\frac{dy}{dx} = f(x, y), \quad y(x_0) = y_0
$$

El método evalúa cuatro pendientes intermedias ponderadas dentro de cada intervalo de paso $ h $ para proyectar el siguiente valor de la función dependiente $ y $.

## Formula

Dada la ecuación diferencial implementada en el programa:
$$
\frac{dy}{dx} = x + y
$$

Para avanzar desde el punto $(x_n, y_n)$ hasta $(x_{n+1}, y_{n+1})$ con tamaño de paso $ h $:

### 1. Pendientes intermedias ($k$)
* **Pendiente al inicio del intervalo:**
$$
k_1 = f(x_n, y_n)
$$

* **Primera pendiente en el punto medio:**
$$
k_2 = f\left(x_n + \frac{h}{2}, \; y_n + \frac{h}{2} k_1\right)
$$

* **Segunda pendiente en el punto medio:**
$$
k_3 = f\left(x_n + \frac{h}{2}, \; y_n + \frac{h}{2} k_2\right)
$$

* **Pendiente al final del intervalo:**
$$
k_4 = f\left(x_n + h, \; y_n + h k_3\right)
$$

### 2. Proyección de $y_{n+1}$ (Promedio Ponderado)
$$
y_{n+1} = y_n + \frac{h}{6} \left( k_1 + 2k_2 + 2k_3 + k_4 \right)
$$

### 3. Actualización de $x$
$$
x_{n+1} = x_n + h
$$

---

## Aplicación

El programa solicita interactivamente:
1. Valor inicial de la variable independiente ($ x_0 $).
2. Valor final o límite de evaluación ($ x_{final} $).
3. Tamaño de paso ($ h $).
4. Condición inicial de la variable dependiente ($ y_0 $).

En cada iteración, calcula las cuatro constantes $ k $ y actualiza las variables hasta que $ x \ge x_{final} $.

En C#, el bucle principal de integración se implementa de la siguiente forma:

```csharp
while (x < x_final) {
    double k1 = Funciones.FormulaK(x, y);
    double k2 = Funciones.FormulaK_Mitad(x, y, h, k1);
    double k3 = Funciones.FormulaK_Mitad(x, y, h, k2);
    double k4 = Funciones.FormulaK_Fin(x, y, h, k3);

    y = Funciones.FormulaParaY(y, h, k1, k2, k3, k4);
    x += h;

    // Redondeos a 4 decimales para visualización
    x = Math.Round(x, 4);
    y = Math.Round(y, 4);

    Console.WriteLine($"x = {x}, y = {y}");
}
```

Y la fórmula de ponderación en la clase auxiliar:

```csharp
public static double FormulaParaY(double y_n, double h, double k1, double k2, double k3, double k4) {
    return y_n + (h / 6) * (k1 + 2 * k2 + 2 * k3 + k4);
}
```

Donde:
* `x` e `y`: Coordenadas del estado actual $(x_n, y_n)$.
* `h`: Tamaño del paso temporal o espacial $\Delta x$.
* `x_final`: Cota superior que delimita la condición de parada del ciclo `while`.
* `k1, k2, k3, k4`: Pendientes calculadas en puntos específicos del intervalo según RK4.
