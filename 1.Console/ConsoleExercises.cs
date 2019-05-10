using System;

namespace CSharpExercises{
    public class ConsoleExercises {
        public void AskAge(){
            Console.WriteLine("¿Cuántos años tenes?: ");
            string age = Console.ReadLine();
            Console.WriteLine("Wow, no pareces de " + age + " años");
            Console.WriteLine("¿Como te llamas?: ");
            string name = Console.ReadLine();
            Console.WriteLine("¿Y tu apellido?: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("¿Cual es tu documento?: ");
            string doc = Console.ReadLine();
            Console.WriteLine("Entonces te llamas " + name + " " + apellido + ", tenes " + age + " años y tu documento es " + doc);
            Console.ReadLine();

        }
    }
}