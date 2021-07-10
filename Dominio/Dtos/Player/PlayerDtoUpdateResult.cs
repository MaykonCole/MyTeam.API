using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Dtos.Player
{
    public class PlayerDtoUpdateResult
    {
        public int Id { get; set; }
        public string Psn { get; set; }
        public int Idade { get; set; }
        public string PerfilPlayer { get; set; }
        public DateTime AtualizadoEm { get; set; }
        public int? TimeId { get; set; }
        public Team Time { get; set; }
    }
}
