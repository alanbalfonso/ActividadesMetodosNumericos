# Evidencia 1 - Métodos Numéricos

Este proyecto consolidado integra en una única aplicación de consola con menú interactivo los módulos desarrollados durante el primer parcial de la materia de Métodos Numéricos, abarcando desde fundamentos de programación en C# hasta algoritmos de búsqueda de raíces y solución de sistemas de ecuaciones lineales.

## Fórmulas y Módulos Integrados

El sistema integra cinco actividades estructuradas en clases independientes dentro de `src/`:

### 1. Actividad y Tarea 1 (`ActTar1_AlanBauza.cs`)
Fundamentos del lenguaje C#: tipado de datos primitivos (enteros, dobles, caracteres, cadenas, booleanos), estructuras de decisión (`if-else`, `switch-case`) y ciclos definidos para tablas de multiplicar:

$$
T_i = n \times i, \quad \forall i \in \{1, 2, \dots, 10\}
$$

### 2. Actividad y Tarea 2 (`ActTar2_AlanBauza.cs`)
Calculadora aritmética elemental interactiva con validación de indeterminación en la división:

$$
R = a \circ b, \quad \circ \in \{+, -, \times, \div\} \quad \text{donde } b \neq 0 \text{ si } \circ = \div
$$

### 3. Actividad 3 (`ActTar3_AlanBauza.cs`)
Búsqueda numérica discreta e incremental:
* Ecuación lineal: $34 = 3x - 7 \implies x \approx 13.66$
* Ecuación trigonométrica: $\sin^2\left(\frac{x}{10}\right) - \cos\left(\frac{x}{20}\right) = 0$ con detección de cambio de signo:
$$
f(x_1) \cdot f(x_2) < 0
$$
* Sistema $2 \times 2$ exhaustivo:
$$
\begin{cases}
3x + y = 1 \\
7x + 2y = 4
\end{cases}
$$

### 4. Tarea 3 (`Tarea3_AlanBauza.cs`)
Búsqueda exhaustiva en cuadrícula para resolver el sistema:
$$
\begin{cases}
2x + 3y = 13 \\
4x - y = 5
\end{cases}
$$

Con criterio de cercanía por valor absoluto:
$$
|(2x + 3y) - 13| < 1 \quad \land \quad |(4x - y) - 5| < 1
$$

### 5. Actividad y Tarea 4 (`ActTar4_AlanBauza.cs`)
Resolución de sistemas de ecuaciones de $ 3 \times 3 $ mediante el algoritmo de Eliminación Gaussiana:

$$
m_{k,i} = \frac{a_{k,i}}{a_{i,i}}, \quad x_i = \frac{b_i - \displaystyle\sum_{j=i+1}^{n-1} a_{i,j} x_j}{a_{i,i}}
$$

---

## Aplicación

El programa principal `Program.cs` gestiona el flujo de interacción mediante un menú por consola operado por un ciclo `do-while`:

```csharp
do {
    Menu.ImprimirMenu();
    opcion = int.Parse(Console.ReadLine()!);
    switch(opcion) {
        case 0:
            Console.WriteLine("Gracias por utilizar este programa!");
            break;
        case 1:
            ActTar1_AlanBauza.Exec();
            break;
        case 2:
            ActTar2_AlanBauza.Exec();
            break;
        case 3:
            ActTar3_AlanBauza.Exec();
            break;
        case 4:
            Tarea3_AlanBauza.Exec();
            break;
        case 5:
            ActTar4_AlanBauza.Exec();
            break;
        default:
            Console.WriteLine("Intente de nuevo.");
            break;
    }
} while(opcion != 0);
```

Donde:
* `opcion`: Número entero ingresado por el usuario para seleccionar la actividad a ejecutar.
* `0`: Condición delimitadora para finalizar el programa.
* `ActTar*.Exec()`: Métodos estáticos modulares que encapsulan la lógica de cada ejercicio.
