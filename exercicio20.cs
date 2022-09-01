using System;

class Programa{
    public static void Main(string[] args){

        double altura, peso, IMC;

         //Pedir a altura do usuário
        Console.WriteLine("Digite a sua altura: ");
        altura = double.Parse(Console.ReadLine());

        //Pedir peso do usuário
         Console.WriteLine("Digite o seu peso: ");
        peso = double.Parse(Console.ReadLine());

        IMC = peso /(altura * altura);

		if(IMC <= 18.5){
            Console.WriteLine("IMC: " + IMC);
			Console.WriteLine("Abaixo do peso.");
		} else if( IMC > 18.5 && (IMC <= 25)){
            Console.WriteLine("IMC: " + IMC);
			Console.WriteLine("Peso ideal.");
		} else if( IMC > 25 && (IMC <= 30)){
            Console.WriteLine("IMC: " + IMC);
			Console.WriteLine("Sobrepeso.");
		} else if( IMC > 30 && (IMC <= 40)){
            Console.WriteLine("IMC: " + IMC);
			Console.WriteLine("Obesidade.");
		} else if( IMC > 40){
            Console.WriteLine("IMC: " + IMC);
			Console.WriteLine("Obesidade Mórbida.");
		}
	
        Console.WriteLine("Digite enter para sair...");
        Console.ReadLine();

    }
}