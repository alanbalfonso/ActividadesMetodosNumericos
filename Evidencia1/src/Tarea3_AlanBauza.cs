class Tarea3_AlanBauza{
public static void Exec(){
    
Console.WriteLine("Tarea 3 por: Alan Bauza Alfonso");
Console.WriteLine("Solucion Exahustiva de Sistema de Ecuaciones");
Console.WriteLine("2x + 3y = 13 \n4x - y = 5");

double step = 1;
for (double x = -100; x < 100; x = x += step){
    for (double y = -100; y < 100; y = y += step){
        //if(13 == 2 * x + 3 * y  && 5 == 4 * x - y){
        //! si al restar menos la igualdad en la ecuacion y al comparar con 1 es menor entonces es correcto
        if(Math.Abs((2 * x + 3 * y) - 13) < 1 && Math.Abs((4 * x - y) - 5) < 1){
            Console.WriteLine("El resultado es: ");
            Console.WriteLine($"x = {x}");  
            Console.WriteLine($"y = {y}");
        break;
        }
    }
}
}
}
