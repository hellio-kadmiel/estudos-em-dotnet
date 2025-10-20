using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploProjeto.Models
{
    public class Curso
    {

        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }


        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }
        public int ContarAlunosMatriculados()
        {
            // Count vai contar a quantidade de alunos
            int quantidade = Alunos.Count;

            return quantidade;

        }
        public void ListarAlunos()

        {
            Console.WriteLine($"Alunos do curso de: {Nome}");

             
            for (int count = 0; count < Alunos.Count; count++)
            {
                //string texto = "N°" + count + " - " + Alunos[count].NomeCompleto;
                string texto = $"N°{count + 1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);


            }
           
    
       }

        


    }
}