using System;

public class Product
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public Product(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }


    public void Cadastrar()
    {
        Console.WriteLine("Digite o nome do produto:");
        Nome = Console.ReadLine();

        Console.WriteLine("Digite o preço do produto:");
        Preco = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade em estoque do produto:");
        Quantidade = int.Parse(Console.ReadLine());
    }

    public void AtualizarProduto()
    {
        Console.WriteLine("Digite a nova quantidade a adicionar:");
        int novaQuantidade = int.Parse(Console.ReadLine());
        Quantidade += novaQuantidade;
    }

    public void ExibirProduto()
    {
        Console.WriteLine("Dados do Produto");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: R${Preco:F2}");
        Console.WriteLine($"Quantidade: {Quantidade}");
    }
}

public class Program
{
    static void Main()
    {
        Product produto = new Product("", 0.0, 0);


        produto.Cadastrar();


        produto.AtualizarProduto();

        produto.ExibirProduto();
    }
}
