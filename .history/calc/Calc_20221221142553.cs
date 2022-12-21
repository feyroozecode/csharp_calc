
namespace 
class Program{

    static int type;
    static String userName = "";

    static void start(){
        Console.WriteLine(" *********** Bonjour bienvenue sur la calculatrice Majic de Ahmad ************ \n ");
        
        Console.WriteLine("Enter votre nom :"); 
        userName = Console.ReadLine();

        Console.WriteLine("bonjour "+ userName);
    }

}
