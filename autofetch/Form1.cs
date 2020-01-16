using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autofetch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Visible = false;
            Projects.Instance.Load();
            this.RefreshData();
            new Thread(this.FetchProject).Start();
        }

        public void RefreshData()
        {
            this.LoadMenu();
            this.LoadList();
        }
        public void LoadList()
        {
            var plist = Projects.Instance.GetProjects();
            this.listBox1.DataSource = plist;
        }

        public void LoadMenu()
        {
            iconMenu1.Items.Clear();
            iconMenu1.Items.Add("添加项目", null, (e, arg) => {

                FrmAddProject frm = new FrmAddProject();

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Projects.Instance.Add(new Model.ProjectInfo() {
                        Path = frm.ProjectPath,
                        Branch = frm.Branch
                    });

                    Projects.Instance.Persist();
                    this.LoadList();
                }
            });

            iconMenu1.Items.Add("项目列表", null, (e, arg) => {
                this.Visible = true;
            });

            iconMenu1.Items.Add("-");
            foreach (var item in Projects.Instance.GetProjects())
            {
                var c = new ToolStripMenuItem("更新本地");
                c.DropDownItems.Add(item.Path, null, (s, e) => {
                    GitAPI api = new GitAPI(item);
                    if (!api.Merge())
                    {
                        MessageBox.Show(string.Format(
                            "Error:\n{0}\nOutput:\n{1}",
                            api.Error,
                            api.Output
                            ),"更新错误或者冲突");
                    }

                    notifyIcon1.ShowBalloonTip(1000, "提示", "更新本地...", ToolTipIcon.Info);
                });
                iconMenu1.Items.Add(c);
            }

            iconMenu1.Items.Add("-");
            iconMenu1.Items.Add("退出", null, (s,e)=> {
                Process.GetCurrentProcess().Kill();
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem == null)
            {
                return;
            }

            Projects.Instance.Remove(this.listBox1.SelectedItem as Model.ProjectInfo);
            this.LoadList();
        }


        private void FetchProject()
        {
            long t = 0;
            while (true)
            {
                t = Environment.TickCount;
                var list = Projects.Instance.GetProjects();

                foreach (var item in list)
                {
                    GitAPI api = new GitAPI(item);
                    api.Fetch();
                }

                var delta = (Environment.TickCount - t);

                if (delta < 1000)
                {
                    Thread.Sleep((int)(1000 - delta));
                }
            }
        }
    }
}

