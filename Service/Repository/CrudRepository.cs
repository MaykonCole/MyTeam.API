using Data.Context;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Repository
{
    public class CrudRepository : ICrud
    {

        private readonly DataContext _context;
        public CrudRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entidade) where T : class
        {
            _context.Add(entidade);
        }

        public void Delete<T>(T entidade) where T : class
        {
            _context.Remove(entidade);
        }

        public void Update<T>(T entidade) where T : class
        {
            _context.Update(entidade);
        }

        public async Task<bool> SaveChangeAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
