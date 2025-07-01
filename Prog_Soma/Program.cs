using System;

namespace programa_Soma
{


    public class Soma
    {
        public double N1 { get; set; }
        public double N2 { get; set; }

        public Soma(double n1, double n2)
        {
            N1 = n1;
            N2 = n2;
        }
        public void Somar()
        {
            double resultado = N1 + N2;
            Console.WriteLine($"O resultado de {N1} e {N2} é igual a: {resultado}");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero:");
            double N1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            double N2 = double.Parse(Console.ReadLine());

            Soma SomarN3 = new Soma(N1, N2);
            SomarN3.Somar();
        }
    }

}
   