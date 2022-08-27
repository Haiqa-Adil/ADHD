using System;
using System.IO;
using System.Linq;
using System.Text;
using ADHD.UtilService;
using Spire.Xls;

namespace ADHD.Utils
{
    public class FileService : IFileService
    {
        public bool CheckIfValidPdf(Stream stream)
        {
            var pdfString = "%PDF-";
            var pdfBytes = Encoding.ASCII.GetBytes(pdfString);
            var len = pdfBytes.Length;
            var buf = new byte[len];
            var remaining = len;
            var pos = 0;

            stream.Position = 0;

            while (remaining > 0)
            {
                var amtRead = stream.Read(buf, pos, remaining);
                if (amtRead == 0) return false;
                remaining -= amtRead;
                pos += amtRead;
            }

            stream.Position = 0;

            return pdfBytes.SequenceEqual(buf);
        }

        public Stream ConvertExcelToPdf(Stream stream)
        {
            var pdfStream = new MemoryStream();
            if (stream.Length > 0)
            {
                stream.Position = 0;

                var chartBook = new Workbook();
                chartBook.LoadFromStream(stream);

                if (chartBook.Worksheets.Count == 0)
                    throw new Exception("No sheet present in workbook");

                var chartSheet = chartBook.Worksheets[0];
                chartSheet.PageSetup.FitToPagesWide = 1;
                chartSheet.PageSetup.FitToPagesTall = 0;


                chartSheet.SaveToPdfStream(pdfStream);
            }

            return pdfStream;
        }
    }
}
