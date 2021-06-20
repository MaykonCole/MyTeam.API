using Dominio.Models;
using Moq;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test.Service.Usuario
{
   public class TestService : BaseTeste
    {


        [Fact(DisplayName = " É possivel executar o método GET")]
        public async Task E_Possive_Executar_Metodo_GetUserPorId()
        {
            // ARRANGE -> É realizar a preparação do teste, pode ser inicializando objetos,
            // declarando variáreis que serão passadas como parâmetros para o método ou função testada, etc.
            _serviceMock = new Mock<IUser>();

          _serviceMock.Setup(u => u.BuscaUserPorId(Id)).ReturnsAsync(usuario);

            _service = _serviceMock.Object;

            // Action -> É quando o método/função testada é chamada e executada com os objetos ou parâmetros do passo anterior.
            var result = await _service.BuscaUserPorId(Id);

            // Assert -> É verificado se os resultados obtidos batem com os resultados esperado.
            Assert.NotNull(result);
            Assert.True(result.Id == Id);
            Assert.Equal(Login, result.Login);

        }

        [Fact(DisplayName = "É possivel executar o GetAll")]
        public async Task E_Possive_Executar_Metodo_GetAll()
        {
            _serviceMock = new Mock<IUser>();

            _serviceMock.Setup(u => u.BuscaUsers()).ReturnsAsync(listaUser);

            _service = _serviceMock.Object;

            var result = await _service.BuscaUsers();

            Assert.NotNull(result);
            Assert.False(result.Count() == 0);
            Assert.True(result.Count() == 10);

        }
    }
}
