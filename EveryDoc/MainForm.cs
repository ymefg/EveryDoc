using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;

namespace EveryDoc
{
    public partial class MainForm : Form
    {
        private readonly MainFormVM vm = new();
        private bool keyDownFocus = false;
        private bool updateExecuteOptionTsmi = false;
        private readonly Dictionary<ListViewItem, FileInfoRow> lviDict = new();

        public MainForm()
        {
            InitializeComponent();
            //mainTextBox.DataBindings.Add(new Binding(nameof(mainTextBox.Text), vm, nameof(vm.QueryString)));
            InitUI();
            vm.FileInfoRowsChanged += Vm_FileInfoRowsChanged;
            vm.QueryString = string.Empty;
            FileExecutor.ShowInformationBox += FileExecutor_ShowInformationBox;
        }

        private void FileExecutor_ShowInformationBox(FileInfoRow obj)
        {
            ShowInformationForm(obj);
        }

        private void ShowInformationForm(FileInfoRow row)
        {
            new InputAliasForm(InputAliasForm.ShowMode.ReadOnly, row).ShowDialog();
        }

        private void InitUI()
        {
            UpdateSearchOptionTsmi();
            UpdateExecuteTsmiOptionTsmi();
        }

        private void UpdateSearchOptionTsmi()
        {
            wholeWordMatchTsmi.Checked = vm.WholeWordMatch;
            matchFileNameTsmi.Checked = vm.MatchFileName;
            matchTagsTsmi.Checked = vm.MatchTags;
            matchRemarkTsmi.Checked = vm.MatchRemark;
        }

        private void UpdateExecuteTsmiOptionTsmi()
        {
            updateExecuteOptionTsmi = true;
            executeTsmi.Checked = false;
            showInExplorerTsmi.Checked = false;
            showInformationTsmi.Checked = false;
            switch (FileExecutor.ExecuteType)
            {
                case FileExecutor.ExecuteTypeEnum.Execute:
                    executeTsmi.Checked = true;
                    break;
                case FileExecutor.ExecuteTypeEnum.ShowInExplorer:
                    showInExplorerTsmi.Checked = true;
                    break;
                case FileExecutor.ExecuteTypeEnum.ShowInformation:
                    showInformationTsmi.Checked = true;
                    break;

                default:
                    break;
            }
            updateExecuteOptionTsmi = false;
        }

        private void Vm_FileInfoRowsChanged(object? sender, FileInfoRow[] e)
        {
            mainListView.Items.Clear();
            mainLVImageList.Images.Clear();
            lviDict.Clear();

            if (e.Length == 0)
            {
                mainLVImageList.Images.Add(Properties.Resources.Add);
                ListViewItem item = new("添加项目...");
                item.ImageIndex = mainLVImageList.Images.Count - 1;
                mainListView.Items.Add(item);
                return;
            }

            mainListView.BeginUpdate();
            foreach (var row in e)
            {
                var item = new ListViewItem
                {
                    Text = row.Alias
                };
                var icon = Utils.GetIconFromFile(row.FileName);
                if (icon != null)
                {
                    mainLVImageList.Images.Add(icon);
                }
                else
                {
                    mainLVImageList.Images.Add(Properties.Resources.MissingFile);
                }
                item.ImageIndex = mainLVImageList.Images.Count - 1;
                item.SubItems.Add(row.FileInfo?.Name ?? row.FileName);
                item.SubItems.Add(string.Join(", ", row.Tags));
                item.SubItems.Add(row.Remark);
                mainListView.Items.Add(item);
                lviDict.Add(item, row);
            }
            mainListView.EndUpdate();
        }

        private void tsmiInsertAlias_Click(object sender, EventArgs e)
        {
            AddAliasItem();
        }

        private void AddAliasItem()
        {
            if (new InputAliasForm(InputAliasForm.ShowMode.New,
                new FileInfoRow(mainTextBox.Text, string.Empty)).ShowDialog() == DialogResult.OK)
            {
                vm.QueryString = mainTextBox.Text;
            }
        }

        private void AddAliasItem(string alias, string fileName)
        {
            new InputAliasForm(InputAliasForm.ShowMode.New,
                new FileInfoRow(alias, fileName)).ShowDialog();
        }

        private void mainTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down
                || e.KeyCode == Keys.Up
                || e.KeyCode == Keys.PageDown
                || e.KeyCode == Keys.PageUp
                || e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                keyDownFocus = true;
                mainListView.Focus();
            }
        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            vm.QueryString = (sender as TextBox)?.Text ?? string.Empty;
        }

        private void mainListView_Enter(object sender, EventArgs e)
        {
            if (!keyDownFocus) return;
            if (sender is not ListView l) return;
            if (l.Items.Count <= 0) return;
            keyDownFocus = false;
            l.Items[0].Selected = true;
            l.Items[0].Focused = true;
            l.Items[0].EnsureVisible();
        }

        private void OpenExplorerSelectDBFileClick(object sender, EventArgs e)
        {
            FileExecutor.ShowFileInExplorer($"{Application.StartupPath}{FileAliasDB.DBFileName}");
        }

        private void MatchOptionTsmiCheckedChanged(object sender, EventArgs e)
        {
            if (sender is not ToolStripMenuItem tsmi) return;
            vm.GetType().GetProperties().ToList().Find(x => x.Name == (string)tsmi.Tag)?.SetValue(vm, tsmi.Checked);
            UpdateSearchOptionTsmi();
            vm.QueryString = mainTextBox.Text;
        }

        private void ExecuteOptionTsmiCheckedChanged(object sender, EventArgs e)
        {
            if (updateExecuteOptionTsmi) return;
            if (sender is not ToolStripMenuItem tsmi) return;
            switch ((string)tsmi.Tag)
            {
                case "Execute":
                    FileExecutor.ExecuteType = FileExecutor.ExecuteTypeEnum.Execute;
                    break;
                case "ShowInExplorer":
                    FileExecutor.ExecuteType = FileExecutor.ExecuteTypeEnum.ShowInExplorer;
                    break;
                case "ShowInformation":
                    FileExecutor.ExecuteType = FileExecutor.ExecuteTypeEnum.ShowInformation;
                    break;
                default:
                    break;
            }
            UpdateExecuteTsmiOptionTsmi();
        }

        private void editTagsTemplateTsmi_Click(object sender, EventArgs e)
        {
            try
            {
                FileExecutor.ExecuteFile($"{Application.StartupPath}标签模板.txt");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("需要在程序运行目录下手动添加“标签模板.txt”", "标签模板文件未找到", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mainListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ListViewExecuteFile();
            }
        }

        private void mainListView_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is not ListView l) return;
            if (e.Button == MouseButtons.Right)
            {
                bool itemEnabled = !(l.SelectedItems.Count == 0);
                executeMRTsmi.Enabled = itemEnabled;
                showInExplorerMRTsmi.Enabled = itemEnabled;
                showInformationMRTsmi.Enabled = itemEnabled;
                editMRTsmi.Enabled = itemEnabled;
                deleteMRTsmi.Enabled = itemEnabled;

                listViewMainCms.Show(l, e.Location);
            }
        }

        private void mainListView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ListViewExecuteFile();
            }
        }

        private void ListViewExecuteFile()
        {
            if (mainListView.SelectedItems.Count == 0)
            {
                return;
            }
            foreach (var item in mainListView.SelectedItems)
            {
                var lvItem = (ListViewItem)item;
                if (lvItem.Text == "添加项目..." && lvItem.SubItems.Count == 1)
                {
                    AddAliasItem();
                    return;
                }
                try
                {
                    FileExecutor.ExecuteFileInfoRow(lviDict[lvItem]);
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showInformationMRTsmi_Click(object sender, EventArgs e)
        {
            ShowInformationForm(lviDict[mainListView.SelectedItems[0]]);
        }

        private void mainListView_DragDrop(object sender, DragEventArgs e)
        {
            var a = ((Array?)e.Data?.GetData(DataFormats.FileDrop));
            if (a == null) return;
            List<string> fileNames = new();
            for (int i = 0; i < a.Length; i++)
            {
                var value = a.GetValue(i)?.ToString();
                if (value == null) continue;
                fileNames.Add(value);
            }

            foreach (var fileName in fileNames)
            {
                AddAliasItem(string.Empty, fileName);
            }
        }

        private void mainListView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.FileDrop) ?? false)      //判断该文件是否可以转换到文件放置格式
            {
                e.Effect = DragDropEffects.Link;       //放置效果为链接放置
            }
            else
            {
                e.Effect = DragDropEffects.None;      //不接受该数据,无法放置，后续事件也无法触发
            }
        }

        private void executeMRTsmi_Click(object sender, EventArgs e)
        {
            foreach (var item in mainListView.SelectedItems)
            {
                var fileInfo = lviDict[(ListViewItem)item].FileInfo;
                if (fileInfo == null) continue;
                try
                {
                    FileExecutor.ExecuteFile(fileInfo.FullName);
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showInExplorerMRTsmi_Click(object sender, EventArgs e)
        {
            foreach (var item in mainListView.SelectedItems)
            {
                var fileInfo = lviDict[(ListViewItem)item].FileInfo;
                if (fileInfo == null) continue;
                FileExecutor.ShowFileInExplorer(fileInfo.FullName);
            }
        }

        private void editMRTsmi_Click(object sender, EventArgs e)
        {
            new InputAliasForm(InputAliasForm.ShowMode.Edit, lviDict[mainListView.SelectedItems[0]]).ShowDialog();
            vm.QueryString = mainTextBox.Text;
        }

        private void deleteMRTsmi_Click(object sender, EventArgs e)
        {
            foreach (var item in mainListView.SelectedItems)
            {
                var lvItem = (ListViewItem)item;
                if (lviDict[lvItem] == null) continue;
                FileAliasDB.Instance.DeleteFileAlias(lviDict[lvItem]);
            }
            vm.QueryString = mainTextBox.Text;
        }

        private void mainListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView lv = (ListView)sender;
            if (lv.Sorting == SortOrder.Ascending)
            {
                lv.Sorting = SortOrder.Descending;
            }
            else
            {
                lv.Sorting = SortOrder.Ascending;
            }
            lv.Sort();
        }
    }
}