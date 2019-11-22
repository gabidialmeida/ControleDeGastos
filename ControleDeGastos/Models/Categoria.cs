using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeGastos.Models
{
    
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int ID{ get; set; }

        public string Descricao{ get; set; }

        public ICollection<Gastos> Gastos { get; set; }
    }
}
