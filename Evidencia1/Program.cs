namespace Evidencia1
{
    class Program
    {

        private class Menu {

            public static void ImprimirMenu() {
                Console.WriteLine("Evidencia 1 por: Alan Bauza Alfonso");
                Console.WriteLine("Elija una opción:");
                Console.WriteLine("1. Actividad y tarea (Primeros usos de C#)");
                Console.WriteLine("2. Actividad y tarea 2 (operaciones en C#)");
                Console.WriteLine("3. Actividad 3 (ecuaciones lineales, trigonometricos, sistemas exhaustivos)");
                Console.WriteLine("4. Tarea 3 (Sistema de ecuación personalizada)");
                Console.WriteLine("5. Actividad y tarea 4 (metodo de Gauss)");
                Console.WriteLine("0. Salir");
                Console.WriteLine("Elija una opción: ");
            }
        }
        // Método principal
        static void Main(string[] args)
        {

            int opcion = 0;
            do {
                Menu.ImprimirMenu();
                opcion = int.Parse(Console.ReadLine()!);
                switch(opcion) {

                    case 0:
                        Console.WriteLine("Gracias por utilizar este programa!");
                        break;

                    case 1:
                        ActTar1_AlanBauza.Exec();
                        break;
                    
                    case 2:
                        ActTar2_AlanBauza.Exec();
                        break;

                    case 3:
                        ActTar3_AlanBauza.Exec();
                        break;
                    case 4:
                        Tarea3_AlanBauza.Exec();
                        break;

                    case 5:
                        ActTar4_AlanBauza.Exec();
                        break;

                    default:
                        Console.WriteLine("Intente de nuevo.");
                        break;
                }

            }while(opcion != 0);

            
        }
    }

}