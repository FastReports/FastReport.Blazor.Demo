using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using FastReport.Blazor.Demo.Models;
using FastReport.Blazor.Demo.Data;

namespace FastReport.Blazor.Demo.Shared
{
    public partial class NavMenu
    {
        private readonly List<FolderStruct> Groups;

        public NavMenu()
        {
            Groups = new ReportList().Folders;
            Groups.FirstOrDefault().Hiden = false;
        }

        private void FolderClick(FolderStruct folder)
        {
            folder.Hiden = !folder.Hiden;
        }

    }
}
