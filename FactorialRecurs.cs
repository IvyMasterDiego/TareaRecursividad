using System;

public class FactorialRecurs{
    public static void Main(){
        int num;
        Console.WriteLine("Introduzca un numero entero");

        num=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Su factorial es: {0}", Factorial(num));
    }

    public static long Factorial(int n){
        if(n==1){
            return n;
        }
        return n*Factorial(n-1);
    }
}