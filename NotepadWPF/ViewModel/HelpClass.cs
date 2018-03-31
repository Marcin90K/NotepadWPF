using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NotepadWPF.ViewModel
{
    class HelpClass
    {
        public static void CallingPage()
        {
            //WebRequest webRequest = WebRequest.Create("https://github.com/Marcin90K");
            Process.Start("https://github.com/Marcin90K");
        }
    }
}
