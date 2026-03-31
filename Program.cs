using System;

class Program
{
    static void Main(string[] args)
    {
        // ler quantidade de números
        int quantidade = LerQuantidade();

        // criar lista
        List<double> numeros = LerNumeros(quantidade);

        // calcular soma
        double soma = CalcularSoma(numeros);

        // calcular média
        double media = CalcularMedia(soma, numeros.Count);

        // exibir resultado
        Console.WriteLine($"\nSoma: {soma}");
        Console.WriteLine($"Média: {media}");
    }

    // método para ler quantidade 
    static int LerQuantidade()
    {
        int quantidade;

        do
        {
            Console.WriteLine("Quantos números deseja informar? (3 a 10)");

        } while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade < 3 || quantidade > 10);

        return quantidade;
    }

    // método para ler os números
    static List<double> LerNumeros(int quantidade)
    {
        List<double> numeros = new List<double>();

        for (int i = 0; i < quantidade; i++)
        {
            double numero;

            Console.WriteLine($"Digite o número {i + 1}:");

            // validação
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Valor inválido, tente novamente:");
            }

            numeros.Add(numero);
        }

        return numeros;
    }

    // método para calcular soma 
    static double CalcularSoma(List<double> numeros)
    {
        double soma = 0;

        foreach (var n in numeros)
        {
            soma += n;
        }

        return soma;
    }

    // método para calcular média
    static double CalcularMedia(double soma, int quantidade)
    {
        return soma / quantidade;
    }
}
