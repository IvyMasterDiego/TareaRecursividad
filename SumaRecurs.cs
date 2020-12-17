using System;

class Program{
    static void Main(){
        int n;
        Console.WriteLine("Natural Term: ");
        n=int.Parse(Console.ReadLine());
        Console.WriteLine("La suma de los numeros naturales es: "+ sumaRecursiva(n));
        Console.ReadLine();
    }
    static int sumaRecursiva(int n){
        if(n==1){
            return 1;
        }else{
            return n+sumaRecursiva(n-1);
        }
    }
}