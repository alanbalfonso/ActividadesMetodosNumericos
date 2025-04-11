using System;

class EliminacionGauss{
    static void Main(){
        Console.WriteLine("Código por: Alan Bauza Alfonso\n");

        // Definir diferentes sistemas de ecuaciones
        double[][,] ecuaciones = {
            new double[,] { { 2, -1, 1 }, { 3, 3, 9 }, { 3, 3, 5 } },
            new double[,] { { 1, 2, -1 }, { 3, -4, 2 }, { 2, 3, 3 } },
            new double[,] { { 4, -2, 1 }, { 1, 1, -3 }, { 2, -3, 1 } },
            new double[,] { { 5, 2, -3 }, { -3, -1, 2 }, { 2, 3, 1 } }
        };

        double[][] resultados = {
            new double[] { 8, 0, -6 },
            new double[] { 3, 2, 5 },
            new double[] { 2, -1, 3 },
            new double[] { 4, -2, 5 }
        };

        // Resolver cada sistema de ecuaciones
        for (int i = 0; i < ecuaciones.Length; i++) {
            Console.WriteLine($"Sistema {i + 1}:");
            double[] solucion = ResolverGauss(ecuaciones[i], resultados[i]);
            ImprimirSolucion(solucion);
            Console.WriteLine();
        }
    }

    static double[] ResolverGauss(double[,] a, double[] b) {
        int n = b.Length;

        for (int i = 0; i < n; i++) {
            for (int k = i + 1; k < n; k++) {
                double t = a[k, i] / a[i, i];
                for (int j = 0; j < n; j++) {
                    a[k, j] -= t * a[i, j];
                }
                b[k] -= t * b[i];
            }
        }

        double[] x = new double[n];
        for (int i = n - 1; i >= 0; i--) {
            x[i] = b[i];
            for (int j = i + 1; j < n; j++) {
                x[i] -= a[i, j] * x[j];
            }
            x[i] /= a[i, i];
        }
        return x;
    }

    static void ImprimirSolucion(double[] x) {
        Console.WriteLine("Soluciones:");
        for (int i = 0; i < x.Length; i++) {
            Console.WriteLine($"x{i + 1} = {x[i]:F4}");
        }
    }
}
