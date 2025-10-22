using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
namespace Desereliacao.Models
{
    public class Venda
    {
        public int Id { get; set; }
        // o meu objeto tem o nome preduto mas vai vir um mebro com o nome entre parentese 
        [JsonProperty("Nome_Produto")]    
        public string Produto { get; set; }
     public decimal Preco { get; set; }
      public DateTime DataVenda { get; set; }
    }
}