using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Helpers
{
    public class PageParams
    {
        public const int MaxPageSize = 20;
        public int PageNumber { get; set; } = 1;
        private int pageSize { get; set; } = 10;
        public int PageSize {
            get { return pageSize; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }

        public string Nome { get; set; } = string.Empty;
        public string Psn { get; set; } = string.Empty;

        //  public string PerfilPlayer { get; set; }
        public int? PlayerAtivo { get; set; } = null;

    }
}
