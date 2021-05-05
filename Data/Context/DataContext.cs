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

        public DbSet<Game> Games { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Player> Players { get; set; }

        public DbSet<PlayerApp> PlayersApp { get; set; }
        public DbSet<Team> Times { get; set; }



        public string dia(int x)
        {
            string dia = DateTime.Now.Day + x > 9 ? (DateTime.Now.Day + x).ToString() : "0" + (DateTime.Now.Day + x).ToString();
            return dia;
        }


        public string mes(int x)
        {
            string mes = DateTime.Now.Month + x > 9 ? (DateTime.Now.Month + x).ToString() : "0" + (DateTime.Now.Month + x).ToString();
            return mes;
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
          
            builder.Entity<Team>()
               .HasData(new List<Team>()
               {
                   new Team (1, "Huntersx" , "link.huntersx.jpg", DateTime.Now,  DateTime.Parse("17/05/2020"), true, true),
                   new Team (2, "Bleuz" , "link.bleuz.jpg", DateTime.Now,  DateTime.Parse("08/01/2019"), false, true),
                   new Team (3, "Mastermaq" , "link.mastermaq.jpg", DateTime.Now, DateTime.Parse("13/01/2021"), true, true),
                   new Team (4, "Cruzeiro" , "cruzeirocaiu.jpg", DateTime.Now, DateTime.Parse("13/01/1924"), false, true),
                   new Team (5, "Atletico" , "galaodamassa.jpg", DateTime.Now, DateTime.Parse("25/03/1908"), true, true),
               });

            builder.Entity<Game>()
              .HasData(new List<Game>()
              {
                   new Game (1, "Maykon", "Tombense", "31956785421", "Zezinho", "tomtom", "16:30", dia(1) + "-" + mes(0)+ "-" + DateTime.Now.Year, "Camp. Mineiro", 1),
                   new Game (2, "Isabela", "America", "31956784321", "Lisca", "liscadoid", "22:00", dia(0)+ "-" + mes(0) + "-" + DateTime.Now.Year, "Camp. Mineiro", 1),
                   new Game (3, "Ramiro", "Cruzeiro", "38991081254", "Felipe", "conception", "16:00", dia(0) + "-" + mes(0) + "-" + DateTime.Now.Year, "Camp. Mineiro", 1),


                    new Game (4, "Maykon", "Tombense", "31956785421", "Zezinho", "tomtom", "16:30", dia(4) + "-" + mes(0) + "-" + DateTime.Now.Year, "Camp. Mineiro", 2),
                   new Game (5, "Isabela", "America", "31956784321", "Lisca", "liscadoid", "22:00", dia(2) + "-" + mes(0) + "-" + DateTime.Now.Year, "Camp. Mineiro", 2),
                   new Game (6, "Ramiro", "Cruzeiro", "38991081254", "Felipe", "conception", "16:00", dia(2) + "-" + mes(0) + "-" + DateTime.Now.Year, "Camp. Mineiro", 2),

                   new Game (7, "Maykon", "Tombense", "31956785421", "Zezinho", "tomtom", "16:30", dia(1) + "-" + mes(0) + "-" + DateTime.Now.Year , "Camp. Mineiro", 3),
                   new Game (8, "Isabela", "America", "31956784321", "Lisca", "liscadoid", "22:00", dia(3) + "-" + mes(0) + "-" + DateTime.Now.Year, "Camp. Mineiro", 3),
                   new Game (9, "Ramiro", "Cruzeiro", "38991081254", "Felipe", "conception", "16:00", dia(3) + "-" + mes(0) + "-" + DateTime.Now.Year, "Camp. Mineiro", 3),


              });

            builder.Entity<User>()
           .HasData(new List<User>()
           {
                   new User (1, "Maykon1993", "teste@123", "maykontaiorpm@gmail.com" ),
                   new User (2, "belcastroic", "teste@123", "belbelm@gmail.com" ),
                   new User (3, "santacruzpe451", "teste@123", "santacruz@gmail.com" ),

           }) ;

            builder.Entity<Player>()
               .HasData(new List<Player>()
               {
                   new Player (1, "Maykon", "Maykon1993", "31993712719",  DateTime.Parse("01/05/1993"), "Jogador",  "Meia Atacante", "Volante", 13, "fotomaykon.png", 1),
                   new Player (2,  "Samuel", "santacruzpe", "11978653211",  DateTime.Parse("01/05/1993"), "Jogador",  "Meia Atacante", "Volante",7, "fotosamuel.png", 1),
                   new Player (3, "Celio", "Celio_Shadow_14", "44967543245",  DateTime.Parse("01/05/1993"), "DT", "Atacante", "Volante",99, "fotocelio.png", 1),


                   new Player (4, "Jose", "joselito1970", "31993122719",  DateTime.Parse("01/05/1993"), "DT",  "Atacante", "Volante",3, "fotojose.png", 2),
                   new Player (5, "Mauricio", "maumau", "11978653211",  DateTime.Parse("01/05/1993"), "Jogador", "Goleiro", "Volante",4, "fotomauricio.png", 2),
                   new Player (6, "Fernando", "fernando123", "44967542145",  DateTime.Parse("01/05/1993"), "Jogador",  "Meia Atacante", "Lateral",6, "fotofernando.png", 2),


                    new Player (7, "Adam", "adao", "31993154719",  DateTime.Parse("01/05/1993"), "Jogador", "Zagueiro", "Lateral",2, "fotoadam.png", 3),
                    new Player (8, "Emerson", "emer", "11978113211",  DateTime.Parse("01/05/1993"), "DT",  "Volante", "Atacante",5, "fotoemerson.png", 3),
                    new Player (9, "Jullius", "cachaca", "44961242145",  DateTime.Parse("01/05/1993"), "Jogador", "Atacante", "agueiro",9, "fotojullius.png", 3),



               });

         
        }
    }
}
