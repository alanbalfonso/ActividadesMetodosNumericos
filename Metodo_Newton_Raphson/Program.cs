// Función 2x^2 - 5x + 1
float f(float x) { return 2 * (x * x) - 5 * x + 1; }
// Derivada de la función
float df(float? x) { if(x != null) { return (float)(4 * x - 5); } else {return 0;} };

float NewtonRaphson(float x0, float epsilon)
{
    float x = x0;
    float x1 = x0;
    //contador de iteraciones
    int i = 0;

    // Encabezado de la tabla
    Console.WriteLine("Función: 2x^2 - 5x + 1");
    Console.WriteLine("\n{0,-3} | {1,-10} | {2,-10} | {3,-11} | {4,-10} | {5,-10}",
        "#", "x_n", "f(x_n)", "f'(x_n)", "x_n+1", "epsilon_0");
    Console.WriteLine(new string('-', 68));

    do
    {
        x = x1;

        float fdeX=f(x);
        float fPrimaX = df(x);

        x1 = x - f(x) / df(x);
        i++;
        

    // Imprimir los valores de la iteración actual
    Console.WriteLine($"{i,-3} | {x, -8:F8} | {fdeX, -8:F8} | {fPrimaX, -8:F8} | {x1, -8:F8} |{epsilon, -10:F8}");
    } while (Math.Abs(x1 - x) > epsilon);

    Console.WriteLine("\nRaíz encontrada: ");
    return x1;
}
Console.WriteLine("Tarea 7: Newton Raphson en C#");
Console.WriteLine("Integrantes del equipo: ");
Console.WriteLine("Alan Bauza Alfonso.\nÁngel Andrés Hernández Lizardo. \nLuis Enrique Rodríguez Varela." 
    + "\nArturo Ardura Palacios. \nDilan Rubén Salcedo Rosado. \nVíctor Manuel Quiñones Gil.");
Console.WriteLine(NewtonRaphson(0, 0.001f));