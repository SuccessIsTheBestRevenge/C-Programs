/*Simulador de Depósito Bancário

Enunciado:
Crie uma classe chamada ContaBancaria que tenha:
Uma propriedade Saldo (double);
Um método Depositar que recebe um valor e adiciona ao saldo;
Um método ExibirSaldo que mostra o saldo atual.*/

public  class ConversorIdade
{
    double Idade { get; set; }
    
    public ConversorIdade(double idade)
    {
        Idade = idade;
    }

    public void Converter()
    {
       double NvIdade = Idade / 5;
        Console.WriteLine($"Sua idade é igual a {NvIdade:F10}");
    }
}

public class Program
{
    static void Main()
    {
        Console.WriteLine("Digite sua idade: ");
        double Idade = double.Parse(Console.ReadLine());


        ConversorIdade calcular = new ConversorIdade(Idade);
        calcular.Converter();
    }
}