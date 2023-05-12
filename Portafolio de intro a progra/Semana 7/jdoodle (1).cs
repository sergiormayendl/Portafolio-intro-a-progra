//INTEGRANTE: Sergio Mayen
using System;

class Program
{
    static void Main() {
        Random r = new Random();
        int num;
        int suma = 0;
        for (int i = 0; i<100; i++){
            num = r.Next(100);
            Console.WriteLine(num);
            suma = suma + num;
        }
        Console.WriteLine("La sumatoria es: " + suma);
    }
}