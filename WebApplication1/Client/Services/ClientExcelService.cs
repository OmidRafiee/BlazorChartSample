using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebApplication1.Client.Utils;
using WebApplication1.Client.ViewModel;

namespace WebApplication1.Client.Services
{
    public class ClientExcelService:IClientExcelService
    {
        private readonly HttpClient _httpClient;

        public ClientExcelService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<IEnumerable<ExcelViewModel>> GetDataAsync()
        {
            // How to url-encode query-string parameters properly
            var uri = new UriBuilderExt(new Uri(_httpClient.BaseAddress, "/api/getDataList"))
                //.AddParameter("checkInDate", $"{checkInDate:yyyy'-'MM'-'dd}")
                //.AddParameter("checkOutDate", $"{checkOutDate:yyyy'-'MM'-'dd}")
                .Uri;
            return _httpClient.GetFromJsonAsync<IEnumerable<ExcelViewModel>>(uri);
        }
    }
}
