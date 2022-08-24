using System;

namespace md01_CadernoExercicios_04
{
    class Program
        /*4. Faça um algoritmo que leia uma temperatura em graus Celsius e apresente-a convertida em graus
        Fahrenheit. A fórmula de conversão é: F = (9 * C + 160) / 5,
        na qual F é a temperatura em Fahrenheit e C é a temperatura em Celsius
        */
    {
        static void Main(string[] args)
            
        {
            double c, f;
            Console.WriteLine("Digite a Temperatura Celsius para converte em Fahrenheit:");
            c = Convert.ToDouble(Console.ReadLine());
            f = (9 * c + 160) / 5;

            Console.WriteLine("\nTemperatura informada: {0}" , c.ToString("0.0") + "°C");
            Console.WriteLine("\nTemperatura convertida para Fahrenheit: {0}" , f.ToString("0.0") + "°F");
        }
    }
}
