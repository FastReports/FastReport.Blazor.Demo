using FastReport;
using System.Drawing;
using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using FastReport.Blazor.Demo.Models;
using FastReport.Utils;

namespace FastReport.Blazor.Demo.Data
{
    public class ReportList
    {
        readonly string reportsFolder = Path.Combine(
                    Directory.GetCurrentDirectory(), Path.Combine("Reports"));

        public ReportList()
        {
            Folders = GetFolderList();
        }

        public IReadOnlyList<FolderStruct> Folders { get; }

        private List<FolderStruct> GetFolderList()
        {
            var folders = new List<FolderStruct>();
            try
            {
                XmlDocument reports = new XmlDocument();
                reports.Load(Path.Combine(reportsFolder, "reports.xml"));

                for (int i = 0; i < reports.Root.Count; i++)
                {
                    FolderStruct folder = new FolderStruct();
                    
                    XmlItem folderItem = reports.Root[i];
                    if (folderItem.GetProp("WinDemo") == "false")
                        continue;

                    string text = folderItem.GetProp("Name");

                    folder.FolderName = text;
                    folder.Description = folderItem.GetProp("Description");
                    for (int j = 0; j < folderItem.Count; j++)
                    {
                        ReportStruct report = new ReportStruct();

                        XmlItem reportItem = folderItem[j];
                        //if (reportItem.GetProp("WinDemo") == "false")
                        //    continue;

                        string file = reportItem.GetProp("File");

                        if (!File.Exists(Path.Combine(reportsFolder, file)))
                            continue;

                        string fileName = Path.GetFileNameWithoutExtension(file);

                        report.FileName = fileName;
                        report.File = file;
                        folder.Reports.Add(report);
                    }

                    folders.Add(folder);
                }
            }
            catch
            {

            }
            return folders;
        }

    }
}
