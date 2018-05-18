using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Aluno : Pessoa
    {
        public String MatriculodoAluno { get; set; }

        public override string ToString()
        {
            return "Nome do Aluno: " + this.Nome + "Matricula do Aluno: " + this.MatriculodoAluno;
        }
    }
}
