
namespace Main.Calc{
class Calc{

    static int calcType;
    static String userName = "";
    static bool boucle = false;

    public static void start(){
        Console.WriteLine(" *********** Bonjour bienvenue sur la calculatrice Majic de Ahmad ************ \n ");
        
        Console.WriteLine("Enter votre nom :"); 
        userName = Console.ReadLine();

        Console.WriteLine("bonjour "+ userName);
    
        boucle = true;
        while(boucle == true){
            Console.WriteLine("Veillez Choisir le type d'opération à faire \n");
            Console.WriteLine(" 1: Addition \n2: Soustraction\n 3:Multiplication \n Division , 0: QUitter le program");
            
            calcType = Convert.ToInt32(Console.ReadLine());

            if(calcType == 1 ){

            } else if(calcType == 2){

            } else if(calcType == 3){

            } else if(calcType == 4){

            }
            
        }

    }

}
}