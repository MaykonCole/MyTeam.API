using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class Game : Base
    {
        public Game()
        {

        }

        public Game(int id, string dtCadastro, string adversario, string telefoneAdversario, string dtAdversario, string psnAdversario, string horario, string data, string tipoJogo, int idTeam)
        {
            Id = id;
            this.dtCadastro = dtCadastro;
            this.adversario = adversario;
            this.telefoneAdversario = telefoneAdversario;
            this.dtAdversario = dtAdversario;
            this.psnAdversario = psnAdversario;
            this.horario = horario;
            this.data = data;
            this.tipoJogo = tipoJogo;
            TeamId = idTeam;
        }

        public  String? dtCadastro { get; set; }
        [StringLength (20, MinimumLength =2, ErrorMessage ="Nome do time adversário deve conter no minimo 2 caracteres")]
        [Required]
        public  String adversario { get; set; }
        public  String? telefoneAdversario { get; set; }
        public  String? dtAdversario { get; set; }

        [StringLength(20, MinimumLength = 2, ErrorMessage = "PSN do adversário deve conter no minimo 2 caracteres")]
        [Required]
        public  String psnAdversario { get; set; }
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Horário deve conter os 5 caracteres. Ex: 20:00")]
        [Required]
        public  String horario { get; set; }
        [Required]
        public String data { get; set; }
        [DataType(DataType.DateTime)]
        public  String? tipoJogo { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
