using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeGastos.Models
{
    [Table("Gastos")]
    public class Gastos
    {
        [Key]
        public int ID { get; set; }

        public string Descricao { get; set; }

        public double Valor { get; set; }

        [ForeignKey("MesID")]
        public Mes Mes { get; set; }

        public int Ano { get; set; }


        [ForeignKey("CategoriaID")]
        public Categoria Categoria { get; set; }
    }
}
