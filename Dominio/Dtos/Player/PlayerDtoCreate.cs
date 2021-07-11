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
        public string Nome { get; set; }
        public string Psn { get; set; }
        public string Celular { get; set; }
        public DateTime DataNascimento { get; set; }
        public string PosicaoP { get; set; }
        public string PerfilPlayer { get; set; }
        public DateTime CriadoEm { get; set; } = DateTime.Now;
        public int? TeamId { get; set; }
        public bool PlayerAtivo { get; set; } = true;
        //public Team Team { get; set; }
    }
}
