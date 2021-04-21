using Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Time> Times { get; set; }
        public DbSet<Posicao> Posicoes { get; set; }
        public DbSet<PlayerPosicao> PlayersPosicoes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Relacionamento muitos para muitos
            builder.Entity<PlayerPosicao>()
                .HasKey(P => new { P.PlayerId, P.PosicaoId });

            builder.Entity<Posicao>()
                .HasData(new List<Posicao>()
                {
                    new Posicao(1, "Goleiro"),
                    new Posicao(2, "Lateral Direito"),
                    new Posicao(3, "Zagueiro"),
                    new Posicao(4, "Lateral Esquerdo"),
                    new Posicao(5, "Volante"),
                    new Posicao(6, "Meia Ligação"),
                    new Posicao(7, "Meia Atacante"),
                    new Posicao(8, "Ponta Esquerda"),
                    new Posicao(9, "Ponta Direita"),
                    new Posicao(10, "Segundo Atacante"),
                    new Posicao(11, "Centro Avante"),
                });

            builder.Entity<Time>()
               .HasData(new List<Time>()
               {
                   new Time (1, "Huntersx" , "link.huntersx.jpg", DateTime.Now, DateTime.Now),
                   new Time (2, "Bleuz" , "link.bleuz.jpg", DateTime.Now, DateTime.Now),
                   new Time (3, "Mastermaq" , "link.mastermaq.jpg", DateTime.Now, DateTime.Now),
               });

            builder.Entity<Player>()
               .HasData(new List<Player>()
               {
                   new Player (1, "Maykon", "Maykon1993", "31993712719", 13, DateTime.Now, DateTime.Now, 1),
                   new Player (2, "Samuel", "santacruzpe", "11978653211", 7, DateTime.Now, DateTime.Now, 1),
                   new Player (3, "Celio", "Celio_Shadow_14", "44967543245", 9, DateTime.Now, DateTime.Now, 1),


                   new Player (4, "Jose", "joselito1970", "31993122719",5, DateTime.Now, DateTime.Now, 2),
                   new Player (5, "Mauricio", "maumau", "11978653211", 6, DateTime.Now, DateTime.Now, 2),
                   new Player (6, "Fernando", "fernando123", "44967542145", 10, DateTime.Now, DateTime.Now, 2),

                   new Player (7, "Adam", "adao", "31993154719",2, DateTime.Now, DateTime.Now, 3),
                   new Player (8, "Emerson", "emer", "11978113211", 8, DateTime.Now, DateTime.Now, 3),
                   new Player (9, "Jullius", "cachaca", "44961242145", 3, DateTime.Now, DateTime.Now, 3),
               });

            builder.Entity<PlayerPosicao>()
              .HasData(new List<PlayerPosicao>()
              {
                  new PlayerPosicao(1, 7),
                  new PlayerPosicao(1, 5),
                  new PlayerPosicao(2, 6),
                  new PlayerPosicao(3, 11),
                  new PlayerPosicao(4, 3),
                  new PlayerPosicao(5, 2),
                  new PlayerPosicao(6, 5),
                  new PlayerPosicao(7, 9),
                  new PlayerPosicao(8, 10),
                  new PlayerPosicao(9, 1),
                  new PlayerPosicao(2, 7),
                  new PlayerPosicao(3, 7),

              });
        }
    }
}
