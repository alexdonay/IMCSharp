namespace CSharp;
using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Pessoa alexsander = new Pessoa("Alexsander", 20, 123456789);
            
            alexsander.altura = 1.90;
            alexsander.peso = 65.0;
            Console.WriteLine("Nome: " + alexsander.nome);
            Console.WriteLine("Idade: " + alexsander.idade);
            Console.WriteLine("peso " + alexsander.peso + " Altura " + alexsander.altura + " IMC:" + alexsander.imc());  
            
            if(alexsander.pesoIdeal()>alexsander.peso){
                Console.WriteLine("Você está Abaixo do peso");
                Console.WriteLine("Faltou " + (alexsander.pesoIdeal()-alexsander.peso));
            }
            else{
                Console.WriteLine("Você está Acima do peso");
                Console.WriteLine("Excedeu " + (alexsander.peso-alexsander.pesoIdeal()));
            }
            Console.WriteLine("Peso ideal " + alexsander.pesoIdeal());  
            
        }
    }

