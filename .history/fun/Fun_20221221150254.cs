using System;

namespace Main.Fun {
class Fun {
    // add
    public static int Add(int a, int b){
        int result = 0;

        result = a+b;

        return result;
    }

    public static int minus(int a, int b){
        
        return a-b;
    }

    public static int multiply(int a, int b){

        return a*b;
    }

    public static int divide(int a, int b){

        try
        {
            return a/b;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Division \n");
        }

        return a/b;
    }
}
}