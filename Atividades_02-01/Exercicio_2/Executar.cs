// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Atividades_02_01
// {
//     public class Executar
//     {
//         static void Main(string[] args)
//         {
//             // Criando os proprietários
//             Pessoa gilberto = new Pessoa("Gilberto Macedo", "123456789");
//             Pessoa bruna = new Pessoa("Bruna Ruas", "987654321");
//             Pessoa vivian = new Pessoa("Vivian Bicalho", "123789456");

//             // Criando algumas UnidadesResidenciais
//             List<UnidadeResidencial> unidades = new List<UnidadeResidencial>
//         {
//             new UnidadeResidencial(80, 3, 2, gilberto),
//             new UnidadeResidencial(80, 3, 2, bruna),
//             new UnidadeResidencial(80, 3, 2, vivian)
//         };

//             // Criando um Engenheiro
//             Engenheiro engenheiro = new Engenheiro("Carlos Silva", "123214123", 1234);

//             // Criando um Predio
//             Predio predio = new Predio(1500.5f, "Rua Principal, 123", engenheiro, unidades, "Edifício Central", 10, 4);

//             // Exibindo a descrição do imóvel do prédio
//             Console.WriteLine(predio.DescricaoDoImovel());

//             // Criando uma Casa (adicionando a parte da casa)
//             Casa casa = new Casa(300.0f, "Rua das Flores, 45", engenheiro, unidades, true);

//             System.Console.WriteLine("\n\nCasas:");
//             // Exibindo a descrição do imóvel da casa
//             Console.WriteLine("\n" + casa.DescricaoDoImovel());
//         }
//     }



// }