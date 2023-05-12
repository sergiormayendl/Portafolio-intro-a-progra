using System;

class Program
{
    static void Main() {
        float num;
        float suma = 0;
        float promedio;
        int i = 1;
        string entrada = "0";
        while (entrada == "0"){
            while (i <= 10){
                Console.WriteLine("Ingrese el número " + i + ": ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num != 0){
                    suma = suma + num;
                } else {
                    Console.WriteLine("El número ingresado es 0, comience de nuevo.");
                    i = 0;
                    suma = 0;
                }
                i++;
            }
            entrada = "1";
        }
        promedio = suma / 10;
        Console.WriteLine("El promedio es: " + promedio);
    }
}