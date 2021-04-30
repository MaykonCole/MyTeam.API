using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class Team
    {
        public Team(){}

        public Team(int id, string nomeTime, string linkEscudo,  DateTime dataAtualizacao, DateTime dataFundacao, bool ativo)
        {
            Id = id;
            NomeTime = nomeTime;
            LinkEscudo = linkEscudo;
            DataAtualizacao = dataAtualizacao;
            DataFundacao = dataFundacao;
            TimeAtivo = ativo;
        }

        [Key]
        public int Id { get; set; }
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Nome do Time deve conter no minimo 2 caracteres")]
        [Required]
        public string NomeTime { get; set; }
        public string? LinkEscudo { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;

        public DateTime? DataFundacao { get; set; }

        public bool TimeAtivo { get; set; } = true;

        public IEnumerable<Player> Players { get; set; }

        public IEnumerable<Game> Games { get; set; }


    }
}
