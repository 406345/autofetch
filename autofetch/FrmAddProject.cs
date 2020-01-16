using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autofetch
{
    public partial class FrmAddProject : Form
    {
        public FrmAddProject()
        {
            InitializeComponent();
        }

        public string ProjectPath { get; set; }
        public string Branch { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Branch = tbBranch.Text;
            this.ProjectPath = tbPath.Text;


            if (string.IsNullOrEmpty(this.ProjectPath))
            {
                MessageBox.Show("项目目录不能为空");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {

                this.tbPath.Text = this.ProjectPath;
            }
        }
    }
}
