using System;

namespace CSharpExercises{
    public class DataTypeExercises{
        public void ValueSum(){
        
            Console.WriteLine("Ingrese un valor a sumar:");
            string firstValue = Console.ReadLine();

            Console.WriteLine("Ingrese otro valor a sumar:");
            string secondValue = Console.ReadLine();
            
            int a = 0;
            bool couldParseA= Int32.TryParse(firstValue, out a);
            if (couldParseA){
                int b = 0;
                bool couldParseb= Int32.TryParse(secondValue, out b);

                if(couldParseb){
                    
                }
                Console.WriteLine("El resultado de la suma es: {0}", a + b);
            }else{
                Console.WriteLine("El primer valor no es admitido");

            }
        }
    }
}