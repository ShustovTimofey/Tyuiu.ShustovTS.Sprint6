using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.ShustovTS.Sprint6.Task6.V8.Lib;
namespace Tyuiu.ShustovTS.Sprint6.Task6.V8
{
    public partial class FormMain : Form
    {
        string openFilePath;
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_STS_Click(object sender, EventArgs e)
        {
            openFileDialog_STS.ShowDialog();
            openFilePath = openFileDialog_STS.FileName;
            textBoxInPutData_STS.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData_STS.Text = groupBoxOutPutData_STS.Text + " " + openFileDialog_STS.FileName;
            buttonDone_STS.Enabled = true;
        }

        private void buttonDone_STS_Click(object sender, EventArgs e)
        {
            textBoxOutPutData_STS.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonAbout_STS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
