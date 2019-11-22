using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeGastos.Models
{
    [Table("Contas")]
    public class Conta
    {
        [Key]
        public int ID { get; set; }
        public string Descricao { get; set; } 

        public double Saldo { get; set; }
    }
}
