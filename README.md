# Actividades de Métodos Numéricos

Repositorio de implementaciones en **C# (.NET 8)** para la materia de **Métodos Numéricos** (4to Semestre - Universidad Tecmilenio). 

Este compendio agrupa programas de consola diseñados para resolver problemas matemáticos fundamentales mediante algoritmos numéricos computacionales: búsqueda de raíces en ecuaciones trascendentes y no lineales, resolución de sistemas de ecuaciones lineales, cuadratura numérica (integración) y solución de ecuaciones diferenciales ordinarias (EDO).

## Equipo y Colaboradores

* **Alan Bauza Alfonso** - [@alanbalfonso](https://github.com/alanbalfonso)
* **Ángel Andrés Hernández Lizardo** - [@AngelLizardo-Waggamer](https://github.com/AngelLizardo-Waggamer)
* **Luis Enrique Rodríguez Varela** - [@mrfuzball08](https://github.com/mrfuzball08)
* **Arturo Ardura Palacios** - [@ArturoArdura](https://github.com/ArturoArdura)
* **Dilan Rubén Salcedo Rosado** - [@Dylntsu](https://github.com/Dylntsu)
* **Víctor Manuel Quiñones Gil**

---

## Contenidos y Módulos

El repositorio se compone de 12 proyectos individuales gestionados bajo la solución global `Formateador.sln`:

```
ActividadesMetodosNumericos/
├── Calculadora_basica/        # Actividad y tarea 2: Aritmética básica interactiva
├── Ecuaciones/                # Actividad 3: Búsqueda exhaustiva e incremental (lineal, trigonométrica y 2x2)
├── Eliminacion_gauss/         # Actividad 4: Eliminación Gaussiana simple (sistemas 3x3)
├── Evidencia1/                # Evidencia 1: Menú integrador del primer parcial (Actividades 1-4)
├── Metodo_biseccion/          # Tarea 5: Algoritmo cerrado de bisección
├── Metodo_secante/            # Tarea 6: Método abierto de la secante
├── Metodo_Newton_Raphson/     # Tarea 7: Método de Newton-Raphson con derivadas
├── Metodo_rectangulos/        # Tarea 9: Integración por suma de Riemann izquierda
├── Metodo_trapecio/           # Integración numérica por regla del trapecio compuesta
├── Metodo_Simpson_un_tercio/  # Integración numérica por regla de Simpson 1/3 compuesta
├── Metodo_Runge_Kutta/        # Solución de EDO de 1er orden mediante Runge-Kutta 4to orden (RK4)
├── Sistema_ecuaciones/        # Tarea 3: Solución de sistema 2x2 por exploración en cuadrícula
└── Formateador.sln            # Archivo de solución maestro de Visual Studio
```

---

## Resumen y Métodos Implementados

A continuación se presenta la clasificación matemática de las actividades desarrolladas en este repositorio, junto con su formulación analítica y enlace a su documentación específica:

### 1. Búsqueda de Raíces de Ecuaciones No Lineales

Permiten determinar el valor $ x^* $ tal que $ f(x^*) = 0 $.

| Método / Carpeta | Tipo de Método | Función Modelo | Ecuación / Criterio Recursivo |
|---|---|---|---|
| [Método de Bisección](./Metodo_biseccion/README.md) | Cerrado (Intervalo) | $f(x) = 2x^2 + 5x - 1$ | $x_r = \frac{a + b}{2}, \quad f(a) \cdot f(x_r) < 0$ |
| [Método de Newton-Raphson](./Metodo_Newton_Raphson/README.md) | Abierto (Tangente) | $f(x) = 2x^2 - 5x + 1$ | $x_{n+1} = x_n - \frac{f(x_n)}{f'(x_n)}$ |
| [Método de la Secante](./Metodo_secante/README.md) | Abierto (Diferencias finitas) | $f(x) = 2x^2 - 5x + 1$ | $x_{n+1} = x_n - \frac{f(x_n)(x_n - x_{n-1})}{f(x_n) - f(x_{n-1})}$ |
| [Búsqueda Incremental (Ecuaciones)](./Ecuaciones/README.md) | Exploración Discreta | $\sin^2\left(\frac{x}{10}\right) - \cos\left(\frac{x}{20}\right) = 0$ | $f(x_i) \cdot f(x_{i+1}) < 0$ con $\Delta x = 0.01$ |

---

### 2. Sistemas de Ecuaciones Lineales ($ A x = b $)

Resolución de sistemas algebraicos simultáneos de ecuaciones lineales.

| Método / Carpeta | Dimensión | Problema / Sistema | Formulación Matemática |
|---|---|---|---|
| [Eliminación Gaussiana](./Eliminacion_gauss/README.md) | $3 \times 3$ | 4 sistemas matriciales de prueba | Pivoteo hacia adelante: $m_{k,i} = \frac{a_{k,i}}{a_{i,i}}$<br>Sustitución regresiva: $x_i = \frac{b_i - \sum a_{ij}x_j}{a_{ii}}$ |
| [Sistema Exhaustivo 2x2](./Sistema_ecuaciones/README.md) | $2 \times 2$ | $\begin{cases} 2x + 3y = 13 \\ 4x - y = 5 \end{cases}$ | Búsqueda en cuadrícula con tolerancia:<br>$\|(2x+3y)-13\| < 1 \land \|(4x-y)-5\| < 1$ |

---

### 3. Integración Numérica (Cuadratura)

Aproximación del área bajo la curva para integrales definidas $ I = \int_{a}^{b} f(x) \, dx $.

| Método / Carpeta | Función Modelo | Intervalo / Partición | Fórmula de Cuadratura |
|---|---|---|---|
| [Método de Rectángulos](./Metodo_rectangulos/README.md) | $f(x) = -x^3 + 10x^2 + 8x + 10$ | $[a, b]$ dividido en $n$ partes | $I \approx h \sum_{i=0}^{n-1} f(x_i), \quad h = \frac{b-a}{n}$ |
| [Método del Trapecio](./Metodo_trapecio/README.md) | $f(x) = -x^3 + 10x^2 + 8x + 10$ | $[a, b]$ dividido en $n$ trapecios | $I \approx \frac{h}{2} \left[ f(x_0) + 2\sum_{i=1}^{n-1} f(x_i) + f(x_n) \right]$ |
| [Regla de Simpson 1/3](./Metodo_Simpson_un_tercio/README.md) | $f(x) = x \sin(x)$ | $[1, 4]$ con $n = 8$ (par) | $I \approx \frac{h}{3} \left[ f_0 + 4\sum f_{\text{impar}} + 2\sum f_{\text{par}} + f_n \right]$ |

---

### 4. Ecuaciones Diferenciales Ordinarias (EDO)

Solución de problemas de valor inicial (PVI) de la forma $\frac{dy}{dx} = f(x, y), \; y(x_0) = y_0$.

| Método / Carpeta | EDO Evaluada | Fórmulas Clave |
|---|---|---|
| [Runge-Kutta 4to Orden (RK4)](./Metodo_Runge_Kutta/README.md) | $\frac{dy}{dx} = x + y$ | $k_1 = f(x_n, y_n)$<br>$k_2 = f\left(x_n + \frac{h}{2}, y_n + \frac{h}{2}k_1\right)$<br>$k_3 = f\left(x_n + \frac{h}{2}, y_n + \frac{h}{2}k_2\right)$<br>$k_4 = f(x_n + h, y_n + hk_3)$<br>$y_{n+1} = y_n + \frac{h}{6}(k_1 + 2k_2 + 2k_3 + k_4)$ |

---

### 5. Fundamentos y Proyectos Integradores

| Módulo / Carpeta | Descripción |
|---|---|
| [Calculadora Básica](./Calculadora_basica/README.md) | Control de flujo iterativo `do-while`, operaciones aritméticas elementales y control de división entre cero. |
| [Evidencia 1](./Evidencia1/README.md) | Aplicación interactiva por consola que integra en un menú ejecutable las Actividades 1 a 4 y Tarea 3. |

---

## Requisitos y Guía de Ejecución

### Prerrequisitos
* [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) o superior instalado en el equipo.
* Visual Studio 2022 o Visual Studio Code con la extensión de C# (opcional).

### Clonación y Verificación
```bash
# Clonar el repositorio
git clone <url-del-repositorio>
cd ActividadesMetodosNumericos

# Verificar versión instalada de .NET
dotnet --version
```

### Ejecución de Proyectos Específicos
Cada actividad se puede compilar y ejecutar de forma directa desde la raíz mediante el parámetro `--project`:

```bash
# Ejecutar Método de Newton-Raphson
dotnet run --project Metodo_Newton_Raphson

# Ejecutar Método del Trapecio
dotnet run --project Metodo_trapecio

# Ejecutar Regla de Simpson 1/3
dotnet run --project Metodo_Simpson_un_tercio

# Ejecutar Runge-Kutta (RK4)
dotnet run --project Metodo_Runge_Kutta

# Ejecutar el menú interactivo de la Evidencia 1
dotnet run --project Evidencia1
```

O bien, navegando directamente a la subcarpeta deseada:

```bash
cd Metodo_biseccion
dotnet run
```

---

## Tecnologías y Estándares Utilizados

* **Lenguaje:** C# (.NET 8 SDK).
* **Solución:** Visual Studio Solution (`Formateador.sln`).
* **Documentación Matemática:** Markdown con KaTeX / LaTeX para renderizado de matrices, sumatorias, derivadas e integrales.
