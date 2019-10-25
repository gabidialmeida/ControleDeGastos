using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeGastos.Models
{
    public class Ano
    {
        [Key]
        public int Id { get; set; }
        public int ano { get; set; }
    }
}
