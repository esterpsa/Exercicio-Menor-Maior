using System;

namespace Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior =0, menor = 0;
            int [] numeros = new int [10];
        

            Console.WriteLine("Digite 10 números");
    

            for(var contador = 0; contador <=9; contador++){
                Console.WriteLine($"Digite o {contador+1}º número");
                numeros[contador] = int.Parse(Console.ReadLine());

            if(contador == 0){
                maior = numeros[contador];
                menor = numeros[contador];
            }
            if(numeros[contador] <= menor){
                menor = numeros[contador];
                }
            if (numeros[contador] >= maior){
                maior = numeros[contador];
                }
            }
            Console.WriteLine("O número maior é: "+maior);
            Console.WriteLine("O número menor é: "+menor);


            
           
        }
    }
}
