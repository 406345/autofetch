namespace autofetch
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.projectInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.iconMenu1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AutoFetch";
            this.notifyIcon1.Visible = true;
            // 
            // iconMenu1
            // 
            this.iconMenu1.Name = "iconMenu1";
            this.iconMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // listMenu
            // 
            this.listMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.listMenu.Name = "iconMenu1";
            this.listMenu.Size = new System.Drawing.Size(101, 26);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem2.Text = "删除";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.ContextMenuStrip = this.listMenu;
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.projectInfoBindingSource, "Path", true));
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.projectInfoBindingSource, "Path", true));
            this.listBox1.DataSource = this.projectInfoBindingSource1;
            this.listBox1.DisplayMember = "ListDisplay";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(624, 556);
            this.listBox1.TabIndex = 2;
            this.listBox1.ValueMember = "Path";
            // 
            // projectInfoBindingSource
            // 
            this.projectInfoBindingSource.DataSource = typeof(autofetch.Model.ProjectInfo);
            // 
            // projectInfoBindingSource1
            // 
            this.projectInfoBindingSource1.DataSource = typeof(autofetch.Model.ProjectInfo);
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataSource = typeof(autofetch.Projects);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 579);
            this.ContextMenuStrip = this.listMenu;
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Auto Fetch - https://github.com/406345/autofetch.git";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.listMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip iconMenu1;
        private System.Windows.Forms.ContextMenuStrip listMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource projectInfoBindingSource;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private System.Windows.Forms.BindingSource projectInfoBindingSource1;
    }
}

