using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Hosting;
using WebApplication1.Shared.ViewModel;

namespace WebApplication1.Shared.Service
{
    public class ExcelService : IExcelService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ExcelService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public List<ExcelViewModel> GetDataList()
        {
            var path = Path.Combine(_hostingEnvironment.WebRootPath + @"\DataExcel.csv");
            var records = new List<ExcelViewModel>();

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
                PrepareHeaderForMatch = args => args.Header.ToLower(),

            };

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, config))
            {
                records = csv.GetRecords<ExcelViewModel>().ToList();
            }

            return records;
        }
    }
}
