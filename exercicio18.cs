using System;

class Programa
{
    public static void Main(string[] args)
    {
        double linha1, linha2, linha3;

        Console.WriteLine("Digite a linha 1: ");
        linha1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a linha 2: ");
        linha2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a linha 3: ");
        linha3 = double.Parse(Console.ReadLine());

        if (((linha1 + linha2) > linha3) && ((linha1 + linha3) > linha2) && ((linha2 + linha3) > linha1)){
			Console.WriteLine("É possivel formar um triangulo. ");
		} else {
			Console.WriteLine("Não é possivel formar um triangulo. ");
		}
		if (linha1 == linha2 && linha1 == linha3){
			Console.WriteLine("É um triangulo equilatero.");
		} else {
			if((linha1 == linha2) || (linha1 == linha3) || (linha2 == linha3)){
				Console.WriteLine("É um triangulo Isósceles.");
			} else {
				Console.WriteLine("É um triangulo Escaleno.");
			}
		}

        Console.WriteLine("Tecle enter para sair...");
        Console.ReadLine();
    }
}