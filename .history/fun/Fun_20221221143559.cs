using System;

namespace Main.Fun {
class Fun {
    // add
    public static int Add(int a, int b){
        Console.WriteLine("Additon \n");
        
        Console.WriteLine("Ajouter le 1er nombre ");
        a = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Ajouter le 2er nombre ");
        b = Convert.ToInt32(Console.ReadLine());

        if(a || b )
    }

    public static int minus(int a, int b){

        return a-b;
    }

    public static int multiply(int a, int b){

        return a*b;
    }

    public static int divide(int a, int b){

        return a/b;
    }
}
}