using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDoc
{
    public class FileInfoRow
    {
        public int ID { get; set; }
        public string Alias { get; set; }
        public string FileName { get; set; }
        public string[] Tags { get; set; }
        public string Remark { get; set; }
        public FileInfo? FileInfo { get; set; }

        public FileInfoRow(int iD, string alias, string fileName, string[] tags, string remark)
        {
            ID = iD;
            Alias = alias;
            FileName = fileName;
            FileInfo = new FileInfo(fileName);
            Tags = tags;
            Remark = remark;
        }

        public FileInfoRow(string alias, string fileName)
        {
            ID = -1;
            Alias = alias;
            FileName = fileName;
            Tags = new string[0];
            Remark = string.Empty;
        }
    }
}
