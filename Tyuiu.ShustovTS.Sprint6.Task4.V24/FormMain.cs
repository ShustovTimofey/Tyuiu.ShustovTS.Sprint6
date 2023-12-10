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

using Tyuiu.ShustovTS.Sprint6.Task4.V24.Lib;
namespace Tyuiu.ShustovTS.Sprint6.Task4.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonHelp_STS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-23-2 Шустов Тимофей Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V21.txt";
                File.WriteAllText(path, textBoxOutPutData_STS.Text);

                DialogResult dialogResult = MessageBox.Show(this, $"Файл {path} сохранён успешно!\n Открыть его?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    //System.Diagnostics.Process.Start( path );
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "Notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_STS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_STS.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_STS.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_STS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_STS.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutPutData_STS.Text = "";

                chartFunction_STS.Series[0].Points.Clear();
                for (int i = 0; i < len; i++, startStep++)
                {
                    this.chartFunction_STS.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOutPutData_STS.AppendText(valueArray[i] + Environment.NewLine);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxStartStep_STS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
