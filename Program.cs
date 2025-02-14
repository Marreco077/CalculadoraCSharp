﻿namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }

        static void Menu() {
            Console.WriteLine("");

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Divisão");
            Console.WriteLine("4- Multiplicação");
            Console.WriteLine("5- Sair");

            Console.WriteLine("------------");
            
            int resultado = int.Parse(Console.ReadLine());

            switch(resultado) {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Soma() {

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            
            float resultado = valor1 + valor2;

            Console.WriteLine($"O resultado da soma é: {resultado}");
            Menu();
        }      
   
        static void Subtracao() {
            Console.WriteLine("");

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 - valor2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Menu();
        }
        
        static void Divisao() {
            Console.WriteLine("");

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 / valor2;

            Console.WriteLine($"O resultado da divisão é: {resultado}"); 
            Menu();         
        }

        static void Multiplicacao() {
            Console.WriteLine("");

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 * valor2;

            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Menu();
        }
    }
}