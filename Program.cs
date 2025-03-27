using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, (string Nome, double Preco)> produtos = new Dictionary<int, (string, double)>
    {
        { 1, ("X-Burguer", 15.00) },
        { 2, ("Refrigerante", 5.00) },
        { 3, ("Sorvete", 8.00) }
    };

    static Dictionary<int, int> pedido = new Dictionary<int, int>();

    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("\n==== Lanchonete Virtual ====");
            Console.WriteLine("1 - Listar produtos disponíveis");
            Console.WriteLine("2 - Adicionar produto ao pedido");
            Console.WriteLine("3 - Remover produto do pedido");
            Console.WriteLine("4 - Visualizar pedido atual");
            Console.WriteLine("5 - Finalizar pedido e sair");
            Console.Write("Escolha uma opção: ");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        ListarProdutos();
                        break;
                    case 2:
                        AdicionarProduto();
                        break;
                    case 3:
                        RemoverProduto();
                        break;
                    case 4:
                        VisualizarPedido();
                        break;
                    case 5:
                        FinalizarPedido();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número válido.");
            }
        } while (opcao != 5);
    }

    static void ListarProdutos()
    {
        Console.WriteLine("\nProdutos disponíveis:");
        foreach (var item in produtos)
        {
            Console.WriteLine($"{item.Key} - {item.Value.Nome} - R$ {item.Value.Preco:F2}");
        }
    }

    static void AdicionarProduto()
    {
        Console.Write("Digite o código do produto: ");
        if (int.TryParse(Console.ReadLine(), out int codigo) && produtos.ContainsKey(codigo))
        {
            Console.Write("Digite a quantidade: ");
            if (int.TryParse(Console.ReadLine(), out int quantidade) && quantidade > 0)
            {
                if (pedido.ContainsKey(codigo))
                    pedido[codigo] += quantidade;
                else
                    pedido[codigo] = quantidade;

                Console.WriteLine("Produto adicionado ao pedido!");
            }
            else
            {
                Console.WriteLine("Quantidade inválida.");
            }
        }
        else
        {
            Console.WriteLine("Código do produto inválido.");
        }
    }

    static void RemoverProduto()
    {
        Console.Write("Digite o código do produto a remover: ");
        if (int.TryParse(Console.ReadLine(), out int codigo) && pedido.ContainsKey(codigo))
        {
            Console.Write("Digite a quantidade a remover: ");
            if (int.TryParse(Console.ReadLine(), out int quantidade) && quantidade > 0)
            {
                if (pedido[codigo] > quantidade)
                {
                    pedido[codigo] -= quantidade;
                }
                else
                {
                    pedido.Remove(codigo);
                }
                Console.WriteLine("Produto removido do pedido!");
            }
            else
            {
                Console.WriteLine("Quantidade inválida.");
            }
        }
        else
        {
            Console.WriteLine("Produto não encontrado no pedido.");
        }
    }

    static void VisualizarPedido()
    {
        if (pedido.Count == 0)
        {
            Console.WriteLine("\nSeu pedido está vazio.");
            return;
        }

        Console.WriteLine("\nPedido atual:");
        double total = 0;
        int totalItens = 0;
        foreach (var item in pedido)
        {
            string nome = produtos[item.Key].Nome;
            double preco = produtos[item.Key].Preco;
            int quantidade = item.Value;
            double subtotal = preco * quantidade;
            total += subtotal;
            totalItens += quantidade;
            Console.WriteLine($"{nome} x {quantidade} = R$ {subtotal:F2}");
        }
        Console.WriteLine($"Total: R$ {total:F2}");
    }

    static void FinalizarPedido()
    {
        if (pedido.Count == 0)
        {
            Console.WriteLine("\nSeu pedido está vazio. Nada a finalizar.");
            return;
        }

        Console.WriteLine("\nResumo do Pedido:");
        double total = 0;
        int totalItens = 0;
        foreach (var item in pedido)
        {
            string nome = produtos[item.Key].Nome;
            double preco = produtos[item.Key].Preco;
            int quantidade = item.Value;
            double subtotal = preco * quantidade;
            total += subtotal;
            totalItens += quantidade;
            Console.WriteLine($"{nome} x {quantidade} = R$ {subtotal:F2}");
        }

        double desconto = 0;
        if (total > 100)
        {
            desconto = total * 0.10;
            Console.WriteLine("Desconto de 10% aplicado!");
        }
        else if (totalItens > 5)
        {
            Console.WriteLine("Frete grátis/brinde aplicado!");
        }

        double totalFinal = total - desconto;
        Console.WriteLine($"Valor Bruto: R$ {total:F2}");
        Console.WriteLine($"Desconto: R$ {desconto:F2}");
        Console.WriteLine($"Total a Pagar: R$ {totalFinal:F2}");
        Console.WriteLine("Obrigado por comprar conosco!");
    }
}
