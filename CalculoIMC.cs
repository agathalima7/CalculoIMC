using System;
class CalculoIMC {
  static void Main() {
  Console.Write("Peso: ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Altura: ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);
        Console.WriteLine($"IMC = {imc}");

        if (imc < 20)
        {
            Console.WriteLine("Abaixo do peso.");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Peso Ideal!");
        }
        else
        {
            Console.WriteLine("Acima do peso.");
        }
    }
}