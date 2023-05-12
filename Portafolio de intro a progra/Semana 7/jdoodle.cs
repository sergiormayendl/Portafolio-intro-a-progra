//INTEGRANTE: Sergio Mayen
using System;

class Program
{
    static void Main() {
        double estatura = 0, promedio = 0;
        char fin;
        int cont = 0;
        double suma = 0;
        do{
            Console.WriteLine("Ingrese estatura: ");
            estatura = Convert.ToDouble(Console.ReadLine());
            cont++;
            suma = suma + estatura;
            
            Console.WriteLine("Desea Ingresart otra estatura? s = Sí, n = No");
            fin = Convert.ToChar(Console.ReadLine());
        }while (fin == 's');
        promedio = suma / cont;
        Console.WriteLine("El promedio de las estaturas es: " + promedio);
    }
}