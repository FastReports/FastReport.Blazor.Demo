using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using FastReport.Web.Blazor;

namespace FastReport.Blazor.Demo.Pages
{
    public partial class Index
    {
        readonly string directory;
        const string DEFAULT_REPORT = "Simple List.frx";

        Report Report { get; set; }
        DataSet DataSet { get; }


        protected override void OnParametersSet()
        {
            base.OnParametersSet();

            Report = Report.FromFile(
                Path.Combine(
                    directory,
                    string.IsNullOrEmpty(ReportName) ? DEFAULT_REPORT : ReportName));

            // Registers the application dataset
            Report.RegisterData(DataSet, "NorthWind");

            UserWebReport = new WebReport
            {
                Report = Report
            };
        }

        public Index()
        {
            directory = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    Path.Combine("Reports"));

            DataSet = new DataSet();
            DataSet.ReadXml(Path.Combine(directory, "nwind.xml"));
        }

    }
}
