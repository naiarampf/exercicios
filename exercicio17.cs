using System;

class Programa{
    public static void Main(string[] args){
        string nome;
        double salario, tempoEmpresa, reajuste;
        
        //Ler nome do funcionário
        Console.WriteLine("Digite o seu nome: ");
        nome = (Console.ReadLine());
   
         //Pedir seu salário
         Console.WriteLine("Digite o seu salário: ");
         salario = double.Parse(Console.ReadLine());

         //Pedir quanto tempo trabalha na empresa
        Console.WriteLine("Quanto tempo voce trabalha nesta empresa? ");
        tempoEmpresa = double.Parse(Console.ReadLine());

        //Calcular novo salário, reajustando salário
         if ( tempoEmpresa < 3 ){
            reajuste = (salario * 0.03);
            Console.WriteLine("Seu aumento vai ser de R$ " + reajuste);
            Console.WriteLine("Seu novo salário vai ser: R$ " + (reajuste + salario));
        
        } else if ( tempoEmpresa > 10){
            reajuste = (salario * 0.125);
            Console.WriteLine("Seu aumento vai ser de R$ " + reajuste);
            Console.WriteLine("Seu novo salário vai ser: R$ " + (reajuste + salario));
         } else {
            reajuste = (salario * 0.20);
            Console.WriteLine("Seu aumento vai ser de R$ " + reajuste);
            Console.WriteLine("Seu novo salário vai ser: R$ " + (reajuste + salario));
        
    }
    
            Console.WriteLine("Digite enter para sair...");
            Console.ReadLine();

    }
}