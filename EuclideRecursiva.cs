using System;

class Euclide{
    public static void Main(){
        int a=10,b=15,g;
        g=gcd(a,b);

        Console.WriteLine("GCD("+a+", "+b+")="+g);

        a=35;b=10;
        g=gcd(a,b);
        Console.WriteLine("GCD("+a+","+b+")="+g);

    }
    public static int gcd(int a, int b){
        if(a==0){
            return b;
        }
        return gcd(b%a,a);
    }
}