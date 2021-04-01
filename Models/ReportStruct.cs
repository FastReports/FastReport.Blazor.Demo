using FastReport;
using System.Drawing;
using System.IO;

namespace FastReport.Blazor.Demo.Models
{
    public class ReportStruct
    {
        /// <summary>
        /// Name of the report file with extension
        /// </summary>
        public string File { get; set; }

        /// <summary>
        /// Name of the report without extension
        /// </summary>
        public string FileName { get; set; }

    }
}
