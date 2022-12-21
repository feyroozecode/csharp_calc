#nullable disable

using Main.fun.helper;
using Operation;

namespace Main.Calc{
class Calc{

    static Operation.Operations operations ;
    static List<int> validesRespons = new List<Int32>();
    static String calcStringType = "";
    static int calcType;
    static String userName = "";
    static bool boucle = false;

    public static void start(){
        
        operations = new Operation.Operations();

        validesRespons.Add(1);
        validesRespons.Add(2);
        validesRespons.Add(3);
        validesRespons.Add(4);
        validesRespons.Add(5);
        
        Console.WriteLine(" *********** Bonjour bienvenue sur la calculatrice Majic de Ahmad ************ \n ");
        
        Console.WriteLine("Enter votre nom :"); 
        userName = Console.ReadLine();  

        Console.WriteLine(" ****** bonjour "+ userName + " 😎, ravis de vous connaitre, je suis ahmadCalc une IA 🤖 qui fait ******");
    
        boucle = true;
        
        while(boucle == true){
            Console.WriteLine("Veillez Choisir le type d'opération à faire : \n");
            Console.WriteLine(" \n1: Addition \n2: Soustraction \n3: Multiplication \n4:Division \n5: Racine Carré \n0: Quitter le program . \n");
            
            calcStringType = Convert.ToString(Console.ReadLine());

            try
            {
                
                calcType = Convert.ToInt32(calcStringType);

                if(validesRespons.Contains(calcType) ){
                    if(calcType == validesRespons[0] ){
                        Console.WriteLine("Additon \n");
                        Console.WriteLine("Ajouter le 1er nombre : ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Ajouter le 2er nombre : ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        
                        int res = Operations.Add(a, b);
                        Console.WriteLine("Le resultat de l'addition = " + res + " 🥳");
                    
                        boucle = Continuez();
                    } else if(calcType == validesRespons[1]){
                        Console.WriteLine("Soustraction \n");
                        Console.WriteLine("Ajouter le 1er nombre : ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Ajouter le 2er nombre : ");
                        int b = Convert.ToInt32(Console.ReadLine());

                        int res = Operations.minus(a, b);
                        Console.WriteLine("Le resultat de la soustraction = " + res);

                        boucle = Continuez();
                    } else if(calcType == validesRespons[2]){
                        Console.WriteLine("Multiplication \n");
                        Console.WriteLine("Ajouter le 1er nombre : ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Ajouter le 2er nombre : ");
                        int b = Convert.ToInt32(Console.ReadLine());

                        int res = Operations.multiply(a, b);
                        Console.WriteLine("Le resultat de la multiplication = " + res);

                        boucle = Continuez();
                    } else if(calcType == validesRespons[3]){
                        Console.WriteLine("Division \n");
                        Console.WriteLine("Ajouter le 1er nombre : ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("Ajouter le 2er nombre : ");
                        int b = Convert.ToInt32(Console.ReadLine());

                        int res = Operations.divide(a, b);
                        if(res != 0){
                            Console.WriteLine("Le resultat de la division = " + res);
                        } else{
                            boucle = Continuez();
                        }
                        boucle = Continuez();
                    } if(calcType == validesRespons[4] ){
                        Console.WriteLine("Calcul de racine carré \n");
                        Console.WriteLine("Ajouter le nombre : ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        
                        int res = Operations.racineCarre(a);
                        Console.WriteLine("La racine carré de "+ a +" = " + res + " c'etait facile 😅 " + userName);
                    
                        boucle = Continuez();
                    }
                    else {
                        Helper.Afficher("Veillez entrer un nombre valide 🫣");
                       
                    }

                } else {
                    Console.WriteLine("--- Veillez entrer un nombre dans la liste de 1 jusqu'a 4 ! --- ");
                    boucle = Continuez();
                }

                
            }
            catch (System.Exception)
            {
                Console.WriteLine("Veillez entrer un entier");
                boucle = true;
            }

        }

    }

    public static bool Continuez(){
        String userRes ;

        Console.WriteLine("\n Voulez vous continuez, (OUI: o & NON: sur n'importe quel touche ) ?");
        userRes = Console.ReadLine();

        if(userRes == "o"){
            return true;
        } else {
            Console.WriteLine("\n Fin, au revoir "+ userName + "🥱");
            return false;
        }

    }

}
}