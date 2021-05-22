using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Client.ViewModel;

namespace WebApplication1.Client.Services
{
    public interface IClientExcelService
    {
        public Task<IEnumerable<ExcelViewModel>> GetDataAsync();
    }
}
