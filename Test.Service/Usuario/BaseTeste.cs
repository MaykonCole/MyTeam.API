using Moq;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Service.Usuario
{
    public class BaseTeste : RegistroUserService
    {
        protected IUser _service;
        protected Mock<IUser> _serviceMock;
    }
}
