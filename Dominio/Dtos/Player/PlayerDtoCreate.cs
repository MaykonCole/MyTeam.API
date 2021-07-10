using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Dtos.Player
{
    public class PlayerDtoCreate
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Psn { get; set; }
        public int Idade { get; set; }
        public string PerfilPlayer { get; set; }
        public DateTime CriadooEm { get; set; } = DateTime.Now;
        public int? TeamId { get; set; }
        public Team Team { get; set; }
    }
}
