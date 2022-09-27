using System.Diagnostics;

namespace EveryDoc
{
    internal static class Program
    {
        public static string? EverythingName;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            LoadSettings();

            Application.Run(new MainForm());
        }

        static void LoadSettings()
        {
            FileAliasDB.Instance.WholeWordMatch = Properties.Settings.Default.WholeWordMatch;
            FileAliasDB.Instance.MatchFileName = Properties.Settings.Default.MatchFileName;
            FileAliasDB.Instance.MatchTags = Properties.Settings.Default.MatchTags;
            FileAliasDB.Instance.MatchRemark = Properties.Settings.Default.MatchRemark;
            FileExecutor.ExecuteType = (FileExecutor.ExecuteTypeEnum)Properties.Settings.Default.ExecuteType;

            var p = Process.GetProcessesByName("Everything");
            if (p.Length > 0)
            {
                foreach (var process in p)
                {
                    try
                    {
                        EverythingName = process.MainModule?.FileName;
                        break;
                    }
                    catch { }
                }
            }
        }
    }
}