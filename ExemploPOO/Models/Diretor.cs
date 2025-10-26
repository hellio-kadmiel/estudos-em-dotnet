using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    // Classe selada
    public class Diretor : Professor

    {


         public override void Apresentar()
        {
            Console.WriteLine("diretor");
        }
        
    }
}