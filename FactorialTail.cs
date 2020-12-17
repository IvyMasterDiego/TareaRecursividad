using System;

class FactorialTail{
    static public void Main(){
        Console.WriteLine(fact(8));
    }
    static int FactTR(int n, int a){
        if(n==0){
            return a;
        }
        return FactTR(n-1,n*a);
    }
    static int fact(int n){
        return FactTR(n,1);
    }
}