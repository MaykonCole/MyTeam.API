using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Helpers
{
    public class PageList<T> : List<T>
    {

        public int AtualPagina { get; set; }
        public int TotalPaginas { get; set; }
        public int TamanhoPagina { get; set; }
        public int ItemTotal { get; set; }

        public PageList(List<T> items, int count, int pageNumber, int pageSize)
        {
            ItemTotal = count;
            TamanhoPagina = pageSize;
            AtualPagina = pageNumber;
            //13 items sendo que a pgina suporta 5
            TotalPaginas = (int)Math.Ceiling(count / (double)pageSize);
            this.AddRange(items);

        }

        // Método que cria a Paginacao de acordo os atributos desta classe
        public static async Task<PageList<T>> CreateAsync(
            IQueryable<T> source, int pageNumber, int pageSize)
            
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PageList<T>(items, count, pageNumber, pageSize);
                
        }

    }
}
