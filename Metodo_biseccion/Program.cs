//Tarea 5 - Biseccion C#
Console.WriteLine("Tarea 5: Biseccion C#");
Console.WriteLine("Integrantes del equipo: ");
Console.WriteLine("Alan Bauza Alfonso.\nÁngel Andrés Hernández Lizardo. \nLuis Enrique Rodríguez Varela." 
    + "\nArturo Ardura Palacios. \nDilan Rubén Salcedo Rosado.");

// Ecuación y = 2x^2 - 5x + 1
double f(double x) {return 2 * Math.Pow(x, 2.0) + 5 * x - 1; }

//intervalo inicial
double a = 1;
double b = 2;

double errorInicial = 0.00001;

//iteraciones maximas
int n = 1000;

//encabezado de la tabla {numero columna, ancho}
Console.WriteLine("\n{0,-4} | {1,-8} | {2,-8} | {3,-8} | {4,-10} | {5,-10} | {6,-10} | {7,-10} | {8,-4}",
                "#", "xi", "xu", "xr", "f(xi)", "f(xu)", "f(xr)", "Error Abs", "Error Rel (%)");
Console.WriteLine(new string('-', 105));

//calculo punto medio y funciones con terminos distintos
for (int i = 0; i < n; i++) {
    double xr = (a + b) / 2;  // punto medio
    double fXi = f(a);  //funcion con terminos de Xi
    double fXu = f(b);  //funcion con terminos de Xu
    double fXr = f(xr); //funcion con terminos de Xr

    // errores absoluto y relativo
    double errorAbs = Math.Abs(b - a) / 2;
    double errorRel = errorAbs / Math.Abs(xr) * 100;

    // i = iteracion, a = Xi, b = Xu
    // {expresion, ancho:formato}
    Console.WriteLine($"{i + 1,-4} | {a,-8:F6} | {b,-8:F6} | {xr,-8:F6} | {fXi,-10:F6} | {fXu,-10:F6} | {fXr,-10:F6} | {errorAbs,-10:F6} | {errorRel,-4:F2}%");

    //resumen
    if (Math.Abs(fXr) < errorInicial || errorAbs < errorInicial) {
        Console.WriteLine($"\nNumero de iteraciones realizadas: {i + 1}");
        Console.WriteLine($"Raíz aproximada: {xr:F6}");
        break;
    }

    //reduccion de intervalo (si f(x) cambia de signo significa que hay una raiz en el intervalo)
    if (fXi * fXr < 0) {
        b = xr;  //[a, xr]
    } else {
        a = xr;  //[xr, b]
    }
}