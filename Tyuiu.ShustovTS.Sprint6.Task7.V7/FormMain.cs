﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.ShustovTS.Sprint6.Task7.V7.Lib;
namespace Tyuiu.ShustovTS.Sprint6.Task7.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_STS.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialog_STS.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        static string openFile;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonOpenFile_STS_Click(object sender, EventArgs e)
        {
            openFileDialog_STS.ShowDialog();
            openFile = openFileDialog_STS.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFile);

            dataGridViewInPutData_STS.RowCount = rows;
            dataGridViewInPutData_STS.ColumnCount = columns;
            dataGridViewOutPutData_STS.RowCount = rows;
            dataGridViewOutPutData_STS.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPutData_STS.Columns[i].Width = 50;
                dataGridViewOutPutData_STS.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPutData_STS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
            buttonDone_STS.Enabled = true;
        }

        private void buttonOpenFile_STS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_STS.ToolTipTitle = "Выполнить";
        }

        private void buttonDone_STS_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPutData_STS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_STS.Enabled = true;
        }

        private void buttonDone_STS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_STS.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_STS_Click(object sender, EventArgs e)
        {
            saveFileDialog_STS.FileName = "OutPutFileTask7.csv";
            saveFileDialog_STS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_STS.ShowDialog();

            string path = saveFileDialog_STS.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPutData_STS.RowCount;
            int columns = dataGridViewOutPutData_STS.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewInPutData_STS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewInPutData_STS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonSave_STS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_STS.ToolTipTitle = "Сохранить файл";
        }

        private void buttonAbout_STS_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void buttonAbout_STS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_STS.ToolTipTitle = "Справка";
        }
    }
}
