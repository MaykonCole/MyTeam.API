using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Helpers
{
    public static class DateTimeExtensions
    {

        public static int PegarIdadeAtual(this DateTime dateTime)
        {
            var dataAtual = DateTime.UtcNow;
            int idade = dataAtual.Year - dateTime.Year;

            if (dataAtual < dateTime.AddYears(idade))
                idade--;

            return idade;

        }
    }
}
