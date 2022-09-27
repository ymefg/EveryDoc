using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDoc
{
    internal static class Utils
    {
        public static Icon? GetIconFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                return Icon.ExtractAssociatedIcon(fileName);
            }
            else if (Directory.Exists(fileName))
            {
                return Icon.FromHandle(Properties.Resources.FolderClosed.GetHicon());
            }
            else return null;
        }
    }
}
