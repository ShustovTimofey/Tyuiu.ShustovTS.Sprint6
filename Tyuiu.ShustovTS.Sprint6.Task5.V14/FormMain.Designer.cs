
namespace Tyuiu.ShustovTS.Sprint6.Task5.V14
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_STS = new System.Windows.Forms.Panel();
            this.panelLeft_STS = new System.Windows.Forms.Panel();
            this.splitterMain_STS = new System.Windows.Forms.Splitter();
            this.panelFill_STS = new System.Windows.Forms.Panel();
            this.groupBoxResult_STS = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_STS = new System.Windows.Forms.DataGridView();
            this.chartFunction_STS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_STS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_STS = new System.Windows.Forms.TextBox();
            this.buttonDone_STS = new System.Windows.Forms.Button();
            this.buttonOpenFile_STS = new System.Windows.Forms.Button();
            this.buttonHelp_STS = new System.Windows.Forms.Button();
            this.panelTop_STS.SuspendLayout();
            this.panelLeft_STS.SuspendLayout();
            this.panelFill_STS.SuspendLayout();
            this.groupBoxResult_STS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_STS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_STS)).BeginInit();
            this.groupBoxTask_STS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_STS
            // 
            this.panelTop_STS.Controls.Add(this.buttonHelp_STS);
            this.panelTop_STS.Controls.Add(this.buttonOpenFile_STS);
            this.panelTop_STS.Controls.Add(this.buttonDone_STS);
            this.panelTop_STS.Controls.Add(this.groupBoxTask_STS);
            this.panelTop_STS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_STS.Location = new System.Drawing.Point(0, 0);
            this.panelTop_STS.Name = "panelTop_STS";
            this.panelTop_STS.Size = new System.Drawing.Size(954, 135);
            this.panelTop_STS.TabIndex = 0;
            // 
            // panelLeft_STS
            // 
            this.panelLeft_STS.Controls.Add(this.groupBoxResult_STS);
            this.panelLeft_STS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_STS.Location = new System.Drawing.Point(0, 135);
            this.panelLeft_STS.Name = "panelLeft_STS";
            this.panelLeft_STS.Size = new System.Drawing.Size(262, 493);
            this.panelLeft_STS.TabIndex = 1;
            // 
            // splitterMain_STS
            // 
            this.splitterMain_STS.Location = new System.Drawing.Point(262, 135);
            this.splitterMain_STS.Name = "splitterMain_STS";
            this.splitterMain_STS.Size = new System.Drawing.Size(3, 493);
            this.splitterMain_STS.TabIndex = 2;
            this.splitterMain_STS.TabStop = false;
            // 
            // panelFill_STS
            // 
            this.panelFill_STS.Controls.Add(this.chartFunction_STS);
            this.panelFill_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_STS.Location = new System.Drawing.Point(265, 135);
            this.panelFill_STS.Name = "panelFill_STS";
            this.panelFill_STS.Size = new System.Drawing.Size(689, 493);
            this.panelFill_STS.TabIndex = 3;
            // 
            // groupBoxResult_STS
            // 
            this.groupBoxResult_STS.Controls.Add(this.dataGridViewResult_STS);
            this.groupBoxResult_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_STS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_STS.Name = "groupBoxResult_STS";
            this.groupBoxResult_STS.Size = new System.Drawing.Size(262, 493);
            this.groupBoxResult_STS.TabIndex = 0;
            this.groupBoxResult_STS.TabStop = false;
            this.groupBoxResult_STS.Text = "Вывод данных:";
            // 
            // dataGridViewResult_STS
            // 
            this.dataGridViewResult_STS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_STS.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewResult_STS.Name = "dataGridViewResult_STS";
            this.dataGridViewResult_STS.RowHeadersVisible = false;
            this.dataGridViewResult_STS.RowHeadersWidth = 62;
            this.dataGridViewResult_STS.RowTemplate.Height = 28;
            this.dataGridViewResult_STS.Size = new System.Drawing.Size(256, 468);
            this.dataGridViewResult_STS.TabIndex = 0;
            // 
            // chartFunction_STS
            // 
            chartArea6.Name = "ChartArea1";
            this.chartFunction_STS.ChartAreas.Add(chartArea6);
            this.chartFunction_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chartFunction_STS.Legends.Add(legend6);
            this.chartFunction_STS.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_STS.Name = "chartFunction_STS";
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.LimeGreen;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartFunction_STS.Series.Add(series6);
            this.chartFunction_STS.Size = new System.Drawing.Size(689, 493);
            this.chartFunction_STS.TabIndex = 0;
            this.chartFunction_STS.Text = "chart1";
            // 
            // groupBoxTask_STS
            // 
            this.groupBoxTask_STS.Controls.Add(this.textBoxTask_STS);
            this.groupBoxTask_STS.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTask_STS.Name = "groupBoxTask_STS";
            this.groupBoxTask_STS.Size = new System.Drawing.Size(558, 128);
            this.groupBoxTask_STS.TabIndex = 0;
            this.groupBoxTask_STS.TabStop = false;
            this.groupBoxTask_STS.Text = "Условие:";
            // 
            // textBoxTask_STS
            // 
            this.textBoxTask_STS.Location = new System.Drawing.Point(9, 26);
            this.textBoxTask_STS.Multiline = true;
            this.textBoxTask_STS.Name = "textBoxTask_STS";
            this.textBoxTask_STS.ReadOnly = true;
            this.textBoxTask_STS.Size = new System.Drawing.Size(543, 99);
            this.textBoxTask_STS.TabIndex = 0;
            this.textBoxTask_STS.Text = "Прочитать данные из файла InPutFileTask5V14.txt. Вывести \r\nв dataGridView все зна" +
    "чения, большие или равные 10.\r\nПостроить диаграмму по этим значениям.";
            // 
            // buttonDone_STS
            // 
            this.buttonDone_STS.BackColor = System.Drawing.Color.Green;
            this.buttonDone_STS.Location = new System.Drawing.Point(563, 13);
            this.buttonDone_STS.Name = "buttonDone_STS";
            this.buttonDone_STS.Size = new System.Drawing.Size(111, 116);
            this.buttonDone_STS.TabIndex = 1;
            this.buttonDone_STS.Text = "Выполнить";
            this.buttonDone_STS.UseVisualStyleBackColor = false;
            this.buttonDone_STS.Click += new System.EventHandler(this.buttonDone_STS_Click);
            // 
            // buttonOpenFile_STS
            // 
            this.buttonOpenFile_STS.BackColor = System.Drawing.Color.Blue;
            this.buttonOpenFile_STS.Location = new System.Drawing.Point(680, 12);
            this.buttonOpenFile_STS.Name = "buttonOpenFile_STS";
            this.buttonOpenFile_STS.Size = new System.Drawing.Size(111, 116);
            this.buttonOpenFile_STS.TabIndex = 1;
            this.buttonOpenFile_STS.Text = "Открыть файл";
            this.buttonOpenFile_STS.UseVisualStyleBackColor = false;
            this.buttonOpenFile_STS.Click += new System.EventHandler(this.buttonOpenFile_STS_Click);
            // 
            // buttonHelp_STS
            // 
            this.buttonHelp_STS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_STS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_STS.Location = new System.Drawing.Point(831, 12);
            this.buttonHelp_STS.Name = "buttonHelp_STS";
            this.buttonHelp_STS.Size = new System.Drawing.Size(111, 116);
            this.buttonHelp_STS.TabIndex = 1;
            this.buttonHelp_STS.Text = "Справка";
            this.buttonHelp_STS.UseVisualStyleBackColor = false;
            this.buttonHelp_STS.Click += new System.EventHandler(this.buttonHelp_STS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 628);
            this.Controls.Add(this.panelFill_STS);
            this.Controls.Add(this.splitterMain_STS);
            this.Controls.Add(this.panelLeft_STS);
            this.Controls.Add(this.panelTop_STS);
            this.MinimumSize = new System.Drawing.Size(976, 684);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 14 | Шустов Т.С.";
            this.panelTop_STS.ResumeLayout(false);
            this.panelLeft_STS.ResumeLayout(false);
            this.panelFill_STS.ResumeLayout(false);
            this.groupBoxResult_STS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_STS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_STS)).EndInit();
            this.groupBoxTask_STS.ResumeLayout(false);
            this.groupBoxTask_STS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_STS;
        private System.Windows.Forms.Panel panelLeft_STS;
        private System.Windows.Forms.Splitter splitterMain_STS;
        private System.Windows.Forms.Panel panelFill_STS;
        private System.Windows.Forms.GroupBox groupBoxResult_STS;
        private System.Windows.Forms.DataGridView dataGridViewResult_STS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_STS;
        private System.Windows.Forms.GroupBox groupBoxTask_STS;
        private System.Windows.Forms.TextBox textBoxTask_STS;
        private System.Windows.Forms.Button buttonHelp_STS;
        private System.Windows.Forms.Button buttonOpenFile_STS;
        private System.Windows.Forms.Button buttonDone_STS;
    }
}

