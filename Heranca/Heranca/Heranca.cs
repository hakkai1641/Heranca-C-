using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> Pessoas = new List<Pessoa>();
            Pessoa pessoa = new Pessoa() { Nome = "Fulano" };
            Pessoas.Add(pessoa);

            Professor professor = new Professor()
            {
                Nome = "Professor 1",
                MatriculadoProfessor = "123-ABC"
            };
            Pessoas.Add(professor);

            Aluno aluno = new Aluno()
            {
                Nome = "Aluno 1",
                MatriculodoAluno = "321-CBA"
            };
            Pessoas.Add(aluno);

            Pessoa outraPessoa = new Professor()
            {
                Nome = "Jhon Doe 26",
                MatriculadoProfessor = "321-TRC"
            };
            Pessoas.Add(outraPessoa);

            Professor outraPessoaProfessor = (Professor)outraPessoa;

            foreach (Pessoa p in Pessoas)
            {
                Console.WriteLine("Nome :" + p.Nome);
            }

            Console.ReadKey();
        }
    }

}
