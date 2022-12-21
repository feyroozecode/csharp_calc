
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
            Console.WriteLine("Veillez Choisir le type d'opération à faire : \n");
            Console.WriteLine(" \n1: Addition \n2: Soustraction \n3: Multiplication \nDivision \n, 0: Quitter le program . \n");
            
            calcType = Convert.ToInt32(Console.ReadLine());

            if(calcType == 1 ){
                Console.WriteLine("Additon \n");
                Console.WriteLine("Ajouter le 1er nombre : ");
                int a = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Ajouter le 2er nombre : ");
                int b = Convert.ToInt32(Console.ReadLine());

                int res = Fun.Fun.Add(a, b);
                Console.WriteLine("Le resultat de l'addition = " + res);
                boucle = false;

            } else if(calcType == 2){

            } else if(calcType == 3){

            } else if(calcType == 4){

            }

        }

    }

    public static bool Continuez(){
        bool enter;

        Console.WriteLine("\n Voulez vous continuez, (Y: & O) ?");
        enter = Convert.ToBoolean(Console.ReadLine());
        
        if(enter = )

    }

}
}