using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploProjeto.Models
{
    public class Pessoa
    {
        public Pessoa(){}

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private int _idade;
            public string Nome
        {

            get{ return _nome.ToUpper(); }

            set
            {
                if (value == "")

                  throw new ArgumentNullException("nao pode ser vazio");
                    _nome = value;
            }
        }
            

            public int Idade {
                
                 get => _idade;


            set
            {
                if (_idade < 0)
                {
                    throw new ArgumentOutOfRangeException("A idade nao pode ser menor do que zero");
                } 
                _idade = value;
            }
            
             }
   public string Sobrenome { get; set; }
   public string NomeCompleto => $"{Nome} {Sobrenome}";

            public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto} e a idade {Idade}");
            
        }




    }
}