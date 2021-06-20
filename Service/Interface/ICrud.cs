using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interface
{
   public interface ICrud
    {
        void Add<T>(T entidade) where T : class;

        void Update<T>(T entidade) where T : class;

        void Delete<T>(T entidade) where T : class;

        Task<bool> SaveChangeAsync();
    }
}
