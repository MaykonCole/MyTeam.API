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
                    new Posicao(1, "Goleiro", "GOL", true),
                    new Posicao(2, "Lateral Direito", "LD", true),
                    new Posicao(3, "Zagueiro", "ZC", true),
                    new Posicao(4, "Lateral Esquerdo", "LE", true),
                    new Posicao(5, "Volante", "VOL", true),
                    new Posicao(6, "Meia Ligação", "MLG", true),
                    new Posicao(7, "Meia Atacante", "MAT", true),
                    new Posicao(8, "Ponta Esquerda", "PTE", true),
                    new Posicao(9, "Ponta Direita", "PTD", true),
                    new Posicao(10, "Segundo Atacante", "SA", true),
                    new Posicao(11, "Centro Avante", "CA", true),
                    new Posicao(12, "Ala Direito", "ALD", false),
                    new Posicao(13, "Ala Esquerdo", "ALE", false),
                });

            builder.Entity<Time>()
               .HasData(new List<Time>()
               {
                   new Time (1, "Huntersx" , "link.huntersx.jpg", DateTime.Now,  DateTime.Parse("17/05/2020"), true),
                   new Time (2, "Bleuz" , "link.bleuz.jpg", DateTime.Now,  DateTime.Parse("08/01/2019"), true),
                   new Time (3, "Mastermaq" , "link.mastermaq.jpg", DateTime.Now, DateTime.Parse("13/01/2021"), false),
               });

            builder.Entity<Player>()
               .HasData(new List<Player>()
               {
                   new Player (1, "Maykon", "Maykon1993", "31993712719", 13, DateTime.Now, DateTime.Parse("01/05/1993"), "Jogador", false, 1),
                   new Player (2, "Samuel", "santacruzpe", "11978653211", 7, DateTime.Now, DateTime.Parse("13/02/2000"), "Jogador", true, 1),
                   new Player (3, "Celio", "Celio_Shadow_14", "44967543245", 9, DateTime.Now, DateTime.Parse("07/08/1989"), "DT", true, 1),


                   new Player (4, "Jose", "joselito1970", "31993122719",5, DateTime.Now, DateTime.Parse("18/01/1978"), "Jogador", true, 2),
                   new Player (5, "Mauricio", "maumau", "11978653211", 6, DateTime.Now, DateTime.Parse("28/05/1990"), "DT", true, 2),
                   new Player (6, "Fernando", "fernando123", "44967542145", 10, DateTime.Now, DateTime.Parse("24/01/1980"), "Jogador", false, 2),

                   new Player (7, "Adam", "adao", "31993154719",2, DateTime.Now,  DateTime.Parse("12/02/1994"), "DT", true, 3),
                   new Player (8, "Emerson", "emer", "11978113211", 8, DateTime.Now,  DateTime.Parse("06/08/1998"), "Jogador", false, 3),
                   new Player (9, "Jullius", "cachaca", "44961242145", 3, DateTime.Now,  DateTime.Parse("26/03/1988"), "Jogador", true, 3),
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
