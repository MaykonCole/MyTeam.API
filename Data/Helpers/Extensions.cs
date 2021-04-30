using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Helpers
{
   public static class Extensions
    {
        public static void AddPagination(this HttpResponse response,
            int atualPagina, int itemsPorPagina, int totalItems, int totalPaginas)
        {
            var paginationHeader = new PageHeader(
                atualPagina, itemsPorPagina, totalItems, totalPaginas
                );

            //Parametros Header camelCase
            var camelCaseFormatter = new JsonSerializerSettings();
            camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();

            response.Headers.Add("Paginacao", JsonConvert.SerializeObject(paginationHeader, camelCaseFormatter));

            response.Headers.Add("Acess-Control-Expose-Header", "Paginacao");

               
        }
    }
}
