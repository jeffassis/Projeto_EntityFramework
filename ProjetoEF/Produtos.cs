using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEF
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Un { get; set; }
        public decimal Unitario { get; set; }
        public int IdSetor { get; set; }
    }
}
