using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace nuget.Models
{
    public class Venda
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataAtual { get; set; }
        public decimal? Desconto { get; set; }
    }
}