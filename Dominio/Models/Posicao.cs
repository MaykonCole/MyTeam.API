using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class Posicao
    {
        public Posicao()
        {
        }

        public Posicao(int id, string nomePosicao, string nomeAbreviado, bool ativo)
        {
            Id = id;
            NomePosicao = nomePosicao;
            NomePosicao = nomeAbreviado;
            PosicaoAtiva = ativo;
        }

        public int Id { get; set; }
        public string NomePosicao { get; set; }
        public string NomeAbreviado { get; set; }
        public bool PosicaoAtiva { get; set; } 

        public IEnumerable<PlayerPosicao> PlayerPosicoes { get; set; }

    }
}
