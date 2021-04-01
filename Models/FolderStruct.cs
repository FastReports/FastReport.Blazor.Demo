using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastReport.Blazor.Demo.Models
{
    public class FolderStruct
    {
        /// <summary>
        /// List of reports in folder
        /// </summary>
        public List<ReportStruct> Reports { get; set; }

        public bool Hiden { get; set; } = true;

        /// <summary>
        /// Name of the folder
        /// </summary>
        public string FolderName { get; set; }

        /// <summary>
        /// Description of the folder
        /// </summary>
        public string Description { get; set; }


        public FolderStruct()
        {
            Reports = new List<ReportStruct>();
        }
    }
}
