using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{

  
    public class Player
    {
        public Player(){}

        public Player(int id, string nome, string psn, string celular, DateTime dataNascimento, string perfilPlayer, string posicaoP, string posicaoA, int? numero, int? userId, int? timeId)
        {
            Id = id;
            Nome = nome;
            Psn = psn;
            Celular = celular;
            DataNascimento = dataNascimento;
            PerfilPlayer = perfilPlayer;
            PosicaoP = posicaoP;
            PosicaoA = posicaoA;
            Numero = numero;
            UserId = userId;
            TeamId = timeId;

        }

        [Key]
        public int Id { get; set; }
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Nome deve conter no minimo 2 caracteres")]
        [Required]
        public string Nome { get; set; }
        [StringLength(20, MinimumLength = 2, ErrorMessage = "PSN deve conter no minimo 2 caracteres")]
        [Required]
        public string Psn { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(20, MinimumLength = 7, ErrorMessage = "Celular deve ter no minimo 7 caracteres")]
        [Required]
        public string Celular { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [DataType(DataType.DateTime)]
        public DateTime? DataAtualizacao { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public string PerfilPlayer { get; set; }

        public bool PlayerAtivo { get; set; } = true;

        [StringLength(20, MinimumLength = 2, ErrorMessage = "Posição deve conter no minimo 2 caracteres")]
        [Required]
        public string PosicaoP { get; set; }
        public string? PosicaoA { get; set; }
        public int? Numero { get; set; }
        public string? FotoURL { get; set; }

        public int? UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public int? TeamId { get; set; }

        public virtual Team Team { get; set; }

       
    }
}
