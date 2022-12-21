using System;

namespace Main.fun.helper
{
    public class Helper
    {
         public static int convertType(Object a){
            try
            {   
               if(a.GetType() == typeof(string))
                 Helper.Afficher("La valeur entrer n'est pas un entier");
               else 
                return Convert.ToInt32(a);  
            }
            catch (System.Exception)
            {
                 Helper.Afficher("La valeur entrer n'est pas un entier");
            }

            return Convert.ToInt32(a);
        }

        public static String Afficher(String s){

            return s;
        }

    }
}