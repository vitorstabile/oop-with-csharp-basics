using System;
using System.Globalization;

namespace application
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("Entre com os Dados do Produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Dados do Produto: ");
            Console.WriteLine(p.Nome + ", $ " + (p.Preco).ToString("F2", CultureInfo.InvariantCulture) + ", " + p.Quantidade.ToString() + " unidades, Total: $ " + (p.ValorTotalEmEstoque()).ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quantidade);

            Console.WriteLine();
            Console.Write("Dados atualizados: ");
            Console.WriteLine(p.Nome + ", $ " + (p.Preco).ToString("F2", CultureInfo.InvariantCulture) + ", " + p.Quantidade.ToString() + " unidades, Total: $ " + (p.ValorTotalEmEstoque()).ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quantidade);

            Console.WriteLine();
            Console.Write("Dados atualizados: ");
            Console.WriteLine(p.Nome + ", $ " + (p.Preco).ToString("F2", CultureInfo.InvariantCulture) + ", " + p.Quantidade.ToString() + " unidades, Total: $ " + (p.ValorTotalEmEstoque()).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
