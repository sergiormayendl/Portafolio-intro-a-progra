using System;

class Program
{
    static void Main()
    {
        int contador = 0;
        int num = 2;
        
        while (contador < 10)
        {
            bool primo = true;
            
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    primo = false;
                    break;
                }
            }
            
            if (primo)
            {
                Console.WriteLine(num);
                contador++;
            }
            
            num++;
        }
    }
}