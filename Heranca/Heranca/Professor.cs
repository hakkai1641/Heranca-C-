using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Professor : Pessoa
    {
        public String MatriculadoProfessor { get; set; }


        public override string ToString()
        {
            return "Nome do Professor: " + this.Nome + "Matricula do Professor: " + this.MatriculadoProfessor;
        }
    }
}
