using Syncfusion.XlsIO;
using System.IO;
using ExcelChartType = Syncfusion.XlsIO.ExcelChartType;
using ExcelVersion = Syncfusion.XlsIO.ExcelVersion;
using System.Globalization;
using ADHD.Configuration.Chart;
using ADHD.UtilService;

namespace ADHD.UtilServices
{
    public class ChartService : IChartService
    {
        public Stream GenerateExcelChart(ChartVisit visit)
        {
            using var excelEngine = new ExcelEngine();
            var application = excelEngine.Excel;
            application.DefaultVersion = ExcelVersion.Excel2013;
            var workbook = application.Workbooks.Create(1);

            var sheet = workbook.Worksheets[0];

            sheet.Range["A1"].Text = "Types";

            int startCellLetterNumber = 'B';

            foreach (var v in visit.Visits)
            {
                sheet.Range[$"{(char)startCellLetterNumber}1"].Text = v.Title;
                startCellLetterNumber++;

                for (int i = 2, p = 0; p < v.Points.Count; i++, p++)
                {
                    for (int j = 2, t = 0; t < visit.Visits.Count; j++, t++)
                    {
                        sheet.Range[i, j].Number = visit.Visits[t].Points[p];
                    }
                }
            }

            for (int cell = 2, type = 0; type < visit.VisitedMonths.Count; cell++, type++)
            {
                sheet.Range[$"A{cell}"].Text =
                    CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(visit.VisitedMonths[type]);
            }

            var chart = sheet.Charts.Add();

            chart.ChartType = ExcelChartType.Line;
            chart.ChartTitle = visit.ChartTitle;

            startCellLetterNumber = 'B';

            foreach (var v in visit.Visits)
            {
                var item = chart.Series.Add(v.Title);
                item.Values =
                    sheet.Range[$"{(char)startCellLetterNumber}2:{(char)startCellLetterNumber}{v.Points.Count}"];
                item.CategoryLabels = sheet.Range[$"A2:A{v.Points.Count}"];

                startCellLetterNumber++;
            }

            var excelStream = new MemoryStream();
            workbook.SaveAs(excelStream);

            excelStream.Position = 0;

            return excelStream;
        }
    }
}
