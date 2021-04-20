using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class PlayerPosicao
    {
        public PlayerPosicao() {}


        public PlayerPosicao(int playerId, int posicaoId)
        {
            PlayerId = playerId;
            PosicaoId = posicaoId;
        }

        public int PlayerId { get; set; }
        public Player Player { get; set; }

        public int PosicaoId { get; set; }
        public Posicao Posicao { get; set; }
    }
}
