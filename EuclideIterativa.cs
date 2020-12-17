using System;

class Euclide{
    static void Main(){
        Console.WriteLine("GCD of {0} and {1} is {2}",1,1,gcd(1,1));

        for(int x=1;x<36;x++){
            Console.WriteLine("GCD of {0} and {1} is {2}",36,x,gcd(36,x));
        }
        Console.Read();
    }
    static int gcd(int a,int b){
        while(b!=0){
            b=a%(a=b);
        }return a;
    }
}