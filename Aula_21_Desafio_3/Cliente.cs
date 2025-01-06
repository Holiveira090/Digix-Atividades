using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_21_OO
{
    public abstract class Cliente
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }

        // Para ocorrer composição o endereço deve ser instanciado no construtor
        public Cliente()
        {
            Endereco = new Endereco();
        }
        public Cliente(string nome, string rua, string cidade, Estado estado, int cep, string telefone, string cpf)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = new Endereco(rua, cidade, estado, cep);
            CPF = cpf;
        }
        public abstract string ConsultarFidelidade();
    }
    public class ClienteGold : Cliente
    {
        public double Desconto { get; set; }
        
        public override string ConsultarFidelidade()
        {
            return "Cliente Gold, desconto de 10%";
        }
    }
    public class ClientePlatinum : Cliente
    {
        public double Desconto { get; set; }

        public override string ConsultarFidelidade()
        {
            return "Cliente Platinum, desconto de 15%";
        }
    }
}