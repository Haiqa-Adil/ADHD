using System.IO;
using ADHD.Configuration.Chart;

namespace ADHD.UtilService
{
    public interface IChartService
    {
        Stream GenerateExcelChart(ChartVisit visit);
    }
}
