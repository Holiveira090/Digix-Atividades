// using System;

// namespace ListaEncadeadaDelegate
// {
//     public class ListaEncadeadaDelegate
//     {
//         delegate void FuncaoDelegate(int valor);
//         static FuncaoDelegate? inicio = null;
//         static FuncaoDelegate CriarNo(int valor, FuncaoDelegate? proximo)
//         {
//             return v =>
//             {
//                 System.Console.WriteLine(valor);
//                 proximo?.Invoke(v);
//             };
//         }

        
//         public static void Main(string[] args)
//         {
            
//         }
//     }
// }
