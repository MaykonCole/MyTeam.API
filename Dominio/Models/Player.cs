using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class Player
    {
        public Player(){}

        public Player(int id, string nome, string psn, string celular, int numero, DateTime dataCadastro, DateTime dataAtualizacao, int timeId)
        {
            Id = id;
            Nome = nome;
            Psn = psn;
            Celular = celular;
            Numero = numero;
            DataCadastro = dataCadastro;
            DataAtualizacao = dataAtualizacao;
            TimeId = timeId;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Psn { get; set; }
        public string Celular { get; set; }
        public int Numero { get; set; }

        public IEnumerable<PlayerPosicao> PlayerPosicoes { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public int? TimeId { get; set; }
        public Time Time { get; set; }

       
    }
}
