using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;


namespace NotepadWPF.Model
{
    static class DataIO
    {

        public static string OpenFile(string path)
        {
            string text = File.ReadAllText(path);
            return text;
        }

        public static void SaveAsFile(string path, string text)
        {
            File.WriteAllText(path, text);
        }
    }
}
