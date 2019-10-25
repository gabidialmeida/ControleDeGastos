using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeGastos.Models
{
    public class Despesa
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
