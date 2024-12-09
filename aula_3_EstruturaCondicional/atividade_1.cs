// using System;

// namespace Atividade_1
// {
//     class Atividade_1
//     {
//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Digite o valor de investimento inical: ");
//             double ValorI = double.Parse(Console.ReadLine());
//             System.Console.WriteLine("Qual investimento deseja aplicar?\n1-Poupança(3% ao ano)\n2-Renda Fixa(5% ao ano)\n3-Ações(10% ao ano com chance de perda de 5%)");
//             int investimento = int.Parse(Console.ReadLine());

//             if(investimento == 1)
//             {
//                 System.Console.WriteLine("Quantos anos deseja investir?");
//                 double anos = double.Parse(Console.ReadLine());
//                 double rendimento = (ValorI*0.03)*anos;
//                 double final = ValorI + rendimento;
//                 System.Console.WriteLine($"Se você insvestir {ValorI} em {anos} você tera {final}");
//             }
//             else if(investimento == 2)
//             {
//                 System.Console.WriteLine("Quantos anos deseja investir?");
//                 double anos = double.Parse(Console.ReadLine());
//                 double rendimento = (ValorI*0.05)*anos;
//                 double final = ValorI + rendimento;
//                 System.Console.WriteLine($"Se você insvestir {ValorI} em {anos} você tera {final}");
//             }
//             else if(investimento == 3)
//             {
//                 {
//                 System.Console.WriteLine("Quantos anos deseja investir?");
//                 double anos = double.Parse(Console.ReadLine());
//                 System.Console.WriteLine("Escolha o cenário:\n1-Ganho de 10% ao ano\n2-Perda de 5% ao ano");
//                 int cen = int.Parse(Console.ReadLine());

//                 double rendimento;
//                 if (cen == 1)
//                 {
//                     rendimento = (ValorI * 0.10) * anos;
//                 }
//                 else if (cen == 2)
//                 {
//                     rendimento = -(ValorI * 0.05) * anos;
//                 }
//                 else
//                 {
//                     System.Console.WriteLine("Cenário inválido.");
//                     return; 
//                 }

//                 double final = ValorI + rendimento;
//                 System.Console.WriteLine($"Se você investir {ValorI} em {anos} anos, você terá {final}");
//             }
//             }
//             else
//             {
//                 System.Console.WriteLine("Investimento invalido.");
//             }
//         }
//     }
// }
