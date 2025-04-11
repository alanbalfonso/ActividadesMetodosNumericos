using System;

/// <summary>
/// Programa para calcular la integral definida de una función usando el método de rectángulos
/// </summary>
class Program{
    static void Main(){
        bool repeticion;

        do {
            repeticion = false;
            double baseRectangulo, alturaRectangulo, area = 0, x;

            Console.WriteLine("Tarea 9: Integral rectangular por: Alan Bauza Alfonso");
            Console.WriteLine("Indica en cuántos rectángulos deberá dividirse la función: ");
            int partesRectangulo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Se dividirá en {partesRectangulo} rectángulos.");
            Console.WriteLine("Ahora indica el límite inferior de la función: ");
            double limite_inf = double.Parse(Console.ReadLine());
            Console.WriteLine("Por último, escribe el límite superior de la función: ");
            double limite_sup = double.Parse(Console.ReadLine());

            // fórmula del método por rectángulos
            baseRectangulo = (limite_sup - limite_inf) / partesRectangulo;
            x = limite_inf;

            // encabezado de la tabla
            Console.WriteLine("\nTabla de valores de x");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("| Rectángulo | valor de x |    f(x)    |Área Rectángulo|Área Acumulada|");
            Console.WriteLine("-----------------------------------------------------------------------");

            int iteracion = 1;
            while (x < limite_sup)
            {
                // función f(x) = -x^3 + 10x^2 + 8x + 10
                alturaRectangulo = -Math.Pow(x, 3) + 10 * Math.Pow(x, 2) + 8 * x + 10;
                double areaRectangulo = baseRectangulo * alturaRectangulo;
                area += areaRectangulo;

                Console.WriteLine($"| {iteracion,10} | {x,10:F4} | {alturaRectangulo,10:F4} | {areaRectangulo,13:F4} | {area,12:F4} |");

                x += baseRectangulo;
                iteracion++;
            }

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine($"\nBase de cada rectángulo: {baseRectangulo:F4}");
            Console.WriteLine($"Área total aproximada (suma de las áreas de rectángulos): {area:F4}");

            Console.WriteLine("\n¿Desea calcular otra integral? (S/N)");
            string respuesta = Console.ReadLine().ToUpper();
            if (respuesta == "S")
                repeticion = true;

        } while (repeticion);

        Console.WriteLine("Programa finalizado. ¡Gracias por utilizar este programa!");
    }
}
