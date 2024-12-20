using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_20_OO_Relacoes.Exemplo;

namespace Aula_20_OO_Relacoes
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Relacionamento
            // Escola escola = new Escola("Jão");
            // Professor professor = new Professor("Maria");
            // escola.ContratarProfessor(professor);
            // escola.MostrarInfo();



            // Exemplo
            // System.Console.WriteLine("Herança");
            // PortaCozinha porta = new PortaCozinha("Branca", 1.5f, 2.5f, 10);
            // porta.Abrir();
            // porta.Fechar();
            // System.Console.WriteLine($"PortaCozinha: Cor: {porta.Cor}, largura: {porta.Largura}, altura: {porta.Altura} e peso: {porta.Peso}Kg\n");

            // System.Console.WriteLine("Agregação");
            // Cozinha cozinha = new Cozinha(true, 20);
            // cozinha.Entrar(porta);
            // System.Console.WriteLine();

            // System.Console.WriteLine("Composição");
            // PortaQuarto portaQuarto = new PortaQuarto("Marrom", 1.5f, 2.5f, 10);
            // Quarto quarto = new Quarto(true, 20);
            // System.Console.WriteLine($"Quarto: {quarto.PortaQuarto.Cor}\n");


            // System.Console.WriteLine("Associação simples");
            // PortaSala portaSala = new PortaSala("Azul", 1.5f, 2.5f, 10);
            // Sala sala = new Sala(portaSala, 20, portaQuarto);
            // sala.AbrirPortaAuxiliar();



            // Exercicio
            // Estado estado = new Estado("Mato Grosso do Sul", "MS");
            // Cidade cidade = new Cidade("Campo Grande", estado);
            // Endereco endereco = new Endereco("auaua", 40, "oioi", "1233456", cidade);
            // EquipeVenda Ambulantes = new EquipeVenda("Ambulante");
            // Vendedor vendedor = new Vendedor("Jão", new DateTime(2024, 12, 18), "12345678910", endereco, Ambulantes);
            // System.Console.WriteLine($"Nome: {vendedor.Nome}");
            // System.Console.WriteLine($"Nascimento: {vendedor.Nascimento}");
            // System.Console.WriteLine($"CPF: {vendedor.CPF}");
            // System.Console.WriteLine($"Rua: {vendedor.Endereco.Rua} \nNumero: {vendedor.Endereco.Numero} \nBairro: {vendedor.Endereco.Bairro} \nCEP: {vendedor.Endereco.CEP} \nCidade: {cidade.Nome} \nEstado: {estado.Sigla}");
            // System.Console.WriteLine($"Salario {vendedor.getSalario()}");


            // Exercicio 19-12
            Livro livro1 = new Livro("Teste", "teste", 1234, 3);
            Livro livro2 = new Livro("teste1", "teste1", 2345, 5);
            List<Livro> listaLivros = new List<Livro> { livro1, livro2 };
            CatalogoDeLivros catalogo = new CatalogoDeLivros(listaLivros);
            Biblioteca biblioteca = new Biblioteca("Biblioteca teste", "Rua teste 123", catalogo);
            List<Biblioteca> listaBibliotecas = new List<Biblioteca> {biblioteca};
            Funcionario funcionario = new Funcionario("jão", "12321312321","Bibliotecário", catalogo);
            funcionario.AdicionarLivro(new Livro("teste2", "teste2", 3456, 4));
            Leitor leitor = new Leitor("João", "123456789");
            leitor.ConsultarLivros(catalogo);
            leitor.PegarEmprestado(livro1);
            leitor.DevolverLivro(livro1);
            System.Console.WriteLine(biblioteca.Nome);



        }
    }
}