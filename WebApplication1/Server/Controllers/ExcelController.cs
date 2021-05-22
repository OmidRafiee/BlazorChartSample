using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using WebApplication1.Server.Service;
using WebApplication1.Shared;
using WebApplication1.Shared.ViewModel;

namespace WebApplication1.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExcelController : ControllerBase
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IExcelService _excelService;

        private readonly ILogger<ExcelController> _logger;

        public ExcelController(ILogger<ExcelController> logger, IExcelService excelService, IWebHostEnvironment hostingEnvironment)
        {
            _logger = logger;
            _excelService = excelService;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public List<ExcelViewModel> GetDataList()
        {
            var model = _excelService.GetDataList();

            return model;
        }
    }
}
