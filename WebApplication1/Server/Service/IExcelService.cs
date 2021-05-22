using System.Collections.Generic;
using WebApplication1.Shared.ViewModel;

namespace WebApplication1.Server.Service
{
    public interface IExcelService
    {
        List<ExcelViewModel> GetDataList();
    }
}
