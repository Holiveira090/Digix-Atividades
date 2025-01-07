using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_07_01
{
    public class Empregado : Pessoa
    {
        protected Regiao Regiao { get; set; }
        protected Licenca Licenca { get; set; }
        protected TiposEmpregados TiposEmpregados { get; set; }
        protected double Salario { get; set; }
        protected double SalarioMinimo = 240;
        protected int LicencasPremioRecebidas { get; set; }
        public Empregado(string nome, double salario, int licencasPremioRecebidas, Regiao regiao, Licenca licenca, TiposEmpregados tiposEmpregados) : base(nome)
        {
            Salario = salario;
            LicencasPremioRecebidas = licencasPremioRecebidas;
            Regiao = regiao;
            Licenca = licenca;
            TiposEmpregados = tiposEmpregados;
        }

        public virtual double GetSalario()
        {
            return Salario;
        }
        public int GetLicencasPremioRecebidas()
        {
            return LicencasPremioRecebidas;
        }
        public void setSalario(double novoSalario)
        {
            Salario = novoSalario;
        }
        public void setLicencasPremioRecebidas(int novaLicencasPremioRecebidas)
        {
            LicencasPremioRecebidas = novaLicencasPremioRecebidas;
        }
    }


    public class Vendedor : Empregado
    {
        protected Regiao Regiao { get; set; }
        protected double Comissao { get; set; }
        public Vendedor(string nome, double salario, int licencasPremioRecebidas, double comissao, Regiao regiao, Licenca licenca, TiposEmpregados tiposEmpregados) : base(nome, salario, licencasPremioRecebidas, regiao, licenca, tiposEmpregados)
        {
            Comissao = comissao;
        }
        public override double GetSalario()
        {
            return Salario + Comissao;
        }

    }
}