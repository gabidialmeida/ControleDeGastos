using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeGastos.Models
{
    public class Conta
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Saldo { get; set; }
    }
}
