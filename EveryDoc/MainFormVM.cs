using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDoc
{
    internal class MainFormVM
    {
        private string queryString = string.Empty;
        private FileInfoRow[] fileInfoRows = Array.Empty<FileInfoRow>();

        public string QueryString
        {
            get => queryString;
            set
            {
                queryString = value;
                FileInfoRows = FileAliasDB.Instance.Match(queryString);
            }
        }
        public FileInfoRow[] FileInfoRows
        {
            get => fileInfoRows;
            set
            {
                fileInfoRows = value;
                FileInfoRowsChanged?.Invoke(this, FileInfoRows);
            }
        }
        public bool WholeWordMatch { get => FileAliasDB.Instance.WholeWordMatch; set => FileAliasDB.Instance.WholeWordMatch = value; }
        public bool MatchFileName { get => FileAliasDB.Instance.MatchFileName; set => FileAliasDB.Instance.MatchFileName = value; }
        public bool MatchTags { get => FileAliasDB.Instance.MatchTags; set => FileAliasDB.Instance.MatchTags = value; }
        public bool MatchRemark { get => FileAliasDB.Instance.MatchRemark; set => FileAliasDB.Instance.MatchRemark = value; }

        public event EventHandler<FileInfoRow[]>? FileInfoRowsChanged;
    }
}
