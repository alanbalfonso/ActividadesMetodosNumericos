using System;

class Program
{
    static void Main()
    {
        bool iteraciones;
        do
        {
            iteraciones = false;

            Console.WriteLine("Método del Trapecio por: Alan Bauza Alfonso");
            Console.WriteLine("Indica en cuántos trapecios deberá dividirse la función: ");
            int partesTrapecios = int.Parse(Console.ReadLine());

            Console.WriteLine($"Se dividirá en {partesTrapecios} trapecios.");
            Console.WriteLine("Ahora indica el límite inferior de la función: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Por último, escribe el límite superior de la función: ");
            double b = double.Parse(Console.ReadLine());

            double resultado = integralTrapecio(a, b, partesTrapecios);
            Console.WriteLine($"\nResultado final del área bajo la curva: {resultado:F4}");

        } while (iteraciones);
    }

    /// <summary>
    /// Formula para calcular el área acumulada entre cada trapecio
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="n"></param>
    /// <returns></returns>
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
    /// <summary>
    /// Función a calcular
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    static double funcionDeEquis(double x)
    {
        return -Math.Pow(x, 3) + 10 * Math.Pow(x, 2) + 8 * x + 10;
    }
}
