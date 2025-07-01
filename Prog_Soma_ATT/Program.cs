public class Somadora
{
    public double N1 { get; set; }
    public double N2 { get; set; }

    public Somadora(double n1, double n2)
    {
        N1 = n1;
        N2 = n2;
    }

    public void ExibirResultado()
    {
        double resultado = N1 + N2;
        Console.WriteLine($"A soma de {N1} e {N2} é: {resultado}");
    }

    public void Iniciar()
    {
        Console.WriteLine("Digite seu numero");
        N1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite seu numero");
        N2 = double.Parse(Console.ReadLine());
    }
}

class Program
{
    public static void Main()
    {

        Somadora inicial = new Somadora(0, 0);


        inicial.Iniciar();

        inicial.ExibirResultado();

    }
}