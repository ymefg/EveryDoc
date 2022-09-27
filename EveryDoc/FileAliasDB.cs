using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Data.Sqlite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EveryDoc
{
    internal class FileAliasDB
    {
        public const string DBFileName = "file_alias.db";
        public const string TableName = "alias_table";

        private readonly static SqliteConnection connection = new($"Data Source={DBFileName}");
        private readonly SqliteCommand command;
        private bool wholeWordMatch = false;
        private bool matchFileName = true;
        private bool matchTags = true;
        private bool matchRemark = false;

        public static FileAliasDB Instance { get; } = new FileAliasDB();
        public bool WholeWordMatch
        {
            get => wholeWordMatch;
            set
            {
                wholeWordMatch = value;
                Properties.Settings.Default.WholeWordMatch = wholeWordMatch;
                Properties.Settings.Default.Save();
            }
        }
        public bool MatchFileName
        {
            get => matchFileName;
            set
            {
                matchFileName = value;
                Properties.Settings.Default.MatchFileName = matchFileName;
                Properties.Settings.Default.Save();
            }
        }
        public bool MatchTags
        {
            get => matchTags;
            set
            {
                matchTags = value;
                Properties.Settings.Default.MatchTags = matchTags;
                Properties.Settings.Default.Save();
            }
        }
        public bool MatchRemark
        {
            get => matchRemark;
            set
            {
                matchRemark = value;
                Properties.Settings.Default.MatchRemark = matchRemark;
                Properties.Settings.Default.Save();
            }
        }

        private FileAliasDB()
        {
            connection.Open();
            command = connection.CreateCommand();
        }

        private static FileInfoRow[] ReadFileInfoRows(SqliteDataReader reader)
        {
            List<FileInfoRow> fileInfoRows = new();
            int id;
            string aliasCol;
            string fileName;
            string[] tags;
            string remark;

            while (reader.Read())
            {
                id = reader.GetInt32(0);
                aliasCol = reader.GetString(1);
                fileName = reader.GetString(2);
                if (reader.IsDBNull(3)) tags = Array.Empty<string>();
                else tags = (reader.GetString(3) ?? string.Empty).Split(',');
                if (reader.IsDBNull(4)) remark = string.Empty;
                else remark = reader.GetString(4);
                fileInfoRows.Add(new FileInfoRow(id, aliasCol, fileName, tags, remark));
            }
            return fileInfoRows.ToArray();
        }

        public FileInfoRow[] Match(string? matchStr)
        {
            if (matchStr == null) return Array.Empty<FileInfoRow>();

            List<FileInfoRow> fileInfoRows = new();

            string wwmStr = WholeWordMatch ? "=" : "LIKE";
            if (!WholeWordMatch) matchStr = '%' + matchStr + '%';
            string paramName = "$matchStr";


            command.CommandText =
                $"SELECT * FROM \"{TableName}\" WHERE \"Alias\" {wwmStr} {paramName}";

            if (MatchFileName)
            {
                command.CommandText += $" OR \"FileName\" {wwmStr} {paramName}";
            }
            if (MatchTags)
            {
                command.CommandText += $" OR \"Tags\" {wwmStr} {paramName}";
            }

            if (MatchRemark)
            {
                command.CommandText += $" OR \"Remark\" {wwmStr} {paramName}";
            }

            command.Parameters.AddWithValue(paramName, matchStr);

            using var reader = command.ExecuteReader();
            command.Parameters.Clear();

            fileInfoRows.AddRange(ReadFileInfoRows(reader));

            fileInfoRows.Sort((x, y) => x.Alias.Length - y.Alias.Length);
            return fileInfoRows.ToArray();

        }

        public void InsertFileAlias(string alias, string fileName, string[] tags, string remark)
        {
            command.CommandText = $"INSERT INTO {TableName} VALUES(NULL,'{alias}',$fileName,$tags,$remark);";
            command.Parameters.AddWithValue("$fileName", fileName);
            if (tags.Length != 0)
            {
                command.Parameters.AddWithValue("$tags", string.Join(",", tags));
            }
            else
            {
                command.Parameters.AddWithValue("$tags", null);
            }
            command.Parameters.AddWithValue("$remark", remark);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public void DeleteFileAlias(FileInfoRow fileInfoRow)
        {
            command.CommandText = $"DELETE FROM {TableName} WHERE ID = $id";
            command.Parameters.AddWithValue("$id", fileInfoRow.ID);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }

        public void UpdateFileAlias(FileInfoRow fileInfoRow)
        {
            command.CommandText =
                $@"
                UPDATE {TableName} SET
                Alias = $alias,
                FileName = $fileName,
                Tags = $tags,
                Remark = $remark
                WHERE ID = $id;
                ";
            command.Parameters.AddWithValue("$alias", fileInfoRow.Alias);
            command.Parameters.AddWithValue("$fileName", fileInfoRow.FileName);
            command.Parameters.AddWithValue("$tags", string.Join(",", fileInfoRow.Tags));
            command.Parameters.AddWithValue("$remark", fileInfoRow.Remark);
            command.Parameters.AddWithValue("$id", fileInfoRow.ID);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
        }
    }
}
