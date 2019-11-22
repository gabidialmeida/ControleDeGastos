using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeGastos.Models
{
    public class Orcamento
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("MesID")]
        public Mes Mes { get; set; }
        public int Ano { get; set; }
        public string Descricao { get; set; }

        public ICollection<ItemOrcamento> Item { get; set; }

    }
}
