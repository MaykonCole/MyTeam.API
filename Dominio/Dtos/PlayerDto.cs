﻿using Dominio.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Dtos
{
    public class PlayerDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Psn { get; set; }

        public int Idade { get; set; }
     //   public IEnumerable<PlayerPosicao> PlayerPosicoes { get; set; }
        public string PerfilPlayer { get; set; }
        public int? TimeId { get; set; }

        [JsonIgnore]
        public Team Time { get; set; }
    }
}
