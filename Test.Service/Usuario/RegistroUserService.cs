using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Service.Usuario
{
    public class RegistroUserService
    {
        public static int Id { get; set; }

        public static string Login { get; set; }

        public static string Senha { get; set; }

        public static string Email { get; set; }

        public static DateTime DataCadastro { get; set; }

        public static DateTime DataAtualizacao { get; set; }

        public static bool ResponsavelTime { get; set; }


        public List<User> listaUser = new List<User>();

        public User usuario;


        public RegistroUserService()
        {
            Id = 1;
            Login = Faker.Name.FullName();
            Email = Faker.Internet.Email();
            Senha = Faker.RandomNumber.Next().ToString();

            for (int i = 0; i<10; i++)
            {
                var usuario = new User()
                {
                    Id = i + 1,
                    Login = Faker.Name.FullName(),
                    Email = Faker.Internet.Email(),
                    Senha = Faker.RandomNumber.Next().ToString(),
                    CriadoEm = DateTime.UtcNow,
                    AtualizadoEm = DateTime.UtcNow,
                    ResponsavelTime = Id > 6 ? true : false
                };

                listaUser.Add(usuario);
            }

            usuario = new User()
            {
                Id = Id,
                Login = Login,
                Senha = Senha,
                Email = Email,
                CriadoEm = DataCadastro,
                AtualizadoEm = DataAtualizacao,
                ResponsavelTime = ResponsavelTime
            };

        }
    }
}
