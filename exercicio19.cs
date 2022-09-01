using System;

class Programa
{
    public static void Main(string[] args)
    {
        double valorImovel, salarioComprador, prazoMeses, valorPrestacao, limiteCredito;

        //Saber o valor do imóvel
        Console.WriteLine("Digite o valor do imóvel: ");
        valorImovel = double.Parse(Console.ReadLine());

        //Pedir salário comprador
        Console.WriteLine("Digite o valor do seu salário: ");
        salarioComprador = double.Parse(Console.ReadLine());

        //Pedir em quantos anos deseja pagar 
        Console.WriteLine("Digite em quantos meses voce pretende pagar: ");
        prazoMeses = double.Parse(Console.ReadLine());

        valorPrestacao = (valorImovel/prazoMeses);
        limiteCredito = salarioComprador * 0.30;
    
        //Calcular valor da prestação mensal
            if (valorPrestacao > limiteCredito){
                 Console.WriteLine("O seu emprestimo foi negado.");
            } else {
                 Console.WriteLine("O seu emprestimo foi aprovado.");
    }

         Console.WriteLine("Tecle enter para sair...");
         Console.ReadLine();
    }
}   