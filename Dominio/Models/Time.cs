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

        public Time(int id, string nomeTime, string linkEscudo, DateTime dataCadastro, DateTime dataAtualizacao)
        {
            Id = id;
            NomeTime = nomeTime;
            LinkEscudo = linkEscudo;
            DataCadastro = dataCadastro;
            DataAtualizacao = dataAtualizacao;
        }

        public int Id { get; set; }
        public string NomeTime { get; set; }
        public string LinkEscudo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }

        public IEnumerable<Player> Players { get; set; }


    }
}
