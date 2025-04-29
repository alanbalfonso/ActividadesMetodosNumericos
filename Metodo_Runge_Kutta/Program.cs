using System;

namespace RungeKutta {
    class Program {
        static void Main() {
            Console.WriteLine("Método de Runge-Kutta por: Alan Bauza Alfonso");

            Console.WriteLine("Introduce el primer valor de x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el valor límite de x (valor final):");
            double x_final = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el valor de h:");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el valor inicial de y:");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("\nResultados:");
            Console.WriteLine($"x = {x}, y = {y}");

            while (x < x_final) {
                double k1 = Funciones.FormulaK(x, y);
                double k2 = Funciones.FormulaK_Mitad(x, y, h, k1);
                double k3 = Funciones.FormulaK_Mitad(x, y, h, k2);
                double k4 = Funciones.FormulaK_Fin(x, y, h, k3);

                y = Funciones.FormulaParaY(y, h, k1, k2, k3, k4);
                x += h;

                // Redondeos
                x = Math.Round(x, 4);
                y = Math.Round(y, 4);

                Console.WriteLine($"x = {x}, y = {y}");
            }
        }

        class Funciones {
            static double Funcion(double x, double y) {
                return x + y;
            }

            /// <summary>
            /// Formula para y
            /// </summary>
            /// <param name="y_n"></param>
            /// <param name="h"></param>
            /// <param name="k1"></param>
            /// <param name="k2"></param>
            /// <param name="k3"></param>
            /// <param name="k4"></param>
            /// <returns></returns>
            public static double FormulaParaY(double y_n, double h, double k1, double k2, double k3, double k4) {
                return y_n + (h / 6) * (k1 + 2 * k2 + 2 * k3 + k4);
            }

            /// <summary>
            /// Formula para calcular K1
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <returns></returns>
            public static double FormulaK(double x, double y) {
                return Funcion(x, y);
            }

            /// <summary>
            /// Formula para calcular K2 y K3
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="h"></param>
            /// <param name="k_anterior"></param>
            /// <returns></returns>
            public static double FormulaK_Mitad(double x, double y, double h, double k_anterior) {
                return Funcion(x + h / 2, y + (h / 2) * k_anterior);
            }

            /// <summary>
            /// Formula para calcular K4
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="h"></param>
            /// <param name="k3"></param>
            /// <returns></returns>
            public static double FormulaK_Fin(double x, double y, double h, double k3) {
                return Funcion(x + h, y + h * k3);
            }
        }
    }
}
