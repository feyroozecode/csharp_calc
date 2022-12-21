
namespace Main.Calc{
class Calc{

    static int calcType;
    static String userName = "";

    public static void start(){
        Console.WriteLine(" *********** Bonjour bienvenue sur la calculatrice Majic de Ahmad ************ \n ");
        
        Console.WriteLine("Enter votre nom :"); 
        userName = Console.ReadLine();

        Console.WriteLine("bonjour "+ userName);

        Console.WriteLine("Veillez Choisir le type d'opération à faire \n");
        Console.WriteLine("1: Addition \n  ");

    }

}
}