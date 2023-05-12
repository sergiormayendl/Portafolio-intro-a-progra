using System;

class Program
{
    static void Main() {
        Console.WriteLine("\nIngrese el valor del radio: ");
        double r = Convert.ToDouble(Console.ReadLine());
        
        double pi = 3.1416;
        
        double area= (r * r) * pi;
        
        Console.WriteLine("El área del círculo es: " + area);
    }
}