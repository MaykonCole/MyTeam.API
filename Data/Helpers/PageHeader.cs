using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Helpers
{
    public class PageHeader
    {
        public int AtualPagina { get; set; }
        public int ItemsPorPagina { get; set; }
        public int TotalItems { get; set; }
        public int TotalPaginas { get; set; }

        public PageHeader(int atualPagina, int itemsPorPagina, int totalItems, int totalPaginas)
        {
            AtualPagina = atualPagina;
            ItemsPorPagina = itemsPorPagina;
            TotalItems = totalItems;
            TotalPaginas = totalPaginas;
        }
    }
}
