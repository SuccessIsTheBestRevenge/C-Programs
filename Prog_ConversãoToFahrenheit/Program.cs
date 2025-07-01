/*Conversor de Temperatura

Enunciado:
Crie uma classe chamada ConversorTemperatura que tenha:
Um método para converter graus Celsius para Fahrenheit;
Um método para converter Fahrenheit para Celsius.

Regras:
Receba a temperatura digitada pelo usuário;
Realize a conversão;
Mostre o resultado formatado.*/


using System;

public class ConversorTemperatura
{
    public int Cel { get; set; }

    public ConversorTemperatura(int cel)
    {
        Cel = cel;
    }

    public void CalcularTemp()
    {
        double result = Cel * 9.0 / 5 + 32;
        Console.WriteLine($"A temperatura em Fahrenheit é: {result:F2}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite a temperatura em Celsius: ");
        int cel = int.Parse(Console.ReadLine());

        ConversorTemperatura conver = new ConversorTemperatura(cel);
        conver.CalcularTemp();
    }
}
