using System;

class SumTail{
    public static void Main(){
        int []array={2,55,1,7};
        int size=array.Length;
        Console.WriteLine(arrSum(array,size,0));
    }

    static int arrSum(int []array,int size, int sum){
        if(size==0){
            return sum;
        }
        return arrSum(array,size-1,sum+array[size-1]);
    }
}