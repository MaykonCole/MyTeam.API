using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Dtos.Player
{
    public class PlayerDtoCreateResult
    {
      
        public string Psn { get; set; }
       // public int Idade { get; set; }
        public string PerfilPlayer { get; set; }
        public DateTime CriadoEm { get; set; }
        public int? TeamId { get; set; }
      
    }
}
