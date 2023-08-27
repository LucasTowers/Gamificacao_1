using Gamificacao_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamificacao_1.Models
{
    public class Venda
    {
        public int IdVenda { get; set; }
        public Cliente Cliente { get; set; }
        public List<Produto> ProdutosVendidos { get; set; }
        public DateTime DataVenda { get; set; }
        public double ValorTotalCompra { get; set; }
    }
}