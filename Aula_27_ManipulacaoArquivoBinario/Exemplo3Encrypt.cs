using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace Aula_27_ManipulacaoArquivoBinario
{
    // Exemplo de encriptar um arquivo txt
    public class Exemplo3Encrypt
    {
        static void Exe3(string[] args)
        {
            string original = "arquivo_original.txt";
            string encryptFile = "arquivo_encriptado.txt";
            string decryFile = "arquivo_desencriptado.txt";

            // Criar o arquivo de texto simples
            File.WriteAllText(original, "Este é o conteudo do arquivo original");

            System.Console.WriteLine("Arquivo original criado");

            string password = "minhasenhaSegura";

            // Metodo para encriptar o arquivo
            EncryptFile(original, encryptFile, password);
            System.Console.WriteLine("Arquivo encriptado");

            // Metodo para desencriptar o arquivo
            DecryptFile(encryptFile, decryFile, password);
            System.Console.WriteLine("Arquivo desencriptado");
        }

        static void EncryptFile(string original, string encryptFile, string password)
        {
            // O PadRight precisa ter pelo menos 32 caracteres
            byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32));

            // iv é referente o vetor de inicialização
            byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16));

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                // Abrir o arquivo original para leitura
                using (FileStream inputFileStream = new FileStream(original, FileMode.Open))
                {
                    // Criar o arquivo encriptado para escrita
                    using (FileStream outputFileStream = new FileStream(encryptFile, FileMode.Create))
                    {
                        // Criptografar o conteúdo do arquivo
                        using (CryptoStream cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            inputFileStream.CopyTo(cryptoStream); // Copiar os dados criptografados para o arquivo
                        }
                    }
                }
            }
        }

        static void DecryptFile(string encryptFile, string decryFile, string password)
        {
            // O PadRight precisa ter pelo menos 32 caracteres
            byte[] key = Encoding.UTF8.GetBytes(password.PadRight(32).Substring(0, 32));

            // iv é referente o vetor de inicialização
            byte[] iv = Encoding.UTF8.GetBytes(password.PadRight(16).Substring(0, 16));

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                // Abrir o arquivo encriptado para leitura
                using (FileStream inputFileStream = new FileStream(encryptFile, FileMode.Open))
                {
                    // Criar o arquivo desencriptado para escrita
                    using (FileStream outputFileStream = new FileStream(decryFile, FileMode.Create))
                    {
                        // Descriptografar o conteúdo do arquivo
                        using (CryptoStream cryptoStream = new CryptoStream(inputFileStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            cryptoStream.CopyTo(outputFileStream); // Copiar os dados descriptografados para o arquivo
                        }
                    }
                }
            }
        }
    }
}
