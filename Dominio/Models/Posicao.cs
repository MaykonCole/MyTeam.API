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

        public Posicao(int id, string nomePosicao)
        {
            Id = id;
            NomePosicao = nomePosicao;
        }

        public int Id { get; set; }
        public string NomePosicao { get; set; }
        public IEnumerable<PlayerPosicao> PlayerPosicoes { get; set; }

    }
}
