/*
    Por: Alan Bauza Alfonso
    Metodo de biseccion
*/
using System;

class Program
{
    /// <summary>
    /// Funcion f(x)
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    static double F(double x)
    {
        // Definir la función f(x) aquí
        return Math.Pow(2 * x, 2) - 5 * x + 1; // Ejemplo: f(x) = x^3 - x - 2
    }

    /// <summary>
    /// Funcion que calcula el metodo de biseccion
    /// </summary>
    /// <param name="xl"></param>
    /// <param name="xu"></param>
    /// <param name="es"></param>
    /// <param name="imax"></param>
    /// <param name="iter"></param>
    /// <param name="ea"></param>
    /// <returns></returns>
    static double Bisect(double xl, double xu, double es, int imax, out int iter, out double ea)
    {
        iter = 0;
        double xr = 0, xrold;
        ea = 100; // Inicializar error aproximado

        do
        {
            xrold = xr;
            xr = (xl + xu) / 2;
            iter++;

            if (xr != 0)
            {
                ea = Math.Abs((xr - xrold) / xr) * 100;
            }

            double test = F(xl) * F(xr);

            if (test < 0)
            {
                xu = xr;
            }
            else if (test > 0)
            {
                xl = xr;
            }
            else
            {
                ea = 0;
            }
        } while (ea >= es && iter < imax);

        return xr;
    }

    static void Main()
    {
        double xl = 0, xu = 1, es = 0.001;
        int imax = 100, iter;
        double ea;

        double root = Bisect(xl, xu, es, imax, out iter, out ea);

        Console.WriteLine($"Raíz aproximada: {root}");
        Console.WriteLine($"Iteraciones: {iter}");
        Console.WriteLine($"Error aproximado: {ea}%");
    }
}
