using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Dtos.Player
{
    public class PlayerDtoUpdate
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string PerfilPlayer { get; set; }

        public DateTime AtualizadoEm { get; set; } = DateTime.Now;

    }
}
