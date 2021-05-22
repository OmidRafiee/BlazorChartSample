using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Shared.ViewModel;

namespace WebApplication1.Shared.Service
{
    public interface IExcelService
    {
        List<ExcelViewModel> GetDataList();
    }
}
