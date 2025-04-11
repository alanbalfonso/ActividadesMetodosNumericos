class ActTar3_AlanBauza{
    public static void Exec(){
        Console.WriteLine("Actividad 3 por: Alan Bauza Alfonso");
        Console.WriteLine("\n-----------------------------------------------");
        Console.WriteLine("Ecuaciones lineales");
        Console.WriteLine("Buscando 34 = 3x - 7 => Buscando x... ");
        Console.WriteLine("Solucion esperada: 13.66");

        double step = 0.01, sol1, sol2;

        for (double i = -100; i <= 100; i = i + step){
            // Console.WriteLine($"i => ${i} || 3 * i - 7 => ${3 * i - 7}"); Su razon es ver el avance
            sol1 = 3 * i - 7;
            sol2 = 3 * (i + step) - 7;

            // Comparacion de arriba para abajo entre valores y de abajo para arriba
            if((34 > sol1 && 34 < sol2) || (34 < sol1 && 34 > sol2)){
                Console.WriteLine($"La solucion es: ${i}");
                break;
            }
        }

        Console.WriteLine("\n-----------------------------------------------");
        Console.WriteLine("Ecuacion trigonometrica.");
        Console.WriteLine("0 = sin2(x/10) - cos(x/20)");
        double paso = 0.01, sol_1, sol_2 = 0;

        for (double i = -100; i <= 100; i = i + paso){
            sol_1 = Math.Pow(Math.Sin(i / 10), 2) - Math.Cos(i / 20);
            if(sol_1 * sol_2 < 0){
                Console.WriteLine($"La solucion es: ${i}");
                break;
            }
            sol_2 = sol_1;
        }

        Console.WriteLine("\n----------------------------------------------");
        Console.WriteLine("Solucion Exahustiva de Sistema de Ecuaciones");
        Console.WriteLine("3x + y = 1 \n7x + 2y = 4");

        double step2 = 1;
        for (double x = -100; x < 100; x = x + step2){
            for (double y = -100; y < 100; y = y + step2){
                if(1 == 3 * x + y && 4 == 7 * x + 2 * y){
                    Console.WriteLine("El resultado es: ");
                    Console.WriteLine($"x = {x}");
                    Console.WriteLine($"y = {y}");
                    break;
                }
            }
        }
        Console.WriteLine("Gracias por utilizar este programa! Vuelva pronto");
    }
}
