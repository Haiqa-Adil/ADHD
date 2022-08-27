using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ADHD.UtilService
{
    public interface IFileService
    {
        bool CheckIfValidPdf(Stream stream);
        Stream ConvertExcelToPdf(Stream stream);
    }
}
