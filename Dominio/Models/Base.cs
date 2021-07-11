using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
   public abstract class Base
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime CriadoEm { get; set; } = DateTime.Now;
        public DateTime? AtualizadoEm { get; set; }
        public DateTime? ExcluidoEm { get; set; }
        [Required]
        public bool Ativo { get; set; }
    }
}
