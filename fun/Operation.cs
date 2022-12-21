
namespace Main.Operation {
class Operations {
    // add
    public static int Add(int a, int b){
        int result = 0;

        int fA = convertType(a); 
        int fB = convertType(b);

        result = fA+fB;

        return result;
    }

    public static int minus(int a, int b){
        int result = 0;
        
        int fA = convertType(a); 
        int fB = convertType(b);


        result = fA-fB;

        return result;
    }

    public static int multiply(int a, int b){

        int result = 0;
        
        int fA = convertType(a); 
        int fB = convertType(b);


        result = fA*fB;

        return result;
    }

    public static int divide(int a, int b){

        try
        {
            int result = 0;
        
            int fA = convertType(a); 
            int fB = convertType(b);

            result = fA/fB;

            return result;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Division par 0 impossible \n");
        }

        return 0;
    }

    public static int racineCarre(int a){
        int result = a ;

        return Convert.ToInt32(Math.Sqrt(a));
    }

 protected static int convertType(Object a){

        return Convert.ToInt32(a);
    }

}
}