using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using GenerateCharts.Models;
using GenerateCharts.Services;

namespace ADHD.Controllers
{
    [ApiController]
    [Route("api/chart")]
    public class ChartController : ControllerBase
    {
        private readonly IChartService _chartService;
        private readonly IFileService _fileService;
        private readonly ILogger<ChartController> _logger;

        public ChartController(IChartService chartService, IFileService fileService, ILogger<ChartController> logger)
        {
            _chartService = chartService;
            _fileService = fileService;
            _logger = logger;
        }

        [HttpPost("generate")]
        public ActionResult<string> GenerateChart([FromBody] ChartVisit visit)
        {
            try
            {
                var excelStream = _chartService.GenerateExcelChart(visit);
                var pdfStream = _fileService.ConvertExcelToPdf(excelStream);

                var code = 500;
                var message = "Char not generated";

                if (pdfStream.Length > 0 && _fileService.CheckIfValidPdf(pdfStream))
                {
                    var fileStream = new FileStream("Chart.pdf", FileMode.Create, FileAccess.ReadWrite);

                    pdfStream.Position = 0;
                    pdfStream.CopyTo(fileStream);

                    code = 201;
                    message = "Chart generated successfully and saved as Pdf file";

                }
                else if (excelStream.Length > 0)
                {
                    var fileStream = new FileStream("Chart.xlsx", FileMode.Create, FileAccess.ReadWrite);

                    excelStream.Position = 0;
                    excelStream.CopyTo(fileStream);

                    code = 400;
                    message = "Chart not generated as Pdf, it is saved as excel file";
                }

                return StatusCode(code, message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }
    }
}
