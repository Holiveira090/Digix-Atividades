using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_07_01
{
    public interface IGerente
    {
        void Autorizar();
        bool ConcederAumento();
        bool AutorizarLicenca(Empregado empregado);
    }

    public class GerenteProducao : Empregado, IGerente
    {
        public GerenteProducao(string nome, double salario, int licencasPremioRecebidas, Regiao regiao, Licenca licenca, TiposEmpregados tiposEmpregados) : base(nome, salario, licencasPremioRecebidas, regiao, licenca, tiposEmpregados)
        {
        }
        public void Autorizar()
        {
            System.Console.WriteLine("Autorizado");
        }
        public bool ConcederAumento()
        {
            return true;
        }
        public bool AutorizarLicenca(Empregado empregado)
        {
            return true;
        }
    }

    public class GerenteVendas : Vendedor, IGerente
    {
        public GerenteVendas(string nome, double salario, int licencasPremioRecebidas, double comissao, Regiao regiao, Licenca licenca, TiposEmpregados tiposEmpregados) : base(nome, salario, licencasPremioRecebidas, comissao, regiao, licenca, tiposEmpregados)
        {
        }
        public void Autorizar()
        {
            System.Console.WriteLine("Autorizado");
        }
        public bool ConcederAumento()
        {
            return true;
        }
        public bool AutorizarLicenca(Empregado empregado)
        {
            return true;
        }

    }
}