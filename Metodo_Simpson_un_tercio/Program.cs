// Regla de Simpson 1/3 por: Alan Bauza Alfonso
using System;

class Program
{
    /// <summary>
    /// Función f(x)
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    static float F(float x)
    {
        return x * (float)Math.Sin(x);
    }

    /// <summary>
    /// Método para calcular la integral usando la regla de Simpson
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="n"></param>
    /// <returns></returns>
        static float Simpson(float a, float b, int n)
    {
        float h = (b - a) / n;
        float[] x = new float[n + 1];
        float sum = 0;

        x[0] = a;

        for (int j = 1; j <= n; j++)
        {
            x[j] = a + h * j;
        }

        for (int j = 1; j <= n / 2; j++)
        {
            sum += F(x[2 * j - 2]) + 4 * F(x[2 * j - 1]) + F(x[2 * j]);
        }

        return sum * h / 3;
    }

    static void Main()
    {
        float a = 1;  // Límite inferior
        float b = 4;  // Límite superior
        int n = 8;     // Número de intervalos (debe ser par)

        if (n % 2 == 0)
        {
            Console.WriteLine("Regla de Simpson 1/3 por: Alan Bauza Alfonso");
            Console.WriteLine("Resultado para la integral: ");
            Console.WriteLine(Simpson(a, b, n));
        }
        else
        {
            Console.WriteLine("n debería ser un número par");
        }
    }
}
