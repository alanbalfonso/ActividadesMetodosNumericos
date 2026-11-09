# Método de Eliminación Gaussiana

Este programa resuelve sistemas de ecuaciones lineales de la forma general $ A x = b $ de tamaño $ 3 \times 3 $ mediante el algoritmo clásico de **Eliminación Gaussiana simple** con sustitución regresiva (hacia atrás).

## Formula

Dado un sistema de $ n $ ecuaciones lineales con $ n $ incógnitas:

$$
\begin{bmatrix}
a_{11} & a_{12} & \cdots & a_{1n} \\
a_{21} & a_{22} & \cdots & a_{2n} \\
\vdots & \vdots & \ddots & \vdots \\
a_{n1} & a_{n2} & \cdots & a_{nn}
\end{bmatrix}
\begin{bmatrix}
x_1 \\
x_2 \\
\vdots \\
x_n
\end{bmatrix}
=
\begin{bmatrix}
b_1 \\
b_2 \\
\vdots \\
b_n
\end{bmatrix}
$$

El método consta de dos fases principales:

### 1. Eliminación hacia adelante (Triangularización Superior)
Para cada fila pivote $ i $ (desde $ 0 $ hasta $ n-1 $) y cada fila inferior $ k $ (desde $ i+1 $ hasta $ n-1 $), se calcula el multiplicador:

$$
m_{k,i} = \frac{a_{k,i}}{a_{i,i}}
$$

Y se transforman los elementos de la matriz y el vector de términos independientes:

$$
a_{k,j}^{(nuevo)} = a_{k,j} - m_{k,i} \cdot a_{i,j}, \quad \forall j \in \{0, \dots, n-1\}
$$
$$
b_k^{(nuevo)} = b_k - m_{k,i} \cdot b_i
$$

### 2. Sustitución hacia atrás (Regresiva)
Una vez que el sistema se transforma en una matriz triangular superior, las incógnitas se despejan desde la última fila $ n-1 $ hasta la primera:

$$
x_i = \frac{b_i - \displaystyle\sum_{j=i+1}^{n-1} a_{i,j} x_j}{a_{i,i}}
$$

---

## Sistemas Evaluados en el Programa

El código evalúa automáticamente cuatro sistemas de ecuaciones $ 3 \times 3 $:

1. **Sistema 1:**
$$
\begin{cases}
2x_1 - x_2 + x_3 = 8 \\
3x_1 + 3x_2 + 9x_3 = 0 \\
3x_1 + 3x_2 + 5x_3 = -6
\end{cases}
$$

2. **Sistema 2:**
$$
\begin{cases}
x_1 + 2x_2 - x_3 = 3 \\
3x_1 - 4x_2 + 2x_3 = 2 \\
2x_1 + 3x_2 + 3x_3 = 5
\end{cases}
$$

3. **Sistema 3:**
$$
\begin{cases}
4x_1 - 2x_2 + x_3 = 2 \\
x_1 + x_2 - 3x_3 = -1 \\
2x_1 - 3x_2 + x_3 = 3
\end{cases}
$$

4. **Sistema 4:**
$$
\begin{cases}
5x_1 + 2x_2 - 3x_3 = 4 \\
-3x_1 - x_2 + 2x_3 = -2 \\
2x_1 + 3x_2 + x_3 = 5
\end{cases}
$$

---

## Aplicación

El algoritmo se implementa en la función `ResolverGauss(double[,] a, double[] b)` en dos bloques principales de código:

### Fase de Eliminación en C#:
```csharp
for (int i = 0; i < n; i++) {
    for (int k = i + 1; k < n; k++) {
        double t = a[k, i] / a[i, i];
        for (int j = 0; j < n; j++) {
            a[k, j] -= t * a[i, j];
        }
        b[k] -= t * b[i];
    }
}
```

### Fase de Sustitución Regresiva en C#:
```csharp
double[] x = new double[n];
for (int i = n - 1; i >= 0; i--) {
    x[i] = b[i];
    for (int j = i + 1; j < n; j++) {
        x[i] -= a[i, j] * x[j];
    }
    x[i] /= a[i, i];
}
return x;
```

Donde:
* `a`: Matriz bidimensional que almacena los coeficientes del sistema ($ A $).
* `b`: Vector que contiene los términos independientes del sistema.
* `t`: Multiplicador escalar $ m_{k,i} $ que anula el coeficiente inferior.
* `x`: Vector solución que almacena las raíces calculadas con formato de 4 decimales (`F4`).
