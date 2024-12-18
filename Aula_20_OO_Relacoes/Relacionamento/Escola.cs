using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_OO_Relacoes
{
    public class Escola
    {
        private Aluno estudante;
        private Professor professor;

        // Construtor da escola
        // que aqui vai mostrar a relação de composição
        public Escola(string nomeEstudante)
        {
            // Aqui q muda pois a escola vai ter o aluno como parte dela, então vai ser um relação
            estudante = new Aluno(nomeEstudante);
        }
        // Metodo para Agregação (que recebe de forma externa) o professor
        public void ContratarProfessor(Professor professor)
        {
            this.professor = professor;
        }
        // Mostrar informações
        public void MostrarInfo()
        {
            System.Console.WriteLine($"Nome do aluno: {estudante.Nome}");
            System.Console.WriteLine($"Nome do professor: {professor.Nome}");
            professor.ensinar();
        }
    }
}