using System;
using System.Diagnostics.CodeAnalysis;

public class PrimeNumber
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Witaj w programie szukającym\nliczb pierwszych w danym przedziale");
        Console.WriteLine("Podaj wartość początkową przedziału...");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Podak wartość kończącą przedział...");
        int num2 = Convert.ToInt32(Console.ReadLine());
        

        for(int i = num1; i < num2; i++)
        {

            int ctr = 0;
            for(int j = 2; j < i; j++)
            {
                if(i!=j && i%j == 0)
                {
                    ctr++;
                    break;
                }
            }

            if(ctr==0 && i!=1)
            {
                Console.WriteLine(i);

            }

          
           
        }



    }

}

