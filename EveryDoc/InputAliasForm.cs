using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EveryDoc
{
    public partial class InputAliasForm : Form
    {
        FileInfoRow fileInfoRow;
        private readonly ShowMode showMode;

        public enum ShowMode
        {
            New,
            ReadOnly,
            Edit,
        }

        public InputAliasForm(ShowMode mode, FileInfoRow fileInfoRow)
        {
            InitializeComponent();

            showMode = mode;

            // 按钮显示
            if (mode == ShowMode.New)
            {
                Text = "新建项目";
                deleteBtn.Visible = false;
            }
            else if (mode == ShowMode.ReadOnly)
            {
                Text = "查看项目";
                deleteBtn.Visible = false;
                okBtn.Visible = false;
                aliasTb.ReadOnly = true;
                fileNameTb.ReadOnly = true;
                tagsTb.ReadOnly = true;
                tagsCb.Visible = false;
                addTsgBtn.Visible = false;
                remarkTb.ReadOnly = true;
                browseBtn.Visible = false;
                aliasTb.PlaceholderText = string.Empty;
                fileNameTb.PlaceholderText = string.Empty;
                tagsTb.PlaceholderText = string.Empty;
            }
            else if (mode == ShowMode.Edit)
            {
                Text = "编辑项目";
            }
            
            // 数据显示
            this.fileInfoRow = fileInfoRow;
            tagsCb.Items.AddRange(ReadTagsTemplate());
            tagsCb.SelectedIndex = 0;
            aliasTb.Text = fileInfoRow.Alias;
            fileNameTb.Text = fileInfoRow.FileName;
            tagsTb.Text = string.Join(",", fileInfoRow.Tags);
            remarkTb.Text = fileInfoRow.Remark;

            // 数据绑定
            //aliasTb.DataBindings.Add(nameof(aliasTb.Text), fileInfoRow, nameof(fileInfoRow.Alias));
            //fileNameTb.DataBindings.Add(nameof(fileNameTb.Text), fileInfoRow, nameof(fileInfoRow.FileName));
            //remarkTb.DataBindings.Add(nameof(remarkTb.Text), fileInfoRow, nameof(fileInfoRow.Remark));
        }

        private string[] ReadTagsTemplate()
        {
            const string tagsTemplateFileName = ".\\标签模板.txt";
            //if (!new FileInfo(tagsTemplateFileName).Exists) return Array.Empty<string>();

            List<string> tags = new();
            try
            {
                using StreamReader sr = new(tagsTemplateFileName);
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    tags.Add(line);
                }                
            }
            catch
            {
                return Array.Empty<string>();
            }
            return tags.ToArray();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new();
            if (ofd.ShowDialog() != DialogResult.OK) return;
            fileNameTb.Text = ofd.FileName;
        }

        private void addTsgBtn_Click(object sender, EventArgs e)
        {
            string tagStr = tagsCb.Text;
            if (tagsTb.Text != null && tagsTb.Text != string.Empty)
            {
                tagStr = ',' + tagStr;
            }
            tagsTb.AppendText(tagStr);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if (aliasTb.Text == string.Empty || fileNameTb.Text == string.Empty)
            {
                MessageBox.Show("没有填写编号或者文件名。", "必填项为空", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            fileInfoRow.Alias = aliasTb.Text;
            fileInfoRow.FileName = fileNameTb.Text;
            fileInfoRow.Tags = tagsTb.Text.Split(',');
            fileInfoRow.Remark = remarkTb.Text;

            if (showMode == ShowMode.New)
            {
                FileAliasDB.Instance.InsertFileAlias(fileInfoRow.Alias, fileInfoRow.FileName, fileInfoRow.Tags, fileInfoRow.Remark);
            }
            else if (showMode == ShowMode.Edit)
            {
                FileAliasDB.Instance.UpdateFileAlias(fileInfoRow);
            }
            
            DialogResult = DialogResult.OK;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            FileAliasDB.Instance.DeleteFileAlias(fileInfoRow);
            Close();
        }
    }
}
