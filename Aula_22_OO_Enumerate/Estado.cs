namespace Aula_22_OO_Enumerate
{
    public enum Estado
    {
        SP,
        RJ,
        MG,
        BA,
    }
    public class ExtensaoEstado
    {
        public static string GetDescricao(Estado estado)
        {
            switch (estado)
            {
                case Estado.SP:
                    return "São Paulo";
                case Estado.RJ:
                    return "Rio de Janeiro";
                case Estado.MG:
                    return "Minas Gerais";
                case Estado.BA:
                    return "Bahia";
                default:
                    return "Estado não encontrado";
            }
        }
    }
    public class Regiao
    {
        public string[] Regioes = { "Norte", "Nordeste", "Sudeste", "Sul", "Centro-Oeste", };
        public string GetRegiao(Estado estado)
        {
            return estado switch 
            {
                // É possivel fazer um switch dentro do return porque o estado é um enum
                Estado.SP => Regioes[2],
                Estado.RJ => Regioes[2],
                Estado.MG => Regioes[2],
                Estado.BA => Regioes[1],
                _ => "Região não encontrada"
            };
        }
    }
}