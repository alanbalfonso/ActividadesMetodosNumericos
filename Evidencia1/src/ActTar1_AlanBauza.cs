class ActTar1_AlanBauza
{
    public static void Exec()
    {
        bool ejecutarDeNuevo;

        do
        {
            // Variables
            int entero = 9;
            double doble = 12.92;
            char caracter = 'D';
            string cadena = "String de ejemplo";
            bool booleano = true;

            // Impresiones
            Console.WriteLine("Variables declaradas:");
            Console.WriteLine("Entero: " + entero);
            Console.WriteLine("Doble: " + doble);
            Console.WriteLine("Carácter: " + caracter);
            Console.WriteLine("Cadena: " + cadena);
            Console.WriteLine("Booleano: " + booleano);

            // If y else
            if (entero > 3)
            {
                Console.WriteLine("\nEl valor del entero es mayor que 3.");
            } else {
                Console.WriteLine("\nEl valor del entero no es mayor que 3.");
            }

            // Metodo switch
            Console.WriteLine("\nSwitch:");
            switch (caracter)
            {
                case 'A':
                    Console.WriteLine("El carácter es 'A'.");
                    break;
                case 'B':
                    Console.WriteLine("El carácter es 'B'.");
                    break;
                default:
                    Console.WriteLine("El carácter no es 'A' ni 'B'.");
                    break;
            }

            // for para multiplicaciones
            Console.WriteLine("\nTabla de multiplicar del entero:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(entero + " x " + i + " = " + (entero * i));
            }

            // While que imprime impares
            Console.WriteLine("\nNúmeros impares menores que 10:");
            int numero = 1;
            while (numero < 10)
            {
                if (numero % 2 != 0)
                {
                    Console.WriteLine(numero);
                }
                numero++;
            }

            // Do-while para ejecucion
            Console.WriteLine("\n¿Deseas ejecutar el programa de nuevo? (s/n):");
            char respuesta = Console.ReadKey().KeyChar;
            ejecutarDeNuevo = respuesta == 's' || respuesta == 'S';
            Console.WriteLine();

        } while (ejecutarDeNuevo);

        Console.WriteLine("¡Gracias por usar este programa!");
    }
}
