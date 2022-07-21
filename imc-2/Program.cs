using System;

namespace imc_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso: ");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            float altura = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();


            float imc = peso / (altura * altura);

            if (imc < 18.5)
                Console.WriteLine("Peso abaixo do normal.");

            else if ((imc > 18.5) && (imc < 25))
                Console.WriteLine("Peso padrão.");

            else if ((imc > 25) && (imc < 30))
                Console.WriteLine("Sobre peso");

            else if ((imc > 30) && (imc < 35))
                Console.WriteLine("Grau de obesidade I");

            else if ((imc > 35) && (imc < 40))
                Console.WriteLine("Grau de obesidade II");

            else if (imc > 40)
                Console.WriteLine("Grau de obesidade III");


        }
    }
}
