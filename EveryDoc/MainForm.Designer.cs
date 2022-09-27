namespace EveryDoc
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem editTagsTemplateTsmi;
            System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslFileCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertAlias = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOpenExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.wholeWordMatchTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.matchFileNameTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.matchTagsTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.matchRemarkTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.默认操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.showInExplorerTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.showInformationTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.mainListView = new System.Windows.Forms.ListView();
            this.aliasCH = new System.Windows.Forms.ColumnHeader();
            this.fileCH = new System.Windows.Forms.ColumnHeader();
            this.tagsCH = new System.Windows.Forms.ColumnHeader();
            this.remarkCH = new System.Windows.Forms.ColumnHeader();
            this.mainLVImageList = new System.Windows.Forms.ImageList(this.components);
            this.listViewMainCms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.executeMRTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.showInExplorerMRTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.showInformationMRTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.editMRTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMRTsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.addMRTsmi = new System.Windows.Forms.ToolStripMenuItem();
            editTagsTemplateTsmi = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mainStatusStrip.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.listViewMainCms.SuspendLayout();
            this.SuspendLayout();
            // 
            // editTagsTemplateTsmi
            // 
            editTagsTemplateTsmi.Image = global::EveryDoc.Properties.Resources.EditTag;
            editTagsTemplateTsmi.Name = "editTagsTemplateTsmi";
            editTagsTemplateTsmi.Size = new System.Drawing.Size(198, 22);
            editTagsTemplateTsmi.Text = "编辑标签模板(&T)";
            editTagsTemplateTsmi.Click += new System.EventHandler(this.editTagsTemplateTsmi_Click);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(193, 6);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslFileCount});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 539);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(784, 22);
            this.mainStatusStrip.TabIndex = 0;
            this.mainStatusStrip.Text = "statusStrip1";
            this.mainStatusStrip.Visible = false;
            // 
            // tsslFileCount
            // 
            this.tsslFileCount.Name = "tsslFileCount";
            this.tsslFileCount.Size = new System.Drawing.Size(131, 17);
            this.tsslFileCount.Text = "toolStripStatusLabel1";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiSearch,
            this.默认操作ToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.mainMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInsertAlias,
            this.toolStripMenuItem1,
            this.tsmiOpenExplorer,
            editTagsTemplateTsmi});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(58, 24);
            this.tsmiFile.Text = "文件(&F)";
            // 
            // tsmiInsertAlias
            // 
            this.tsmiInsertAlias.Image = global::EveryDoc.Properties.Resources.Add;
            this.tsmiInsertAlias.Name = "tsmiInsertAlias";
            this.tsmiInsertAlias.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiInsertAlias.Size = new System.Drawing.Size(198, 22);
            this.tsmiInsertAlias.Text = "添加项目(&N)...";
            this.tsmiInsertAlias.Click += new System.EventHandler(this.tsmiInsertAlias_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 6);
            // 
            // tsmiOpenExplorer
            // 
            this.tsmiOpenExplorer.Image = global::EveryDoc.Properties.Resources.DatabaseFile;
            this.tsmiOpenExplorer.Name = "tsmiOpenExplorer";
            this.tsmiOpenExplorer.Size = new System.Drawing.Size(198, 22);
            this.tsmiOpenExplorer.Text = "查看数据库文件(&E)";
            this.tsmiOpenExplorer.Click += new System.EventHandler(this.OpenExplorerSelectDBFileClick);
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.CheckOnClick = true;
            this.tsmiSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wholeWordMatchTsmi,
            this.matchFileNameTsmi,
            this.matchTagsTsmi,
            this.matchRemarkTsmi});
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.Size = new System.Drawing.Size(59, 24);
            this.tsmiSearch.Text = "搜索(&S)";
            // 
            // wholeWordMatchTsmi
            // 
            this.wholeWordMatchTsmi.CheckOnClick = true;
            this.wholeWordMatchTsmi.Name = "wholeWordMatchTsmi";
            this.wholeWordMatchTsmi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.wholeWordMatchTsmi.Size = new System.Drawing.Size(197, 22);
            this.wholeWordMatchTsmi.Tag = "WholeWordMatch";
            this.wholeWordMatchTsmi.Text = "全字匹配(&W)";
            this.wholeWordMatchTsmi.CheckedChanged += new System.EventHandler(this.MatchOptionTsmiCheckedChanged);
            // 
            // matchFileNameTsmi
            // 
            this.matchFileNameTsmi.CheckOnClick = true;
            this.matchFileNameTsmi.Name = "matchFileNameTsmi";
            this.matchFileNameTsmi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.matchFileNameTsmi.Size = new System.Drawing.Size(197, 22);
            this.matchFileNameTsmi.Tag = "MatchFileName";
            this.matchFileNameTsmi.Text = "匹配文件名(&N)";
            this.matchFileNameTsmi.CheckedChanged += new System.EventHandler(this.MatchOptionTsmiCheckedChanged);
            // 
            // matchTagsTsmi
            // 
            this.matchTagsTsmi.CheckOnClick = true;
            this.matchTagsTsmi.Name = "matchTagsTsmi";
            this.matchTagsTsmi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.matchTagsTsmi.Size = new System.Drawing.Size(197, 22);
            this.matchTagsTsmi.Tag = "MatchTags";
            this.matchTagsTsmi.Text = "匹配标签(&T)";
            this.matchTagsTsmi.CheckedChanged += new System.EventHandler(this.MatchOptionTsmiCheckedChanged);
            // 
            // matchRemarkTsmi
            // 
            this.matchRemarkTsmi.CheckOnClick = true;
            this.matchRemarkTsmi.Name = "matchRemarkTsmi";
            this.matchRemarkTsmi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.matchRemarkTsmi.Size = new System.Drawing.Size(197, 22);
            this.matchRemarkTsmi.Tag = "MatchRemark";
            this.matchRemarkTsmi.Text = "匹配备注(&R)";
            this.matchRemarkTsmi.CheckedChanged += new System.EventHandler(this.MatchOptionTsmiCheckedChanged);
            // 
            // 默认操作ToolStripMenuItem
            // 
            this.默认操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executeTsmi,
            this.showInExplorerTsmi,
            this.showInformationTsmi});
            this.默认操作ToolStripMenuItem.Name = "默认操作ToolStripMenuItem";
            this.默认操作ToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.默认操作ToolStripMenuItem.Text = "默认操作(&D)";
            // 
            // executeTsmi
            // 
            this.executeTsmi.Checked = true;
            this.executeTsmi.CheckOnClick = true;
            this.executeTsmi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.executeTsmi.Name = "executeTsmi";
            this.executeTsmi.Size = new System.Drawing.Size(199, 22);
            this.executeTsmi.Tag = "Execute";
            this.executeTsmi.Text = "打开文件(&O)";
            this.executeTsmi.CheckedChanged += new System.EventHandler(this.ExecuteOptionTsmiCheckedChanged);
            // 
            // showInExplorerTsmi
            // 
            this.showInExplorerTsmi.CheckOnClick = true;
            this.showInExplorerTsmi.Name = "showInExplorerTsmi";
            this.showInExplorerTsmi.Size = new System.Drawing.Size(199, 22);
            this.showInExplorerTsmi.Tag = "ShowInExplorer";
            this.showInExplorerTsmi.Text = "在资源管理器中打开(&E)";
            this.showInExplorerTsmi.CheckedChanged += new System.EventHandler(this.ExecuteOptionTsmiCheckedChanged);
            // 
            // showInformationTsmi
            // 
            this.showInformationTsmi.CheckOnClick = true;
            this.showInformationTsmi.Name = "showInformationTsmi";
            this.showInformationTsmi.Size = new System.Drawing.Size(199, 22);
            this.showInformationTsmi.Tag = "ShowInformation";
            this.showInformationTsmi.Text = "显示详细信息(&I)";
            this.showInformationTsmi.CheckedChanged += new System.EventHandler(this.ExecuteOptionTsmiCheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mainTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainListView, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 537);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // mainTextBox
            // 
            this.mainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTextBox.Location = new System.Drawing.Point(6, 6);
            this.mainTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(772, 23);
            this.mainTextBox.TabIndex = 0;
            this.mainTextBox.TextChanged += new System.EventHandler(this.mainTextBox_TextChanged);
            this.mainTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainTextBox_KeyDown);
            // 
            // mainListView
            // 
            this.mainListView.AllowDrop = true;
            this.mainListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.aliasCH,
            this.fileCH,
            this.tagsCH,
            this.remarkCH});
            this.mainListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.mainListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.mainListView.Location = new System.Drawing.Point(0, 35);
            this.mainListView.Margin = new System.Windows.Forms.Padding(0);
            this.mainListView.Name = "mainListView";
            this.mainListView.Size = new System.Drawing.Size(784, 502);
            this.mainListView.SmallImageList = this.mainLVImageList;
            this.mainListView.TabIndex = 1;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            this.mainListView.View = System.Windows.Forms.View.Details;
            this.mainListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.mainListView_DragDrop);
            this.mainListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.mainListView_DragEnter);
            this.mainListView.Enter += new System.EventHandler(this.mainListView_Enter);
            this.mainListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainListView_KeyDown);
            this.mainListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mainListView_MouseDoubleClick);
            this.mainListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainListView_MouseUp);
            // 
            // aliasCH
            // 
            this.aliasCH.Text = "编号";
            this.aliasCH.Width = 120;
            // 
            // fileCH
            // 
            this.fileCH.Text = "文件名";
            this.fileCH.Width = 240;
            // 
            // tagsCH
            // 
            this.tagsCH.Text = "标签";
            this.tagsCH.Width = 120;
            // 
            // remarkCH
            // 
            this.remarkCH.Text = "备注";
            this.remarkCH.Width = 240;
            // 
            // mainLVImageList
            // 
            this.mainLVImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.mainLVImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.mainLVImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listViewMainCms
            // 
            this.listViewMainCms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executeMRTsmi,
            this.showInExplorerMRTsmi,
            this.showInformationMRTsmi,
            this.editMRTsmi,
            this.deleteMRTsmi,
            toolStripMenuItem2,
            this.addMRTsmi});
            this.listViewMainCms.Name = "contextMenuStrip1";
            this.listViewMainCms.Size = new System.Drawing.Size(197, 142);
            this.listViewMainCms.Text = "aaa";
            // 
            // executeMRTsmi
            // 
            this.executeMRTsmi.Image = global::EveryDoc.Properties.Resources.Open;
            this.executeMRTsmi.Name = "executeMRTsmi";
            this.executeMRTsmi.Size = new System.Drawing.Size(196, 22);
            this.executeMRTsmi.Text = "打开(&O)";
            this.executeMRTsmi.Click += new System.EventHandler(this.executeMRTsmi_Click);
            // 
            // showInExplorerMRTsmi
            // 
            this.showInExplorerMRTsmi.Image = global::EveryDoc.Properties.Resources.FolderClosed;
            this.showInExplorerMRTsmi.Name = "showInExplorerMRTsmi";
            this.showInExplorerMRTsmi.Size = new System.Drawing.Size(196, 22);
            this.showInExplorerMRTsmi.Text = "打开所在的文件夹(&F)";
            this.showInExplorerMRTsmi.Click += new System.EventHandler(this.showInExplorerMRTsmi_Click);
            // 
            // showInformationMRTsmi
            // 
            this.showInformationMRTsmi.Image = global::EveryDoc.Properties.Resources.ShowDetailsPane;
            this.showInformationMRTsmi.Name = "showInformationMRTsmi";
            this.showInformationMRTsmi.Size = new System.Drawing.Size(196, 22);
            this.showInformationMRTsmi.Text = "详细信息(&I)";
            this.showInformationMRTsmi.Click += new System.EventHandler(this.showInformationMRTsmi_Click);
            // 
            // editMRTsmi
            // 
            this.editMRTsmi.Image = global::EveryDoc.Properties.Resources.Edit;
            this.editMRTsmi.Name = "editMRTsmi";
            this.editMRTsmi.Size = new System.Drawing.Size(196, 22);
            this.editMRTsmi.Text = "编辑(&E)";
            this.editMRTsmi.Click += new System.EventHandler(this.editMRTsmi_Click);
            // 
            // deleteMRTsmi
            // 
            this.deleteMRTsmi.Image = global::EveryDoc.Properties.Resources.Delete;
            this.deleteMRTsmi.Name = "deleteMRTsmi";
            this.deleteMRTsmi.Size = new System.Drawing.Size(196, 22);
            this.deleteMRTsmi.Text = "删除(&D)";
            this.deleteMRTsmi.Click += new System.EventHandler(this.deleteMRTsmi_Click);
            // 
            // addMRTsmi
            // 
            this.addMRTsmi.Image = global::EveryDoc.Properties.Resources.Add;
            this.addMRTsmi.Name = "addMRTsmi";
            this.addMRTsmi.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addMRTsmi.Size = new System.Drawing.Size(196, 22);
            this.addMRTsmi.Text = "添加项目(&A)...";
            this.addMRTsmi.Click += new System.EventHandler(this.tsmiInsertAlias_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件编号";
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.listViewMainCms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip mainStatusStrip;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem tsmiFile;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox mainTextBox;
        private ListView mainListView;
        private ToolStripStatusLabel tsslFileCount;
        private ToolStripMenuItem tsmiSearch;
        private ColumnHeader aliasCH;
        private ColumnHeader fileCH;
        private ColumnHeader tagsCH;
        private ToolStripMenuItem tsmiOpenExplorer;
        private ToolStripMenuItem wholeWordMatchTsmi;
        private ToolStripMenuItem tsmiInsertAlias;
        private ToolStripMenuItem matchFileNameTsmi;
        private ToolStripMenuItem matchTagsTsmi;
        private ToolStripMenuItem matchRemarkTsmi;
        private ColumnHeader remarkCH;
        private ToolStripMenuItem 默认操作ToolStripMenuItem;
        private ToolStripMenuItem executeTsmi;
        private ToolStripMenuItem showInExplorerTsmi;
        private ToolStripMenuItem showInformationTsmi;
        private ToolStripSeparator toolStripMenuItem1;
        private ImageList mainLVImageList;
        private ToolStripMenuItem editTagsTemplateTsmi;
        private ContextMenuStrip listViewMainCms;
        private ToolStripMenuItem executeMRTsmi;
        private ToolStripMenuItem showInExplorerMRTsmi;
        private ToolStripMenuItem showInformationMRTsmi;
        private ToolStripMenuItem deleteMRTsmi;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem addMRTsmi;
        private ToolStripMenuItem editMRTsmi;
    }
}