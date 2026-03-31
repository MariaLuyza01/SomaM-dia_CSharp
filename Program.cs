
using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Quantos números você quer informar? (3 a 10)");
        //Console.ReadLine() Lê o que o usuario digitou. int.Parse: Transforma texto em número inteiro
        int quantidade = int.Parse(Console.ReadLine());

        //validar 

        // while: repete enquanto estiver errado
        while (quantidade < 3 || quantidade > 10)
        {
            Console.WriteLine("Digite um número entre 3 e 10:");
            quantidade = int.Parse(Console.ReadLine());
        }

            //Aqui é a  criação de um “espaço” pra guardar todos os números
            double[] numeros = new double[quantidade];

        //ler os numeros 
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Digite o número {i + 1}:");
            //cria um espaço para guardar o numero digitado
            double numero;
            //Enquanto o usuário digitar algo que NÃO é número, repete
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Valor inválido! Digite um número:");
            }

            numeros[i] = numero;
            //colocar o valor dentro do vetor
        }

        //soma
        double soma = 0;

        foreach (double n in numeros)
        {
            soma += n;
        }

        //média
        double media = soma / quantidade;

        //mostrar resultado
        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Média: {media}");
        
    }
}
