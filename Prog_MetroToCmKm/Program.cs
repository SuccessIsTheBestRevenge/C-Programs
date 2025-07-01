
/*Conversor de Distâncias

Enunciado:
Crie uma classe chamada ConversorDistancia com:
Um método para converter metros para quilômetros;
Um método para converter metros para centímetros.

Regras:
Solicite do usuário a distância em metros;
Mostre os valores convertidos em km e cm.*/

public class ConversorDistancia
{
    double Metro { get; set; }



    public ConversorDistancia(double metro)
    {
        Metro = metro;
    }

    public void Converter()
    {
        double Km = Metro / 1000;
        double Cem = Metro * 100;
        Console.WriteLine($"A distancia em km é {Km} e a distancia em cm é {Cem}");
    }
}

public class Program
{
    static void Main()
    {
        Console.WriteLine("Insira o valor em metro: ");
        double Metro = double.Parse(Console.ReadLine());

        ConversorDistancia calcular1 = new ConversorDistancia(Metro);
        calcular1.Converter();

    }
}