using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class Team : Base
    {
        public Team(){}

        public Team(int id, string nomeTime, string linkEscudo,  DateTime dataAtualizacao, DateTime dataFundacao, bool gamePes, bool ativo)
        {
            Id = id;
            NomeTime = nomeTime;
            LinkEscudo = linkEscudo;
            CriadoEm = dataAtualizacao;
            DataFundacao = dataFundacao;
            GamePes = gamePes;
            Ativo = ativo;
        }

        [StringLength(20, MinimumLength = 2, ErrorMessage = "Nome do Time deve conter no minimo 2 caracteres")]
        [Required]
        public string NomeTime { get; set; }
        public string? LinkEscudo { get; set; }
        public DateTime? DataFundacao { get; set; }
        public bool GamePes { get; set; }
        public IEnumerable<Player> Players { get; set; }
        public IEnumerable<Game> Games { get; set; }


    }
}
