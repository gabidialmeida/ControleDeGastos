using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeGastos.Models
{
    [Table("ItemOrcamento")]
    public class ItemOrcamento
    {
        [Key]
        public int ID { get; set; }
        
        [ForeignKey("CategoriaID")]
        public int Categoria { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        [ForeignKey("Orcamento")]
        public Orcamento Orcamentos { get; set; }
    }
}
