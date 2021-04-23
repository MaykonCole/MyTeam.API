using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class Time
    {
        public Time(){}

        public Time(int id, string nomeTime, string linkEscudo,  DateTime dataAtualizacao, DateTime dataFundacao, bool ativo)
        {
            Id = id;
            NomeTime = nomeTime;
            LinkEscudo = linkEscudo;
            DataAtualizacao = dataAtualizacao;
            DataFundacao = dataFundacao;
            TimeAtivo = ativo;
        }

        public int Id { get; set; }
        public string NomeTime { get; set; }
        public string LinkEscudo { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime? DataAtualizacao { get; set; }

        public DateTime? DataFundacao { get; set; }

        public bool TimeAtivo { get; set; }

        public IEnumerable<Player> Players { get; set; }


    }
}
