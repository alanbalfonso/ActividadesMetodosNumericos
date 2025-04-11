using System;

namespace Secante {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Tarea 6: Secante en C#");
            Console.WriteLine("Integrantes del equipo: ");
            Console.WriteLine("Alan Bauza Alfonso.\nÁngel Andrés Hernández Lizardo. \nLuis Enrique Rodríguez Varela." 
                + "\nArturo Ardura Palacios. \nDilan Rubén Salcedo Rosado. \nVíctor Manuel Quiñones Gil.");

            double X1, Xu, Xr, Fx1, Fxu, Fxr, ErrorAbsoluto, ErrorRelativo, ErrorPorcentual, XrAnterior = 0;
            int i = 0;
            const int maxIteraciones = 100; // Límite máximo de iteraciones

            // Valores iniciales (ajusta estos valores para estar cerca de la raíz deseada)
            X1 = 0; 
            Xu = 1;   

            // Encabezado de la tabla
            Console.WriteLine("\n{0,-4} | {1,-8} | {2,-8} | {3,-8} | {4,-10} | {5,-10} | {6,-10} | {7,-10} | {8,-4}",
                            "#", "xi", "xu", "xr", "f(xi)", "f(xu)", "f(xr)", "Error Abs", "Error Rel (%)");
            Console.WriteLine(new string('-', 105));

            do {
                Fx1 = Funcion.EvaluarFuncion(X1);
                Fxu = Funcion.EvaluarFuncion(Xu);

                // Verificar si Fxu y Fx1 son iguales (evitar división por cero)
                if (Math.Abs(Fxu - Fx1) < 1e-10) {
                    Console.WriteLine("Error: División por cero. Fxu y Fx1 son iguales.");
                    return;
                }

                Xr = Funcion.calcularXr(Xu, Fxu, X1, Fx1);
                Fxr = Funcion.EvaluarFuncion(Xr);

                if (i == 0) {
                    ErrorAbsoluto = 1; // Valor provisional para la primera iteración
                } else {
                    ErrorAbsoluto = Math.Abs(Xr - XrAnterior);
                }

                ErrorRelativo = ErrorAbsoluto / Xr;
                ErrorPorcentual = ErrorRelativo * 100;

                // Imprimir los valores de la iteración actual
                Console.WriteLine($"{i + 1,-4} | {X1,-8:F6} | {Xu,-8:F6} | {Xr,-8:F6} | {Fx1,-10:F6} | {Fxu,-10:F6} | {Fxr,-10:F6} | {ErrorAbsoluto,-10:F6} | {ErrorPorcentual,-4:F2}%");

                // Actualizar X1 y Xu
                X1 = Xu;
                Xu = Xr;

                XrAnterior = Xr;
                i++;

                // Verificar si se excede el límite de iteraciones
                if (i > maxIteraciones) {
                    Console.WriteLine("Error: El método no converge después de " + maxIteraciones + " iteraciones.");
                    return;
                }
            } while (ErrorAbsoluto > 0.0001);            
            
            Console.WriteLine("\nX raiz: " + Xr);
            Console.WriteLine("Error Absoluto: " + ErrorAbsoluto);
            Console.WriteLine("Error Relativo: " + ErrorRelativo);
            Console.WriteLine("Error Porcentual: " + ErrorPorcentual + "%");
        }
    }

    class Funcion {
        public static double EvaluarFuncion(double x) {
            double a;
            a = (2 * (x * x) - 5 * (x) + 1);
            return a;
        }

        public static double calcularXr(double Xu, double Fxu, double X1, double Fx1) {
            double Xr;
            Xr = Xu - (Fxu * (Xu - X1)) / (Fxu - Fx1);
            return Xr;
        }
    }
}