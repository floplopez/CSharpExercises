﻿using System;

namespace CSharpExercises
{
    class Program
    {
        public void ask(){
            Console.WriteLine("cual ejecuta?: ");
            string respond = Console.ReadLine();
            if (respond='1'){
                static void Main(string[] args)
                {
                //1.
                ConsoleExercises console = new ConsoleExercises();
                console.AskAge();

                //Pedir nombre, apellido y documento e imprimir toda la información al final.

                //2.
                //VariableExercises variable = new VariableExercises();
                //variable.Concatenador();
                
                //3.
                DataTypeExercises dataType = new DataTypeExercises();
                dataType.ValueSum();
        }
    }
}
