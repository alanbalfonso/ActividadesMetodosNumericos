//Actividad y tarea 2 por: Alan Bauza Alfonso
using System;

class Program{
    static void Main(string[] args){
        bool repetirPrograma = true;
        string nombre; 

        //Lectura de nombre
            Console.WriteLine("\nTecmicalculadora. \n");
            Console.WriteLine("Bienvenido a la Tecmicalculadora, por favor escribe tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("\nBienvenido: " + nombre);
            
        do{
            //Variables
            double numero1, numero2;
            double resultado;
            char opcion;

            //Funciones de calculadora
            Console.WriteLine("\nEscribe el primer numero a calcular: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ahora escribe el segundo numero a calcular: ");
            numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Muy bien. Ahora selecciona la operacion que quieres realizar con su inicial: ");
            Console.WriteLine("Suma (s). \nResta (r). \nMultiplicacion(m). \nDivision(d).");
            opcion = char.Parse(Console.ReadLine());
            
            switch(opcion){
                default: {
                    Console.WriteLine("\nSeleccion incorrecta. Repitiendo programa...");
                    break;
                }
                
                //Suma
                case ('s'):
                {
                    resultado = numero1 + numero2;
                    Console.WriteLine("\nSUMA: \n");
                    Console.WriteLine(numero1 + " + " + numero2 + " = " + resultado);
                    Console.WriteLine("La respuesta es: " + resultado + "\nDeseas realizar otra operacion? (s/n)");
                    char respuesta = char.Parse(Console.ReadLine());
                    switch (respuesta){
                        case 's': {
                            break;
                        }
                        case 'n': {
                            repetirPrograma = false;
                            Console.WriteLine("Gracias por utilizar este programa. Hasta la proxima!");
                            break;
                        }
                        default: {
                            Console.WriteLine("Opcion no valida. Inicializando de nuevo programa...");
                            break;
                        }
                    }
                    break;
                }

                //Resta
                case ('r'):
                {
                    resultado = numero1 - numero2;
                    Console.WriteLine("\nRESTA: \n");
                    Console.WriteLine(numero1 + " - " + numero2 + " = " + resultado);
                    Console.WriteLine("La respuesta es: " + resultado + "\nDeseas realizar otra operacion? (s/n)");
                    char respuesta = char.Parse(Console.ReadLine());
                    switch (respuesta){
                        case 's': {
                            break;
                        }
                        case 'n': {
                            repetirPrograma = false;
                            Console.WriteLine("Gracias por utilizar este programa. Hasta la proxima!");
                            break;
                        }
                        default: {
                            Console.WriteLine("Opcion no valida. Inicializando de nuevo el programa... \n");
                            break;
                        }
                    }
                    break;
                }

                //Multiplicacion
                case ('m'):
                {
                    resultado = numero1 * numero2;
                    Console.WriteLine("\nMULTIPLICACION: \n");
                    Console.WriteLine(numero1 + " X " + numero2 + " = " + resultado);
                    Console.WriteLine("La respuesta es: " + resultado + "\nDeseas realizar otra operacion? (s/n)");
                    char respuesta = char.Parse(Console.ReadLine());
                    switch (respuesta){
                        case 's': {
                            break;
                        }
                        case 'n': {
                            repetirPrograma = false;
                            Console.WriteLine("Gracias por utilizar este programa. Hasta la proxima!");
                            break;
                        }
                        default: {
                            Console.WriteLine("Opcion no valida. Inicializando de nuevo programa... \n");
                            break;
                        }
                    }
                    break;
                }

                //Division
                case ('d'):
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine("\nDIVISION: \n");
                    if(numero2 == 0){
                        Console.WriteLine("No se puede dividir entre cero. Inicializando de nuevo el programa... \n");
                        break;
                    }
                    Console.WriteLine(numero1 + " / " + numero2 + " = " + resultado);
                    Console.WriteLine("La respuesta es: " + resultado + "\nDeseas realizar otra operacion? (s/n)");
                    char respuesta = char.Parse(Console.ReadLine());
                    switch (respuesta){
                        case 's': {
                            break;
                        }
                        case 'n': {
                            repetirPrograma = false;
                            Console.WriteLine("Gracias por utilizar este programa. Hasta la proxima!");
                            break;
                        }
                        default: {
                            Console.WriteLine("Opcion no valida. Inicializando de nuevo el programa... \n");
                            break;
                        }
                    }
                    break;
                }
            }
        } while(repetirPrograma);
    }
}