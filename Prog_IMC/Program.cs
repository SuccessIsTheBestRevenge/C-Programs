
/*Calculadora de IMC (Índice de Massa Corporal)

Enunciado:
Crie uma classe chamada CalculadoraIMC que tenha:
Uma propriedade Peso (double);
Uma propriedade Altura (double);
Um método CalcularIMC que retorna o IMC.
Fórmula do IMC:
IMC = Peso / (Altura × Altura)

Regras:
Solicite peso e altura do usuário;
Calcule e exiba o valor do IMC.*/

public class CalculadoraIMC
{
        double Peso { get; set;}
        double Altura { get; set; }

    public CalculadoraIMC(double peso,double altura)
    {
        Peso = peso;
        Altura = altura;
    }

    public void RealizarCalculo()
    {
        double IMC = Peso/ (Altura*Altura);
        Console.WriteLine($"O calculo do IMC é: {IMC} ");
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua altura: ");
        double altura = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite seu peso: ");
        double peso = double.Parse(Console.ReadLine());

        CalculadoraIMC calc1 = new CalculadoraIMC(peso, altura);
        calc1.RealizarCalculo();


    }
}