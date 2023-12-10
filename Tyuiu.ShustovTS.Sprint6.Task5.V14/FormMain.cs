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

using Tyuiu.ShustovTS.Sprint6.Task5.V14.Lib;
namespace Tyuiu.ShustovTS.Sprint6.Task5.V14
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string path = @"C:\Users\malsu\source\repos\Tyuiu.ShustovTS.Sprint6\Tyuiu.ShustovTS.Sprint6.Task5.V14\bin\Debug\InPutFileTask5V14.txt";
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_STS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУБ-23-2 Шустов Тимофей Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenFile_STS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonDone_STS_Click(object sender, EventArgs e)
        {
            dataGridViewResult_STS.ColumnCount = 2;
            dataGridViewResult_STS.Columns[0].Width = 20;
            dataGridViewResult_STS.Columns[1].Width = 50;
            this.chartFunction_STS.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_STS.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_STS.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_STS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_STS.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }
    }
}
