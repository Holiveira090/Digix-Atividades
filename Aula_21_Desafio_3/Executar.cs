using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_21_OO;

namespace Aula_21_OO
{
    public class Executar
    {
        public static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Produto> produtos = new List<Produto>();
            List<Venda> vendas = new List<Venda>();
            Estoque estoque = new Estoque();

            int opcao;

            do
            {
                Console.Clear();//Limpa a tela
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Produto");
                Console.WriteLine("3 - Cadastrar Venda");
                Console.WriteLine("4 - Consultar Estoque");
                Console.WriteLine("5 - Gerar Relatório de Vendas");
                Console.WriteLine("6 - Sair");
                Console.Write("Digite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarCliente(clientes);
                        break;
                    case 2:
                        CadastrarProduto(produtos, estoque);
                        break;
                    case 3:
                        RegistrarVenda(clientes, produtos, vendas);
                        break;
                    case 4:
                        ConsultarEstoque(estoque);
                        break;
                    case 5:
                        GerarRelatorioVendas(vendas);
                        break;
                    case 6:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 6);
        }



        public static void CadastrarCliente(List<Cliente> clientes)
        {
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF do cliente: ");
            string cpf = Console.ReadLine();
            Console.Write("Digite o Telefone: ");
            string telefone = Console.ReadLine();
            Console.Write("Digite o Endereço: (Rua, Cidade, Estado, CEP)");
            string endereco = Console.ReadLine();

            System.Console.WriteLine("Digite o Estado: (sigla, ex: SP, MS, SC, ...)");
            string estado = Console.ReadLine();

            if (!Enum.TryParse(estado, out Estado estadoEnum))
            {   // tryParse converte a string em um enum
                System.Console.WriteLine("Estado inválido");
                return;
            }


            Cliente cliente = new ClienteGold
            {
                Nome = nome,
                CPF = cpf,
                Telefone = telefone,
                Endereco = new Endereco
                {
                    Rua = endereco.Split(", ")[0],
                    Cidade = endereco.Split(", ")[1],
                    Estado = estadoEnum,
                    CEP = int.Parse(endereco.Split(", ")[3])
                }
            };
        }

        private static void CadastrarProduto(List<Produto> produtos, Estoque estoque)
        {
            Console.Clear(); //Limpa a tela
            Console.WriteLine("===== Cadastro de Produto =====");
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite o preço de custo: ");
            double precoCusto = double.Parse(Console.ReadLine());
            // Console.Write("Digite o Apelido: ");
            // string apelido = Console.ReadLine();
            Console.Write("Digite se o produto é perecível: ");
            bool perecivel = bool.Parse(Console.ReadLine());
            Console.Write("Digite o preço final: ");
            double precoFinal = double.Parse(Console.ReadLine());
            Console.Write("Digite a data de validade: ");
            DateTime dataValidade = DateTime.Parse(Console.ReadLine());

            // Cadatrar do fornecedor
            Console.Write("=== Cadastro do Fornecedor ===");
            Console.Write("Digite o nome do fornecedor: ");
            string nomeFornecedor = Console.ReadLine();
            Console.Write("Digite o Endereço: (Rua, Cidade, Estado, CEP)");
            string endereco = Console.ReadLine();
            Console.Write("Digite o CNPJ: ");
            string cnpj = Console.ReadLine();
            Console.Write("Digite se o fornecedor é recorrente: ");
            bool recorrente = bool.Parse(Console.ReadLine());
            Console.Write("Digite o desconto: ");
            double desconto = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Estado: (sigla, ex: SP, MS, SC, ...)");
            string estado = Console.ReadLine();

            if (!Enum.TryParse(estado, out Estado estadoEnum))
            {   // tryParse converte a string em um enum
                System.Console.WriteLine("Estado inválido");
                return;
            }
            string apelido = ApelidosPorEstado[estadoEnum];

            Fornecedor fornecedor = new Fornecedor
            {
                Nome = nomeFornecedor,
                CNPJ = cnpj,
                Recorrente = recorrente,
                Desconto = desconto,
                Endereco = new Endereco
                {
                    Rua = endereco.Split(", ")[0],
                    Cidade = endereco.Split(", ")[1],
                    Estado = estadoEnum,
                    CEP = int.Parse(endereco.Split(", ")[3])
                }
            };

            Produto produto = new Produto
            {
                Nome = nome,
                Codigo = codigo,
                PrecoCusto = precoCusto,
                Apelido = apelido,
                Perecivel = perecivel,
                PrecoFinal = precoFinal,
                DataValidade = dataValidade,
                Fornecedor = fornecedor
            };
            produtos.Add(produto);
            estoque.Produtos = produtos.ToArray();
            System.Console.WriteLine("Produto cadastrado com sucesso!");
        }

        private static void RegistrarVenda(List<Cliente> clientes, List<Produto> produtos, List<Venda> vendas)
        {
            Console.Clear(); //Limpa a tela
            Console.WriteLine("===== Cadastro de Venda =====");
            Console.Write("Digite o cpf: ");
            string cpf = Console.ReadLine();

            Cliente cliente = clientes.Find(c => c.CPF == cpf);// Find é metodo que procura um elemento na lista

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado");
                return;
            }

            List<Produto> produtosVenda = new List<Produto>();
            while (true)
            {
                Console.Write("Digito o codigo do produto (0 para finalizar): ");
                int codigo = int.Parse(Console.ReadLine());

                if (codigo == 0) break;

                Produto produto = produtos.Find(p => p.Codigo == codigo);
                if (produto != null)
                {
                    produtosVenda.Add(produto);
                }
                else
                {
                    Console.WriteLine("Produto não encontrado");
                }
            }

            Venda venda = new Venda
            {
                Produtos = produtosVenda.ToArray(),
                Data = DateTime.Now,
                Cliente = cliente,
                FormaPagamento = "Cartão",
                Parcelas = 3,
                // ValorTotal = vendas.CalcularValorFinal();
            };
            venda.ValorTotal = venda.CalcularValorFinal(); // Aqui eu estou chamando o método CalcularValorFinal da classe Venda


            vendas.Add(venda);
            Console.WriteLine("Venda registrada com sucesso!");
        }

        private static void ConsultarEstoque(Estoque estoque)
        {
            Console.Clear();
            Console.WriteLine("===== Consulta de Estoque =====");
            if (estoque.Produtos != null)
            {
                for (int i = 0; i < estoque.Produtos.Length; i++)
                {
                    System.Console.WriteLine($"Nome: {estoque.Produtos[i].Nome}");
                    System.Console.WriteLine($"Codigo: {estoque.Produtos[i].Codigo}");
                    System.Console.WriteLine($"Preço de Custo: {estoque.Produtos[i].PrecoCusto:C}");
                    System.Console.WriteLine($"Apelido: {estoque.Produtos[i].Apelido}");
                }
            }
            else
            {
                System.Console.WriteLine("Estoque vazio");
            }
        }
        private static void GerarRelatorioVendas(List<Venda> vendas)
        {
            Console.Clear();
            Console.WriteLine("===== Relatório de Vendas =====");
            if (vendas != null)
            {
                foreach (var venda in vendas)
                {
                    System.Console.WriteLine($"Data: {venda.Data}");
                    System.Console.WriteLine($"Forma de Pagamento: {venda.FormaPagamento}");
                    System.Console.WriteLine($"Parcelas: {venda.Parcelas}");
                    System.Console.WriteLine($"Valor Total: {venda.ValorTotal:C}");
                }
            }
        }
        private static Dictionary<Estado, string> ApelidosPorEstado = new Dictionary<Estado, string>()
        {
            { Estado.SP, "Chipa" },
            { Estado.MS, "Chipa" },
            { Estado.MG, "Pão de queijo" },
            { Estado.RJ, "Bixcoito" },
            { Estado.BA, "Acarajé" },
        };
    }
}