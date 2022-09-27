using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveryDoc
{
    internal static class FileExecutor
    {
        private static ExecuteTypeEnum executeType = ExecuteTypeEnum.Execute;

        public enum ExecuteTypeEnum
        {
            Execute = 0,
            ShowInExplorer = 1,
            ShowInformation = 2,
        }

        public static ExecuteTypeEnum ExecuteType
        {
            get => executeType;
            set
            {
                executeType = value;
                Properties.Settings.Default.ExecuteType = (int)executeType;
                Properties.Settings.Default.Save();
            }
        }
        public static event Action<FileInfoRow>? ShowInformationBox;

        public static void ExecuteFileInfoRow(FileInfoRow row)
        {
            switch (ExecuteType)
            {
                case ExecuteTypeEnum.Execute:
                    ExecuteFile(row.FileName);
                    break;
                case ExecuteTypeEnum.ShowInExplorer:
                    ShowFileInExplorer(row.FileName);
                    break;
                case ExecuteTypeEnum.ShowInformation:
                    ShowInformation(row);
                    break;

                default:
                    throw new Exception("枚举出错！");
            }
        }

        public static void ExecuteFile(string fileName)
        {
            Process p = new Process();
            if (File.Exists(fileName) == false && Directory.Exists(fileName) == false)
            {
                if (Program.EverythingName != null && Program.EverythingName != string.Empty)
                {
                    fileName = fileName.Split(new char[] { '\\', '/' }).Last();
                    p.StartInfo.FileName = Program.EverythingName;
                    p.StartInfo.ArgumentList.Add("-s");
                    p.StartInfo.ArgumentList.Add(fileName);
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            else
            {
                p.StartInfo.FileName = fileName;
            }

            p.StartInfo.UseShellExecute = true;            
            p.Start();
        }

        public static void ShowFileInExplorer(string fileName)
        {
            Process.Start("explorer", $"/select,{fileName}");
        }

        private static void ShowInformation(FileInfoRow row)
        {
            ShowInformationBox?.Invoke(row);
        }
    }
}
