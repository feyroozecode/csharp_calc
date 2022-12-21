
namespace Operation {
class Operations {
    // add
    public static int Add(int a, int b){
        int result = 0;

        int fA = convertToInt(a); 
        int fB = convertToInt(b);

        result = fA+fB;

        return result;
    }

    public static int minus(int a, int b){
        int result = 0;
        
        int fA = convertToInt(a); 
        int fB = convertToInt(b);


        result = fA-fB;

        return result;
    }

    public static int multiply(int a, int b){

        int result = 0;
        
        int fA = convertToInt(a); 
        int fB = convertToInt(b);


        result = fA*fB;

        return result;
    }

    /*
      method for divide number a to number b
    */
    public static int divide(int a, int b){

        try
        {
            int result = 0;
        
            int fA = convertToInt(a); 
            int fB = convertToInt(b);

            result = fA/fB;

            return result;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Division par 0 impossible 😠 \n");
        }

        return 0;
    }

    public static int racineCarre(int a){
        int result = a ;

        return Convert.ToInt32(Math.Sqrt(a));
    }

    // calculates a entered inscruction with accepting add, minus, multiply and divide, e.g: (5+10-9*3/6)
    public static int complexCalc(String instruction){
        char[] allStrings = instruction.ToCharArray();

        return 0; // default value 
    }

     
     protected static int convertToInt(Object a){

        return Convert.ToInt32(a);
    }

}
}