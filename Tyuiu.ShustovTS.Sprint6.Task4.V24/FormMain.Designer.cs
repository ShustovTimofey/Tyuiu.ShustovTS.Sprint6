
namespace Tyuiu.ShustovTS.Sprint6.Task4.V24
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_STS = new System.Windows.Forms.Panel();
            this.panelLeft_STS = new System.Windows.Forms.Panel();
            this.splitterMain_STS = new System.Windows.Forms.Splitter();
            this.panelFill_STS = new System.Windows.Forms.Panel();
            this.groupBoxTask_STS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_STS = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_STS = new System.Windows.Forms.GroupBox();
            this.textBoxStartStep_STS = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_STS = new System.Windows.Forms.TextBox();
            this.labelStartStep_STS = new System.Windows.Forms.Label();
            this.labelStopStep_STS = new System.Windows.Forms.Label();
            this.buttonDone_STS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonHelp_STS = new System.Windows.Forms.Button();
            this.groupBoxOutPutData_STS = new System.Windows.Forms.GroupBox();
            this.textBoxOutPutData_STS = new System.Windows.Forms.TextBox();
            this.chartFunction_STS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_STS.SuspendLayout();
            this.panelLeft_STS.SuspendLayout();
            this.panelFill_STS.SuspendLayout();
            this.groupBoxTask_STS.SuspendLayout();
            this.groupBoxInPutData_STS.SuspendLayout();
            this.groupBoxOutPutData_STS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_STS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_STS
            // 
            this.panelTop_STS.Controls.Add(this.buttonHelp_STS);
            this.panelTop_STS.Controls.Add(this.button1);
            this.panelTop_STS.Controls.Add(this.buttonDone_STS);
            this.panelTop_STS.Controls.Add(this.groupBoxInPutData_STS);
            this.panelTop_STS.Controls.Add(this.groupBoxTask_STS);
            this.panelTop_STS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_STS.Location = new System.Drawing.Point(0, 0);
            this.panelTop_STS.Name = "panelTop_STS";
            this.panelTop_STS.Size = new System.Drawing.Size(1135, 133);
            this.panelTop_STS.TabIndex = 0;
            // 
            // panelLeft_STS
            // 
            this.panelLeft_STS.Controls.Add(this.groupBoxOutPutData_STS);
            this.panelLeft_STS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_STS.Location = new System.Drawing.Point(0, 133);
            this.panelLeft_STS.Name = "panelLeft_STS";
            this.panelLeft_STS.Size = new System.Drawing.Size(222, 429);
            this.panelLeft_STS.TabIndex = 1;
            // 
            // splitterMain_STS
            // 
            this.splitterMain_STS.Location = new System.Drawing.Point(222, 133);
            this.splitterMain_STS.Name = "splitterMain_STS";
            this.splitterMain_STS.Size = new System.Drawing.Size(3, 429);
            this.splitterMain_STS.TabIndex = 2;
            this.splitterMain_STS.TabStop = false;
            // 
            // panelFill_STS
            // 
            this.panelFill_STS.Controls.Add(this.chartFunction_STS);
            this.panelFill_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_STS.Location = new System.Drawing.Point(225, 133);
            this.panelFill_STS.Name = "panelFill_STS";
            this.panelFill_STS.Size = new System.Drawing.Size(910, 429);
            this.panelFill_STS.TabIndex = 3;
            // 
            // groupBoxTask_STS
            // 
            this.groupBoxTask_STS.Controls.Add(this.textBoxTask_STS);
            this.groupBoxTask_STS.Location = new System.Drawing.Point(4, 13);
            this.groupBoxTask_STS.Name = "groupBoxTask_STS";
            this.groupBoxTask_STS.Size = new System.Drawing.Size(475, 117);
            this.groupBoxTask_STS.TabIndex = 0;
            this.groupBoxTask_STS.TabStop = false;
            this.groupBoxTask_STS.Text = "Условие:";
            // 
            // textBoxTask_STS
            // 
            this.textBoxTask_STS.Location = new System.Drawing.Point(7, 26);
            this.textBoxTask_STS.Multiline = true;
            this.textBoxTask_STS.Name = "textBoxTask_STS";
            this.textBoxTask_STS.ReadOnly = true;
            this.textBoxTask_STS.Size = new System.Drawing.Size(462, 85);
            this.textBoxTask_STS.TabIndex = 0;
            this.textBoxTask_STS.Text = "Протабулировать функцию f(x) на заданном диапазоне.\r\nРезультат вывести в textBoxO" +
    "utPutData, построить график\r\nфункции и сохранить в файл по нажатию кнопки.";
            // 
            // groupBoxInPutData_STS
            // 
            this.groupBoxInPutData_STS.Controls.Add(this.labelStopStep_STS);
            this.groupBoxInPutData_STS.Controls.Add(this.labelStartStep_STS);
            this.groupBoxInPutData_STS.Controls.Add(this.textBoxStopStep_STS);
            this.groupBoxInPutData_STS.Controls.Add(this.textBoxStartStep_STS);
            this.groupBoxInPutData_STS.Location = new System.Drawing.Point(485, 13);
            this.groupBoxInPutData_STS.Name = "groupBoxInPutData_STS";
            this.groupBoxInPutData_STS.Size = new System.Drawing.Size(305, 117);
            this.groupBoxInPutData_STS.TabIndex = 1;
            this.groupBoxInPutData_STS.TabStop = false;
            this.groupBoxInPutData_STS.Text = "Ввод данных:";
            // 
            // textBoxStartStep_STS
            // 
            this.textBoxStartStep_STS.Location = new System.Drawing.Point(6, 63);
            this.textBoxStartStep_STS.Name = "textBoxStartStep_STS";
            this.textBoxStartStep_STS.Size = new System.Drawing.Size(118, 26);
            this.textBoxStartStep_STS.TabIndex = 0;
            this.textBoxStartStep_STS.Text = "-5";
            this.textBoxStartStep_STS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_STS_KeyPress);
            // 
            // textBoxStopStep_STS
            // 
            this.textBoxStopStep_STS.Location = new System.Drawing.Point(172, 63);
            this.textBoxStopStep_STS.Name = "textBoxStopStep_STS";
            this.textBoxStopStep_STS.Size = new System.Drawing.Size(118, 26);
            this.textBoxStopStep_STS.TabIndex = 0;
            this.textBoxStopStep_STS.Text = "5";
            this.textBoxStopStep_STS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_STS_KeyPress);
            // 
            // labelStartStep_STS
            // 
            this.labelStartStep_STS.AutoSize = true;
            this.labelStartStep_STS.Location = new System.Drawing.Point(6, 40);
            this.labelStartStep_STS.Name = "labelStartStep_STS";
            this.labelStartStep_STS.Size = new System.Drawing.Size(102, 20);
            this.labelStartStep_STS.TabIndex = 1;
            this.labelStartStep_STS.Text = "Старт шага:";
            // 
            // labelStopStep_STS
            // 
            this.labelStopStep_STS.AutoSize = true;
            this.labelStopStep_STS.Location = new System.Drawing.Point(177, 40);
            this.labelStopStep_STS.Name = "labelStopStep_STS";
            this.labelStopStep_STS.Size = new System.Drawing.Size(101, 20);
            this.labelStopStep_STS.TabIndex = 1;
            this.labelStopStep_STS.Text = "Конец шага:";
            // 
            // buttonDone_STS
            // 
            this.buttonDone_STS.BackColor = System.Drawing.Color.Green;
            this.buttonDone_STS.Location = new System.Drawing.Point(796, 24);
            this.buttonDone_STS.Name = "buttonDone_STS";
            this.buttonDone_STS.Size = new System.Drawing.Size(111, 100);
            this.buttonDone_STS.TabIndex = 2;
            this.buttonDone_STS.Text = "Выполнить";
            this.buttonDone_STS.UseVisualStyleBackColor = false;
            this.buttonDone_STS.Click += new System.EventHandler(this.buttonDone_STS_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(913, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 100);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonHelp_STS
            // 
            this.buttonHelp_STS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_STS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_STS.Location = new System.Drawing.Point(1024, 24);
            this.buttonHelp_STS.Name = "buttonHelp_STS";
            this.buttonHelp_STS.Size = new System.Drawing.Size(99, 100);
            this.buttonHelp_STS.TabIndex = 2;
            this.buttonHelp_STS.Text = "Справка";
            this.buttonHelp_STS.UseVisualStyleBackColor = false;
            this.buttonHelp_STS.Click += new System.EventHandler(this.buttonHelp_STS_Click);
            // 
            // groupBoxOutPutData_STS
            // 
            this.groupBoxOutPutData_STS.Controls.Add(this.textBoxOutPutData_STS);
            this.groupBoxOutPutData_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_STS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_STS.Name = "groupBoxOutPutData_STS";
            this.groupBoxOutPutData_STS.Size = new System.Drawing.Size(222, 429);
            this.groupBoxOutPutData_STS.TabIndex = 0;
            this.groupBoxOutPutData_STS.TabStop = false;
            this.groupBoxOutPutData_STS.Text = "Вывод данных:";
            // 
            // textBoxOutPutData_STS
            // 
            this.textBoxOutPutData_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPutData_STS.Location = new System.Drawing.Point(3, 22);
            this.textBoxOutPutData_STS.Multiline = true;
            this.textBoxOutPutData_STS.Name = "textBoxOutPutData_STS";
            this.textBoxOutPutData_STS.ReadOnly = true;
            this.textBoxOutPutData_STS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPutData_STS.Size = new System.Drawing.Size(216, 404);
            this.textBoxOutPutData_STS.TabIndex = 0;
            // 
            // chartFunction_STS
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_STS.ChartAreas.Add(chartArea2);
            this.chartFunction_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartFunction_STS.Legends.Add(legend2);
            this.chartFunction_STS.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_STS.Name = "chartFunction_STS";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_STS.Series.Add(series2);
            this.chartFunction_STS.Size = new System.Drawing.Size(910, 429);
            this.chartFunction_STS.TabIndex = 0;
            this.chartFunction_STS.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 562);
            this.Controls.Add(this.panelFill_STS);
            this.Controls.Add(this.splitterMain_STS);
            this.Controls.Add(this.panelLeft_STS);
            this.Controls.Add(this.panelTop_STS);
            this.MinimumSize = new System.Drawing.Size(1157, 618);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 24 | Шустов Т.С.";
            this.panelTop_STS.ResumeLayout(false);
            this.panelLeft_STS.ResumeLayout(false);
            this.panelFill_STS.ResumeLayout(false);
            this.groupBoxTask_STS.ResumeLayout(false);
            this.groupBoxTask_STS.PerformLayout();
            this.groupBoxInPutData_STS.ResumeLayout(false);
            this.groupBoxInPutData_STS.PerformLayout();
            this.groupBoxOutPutData_STS.ResumeLayout(false);
            this.groupBoxOutPutData_STS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_STS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_STS;
        private System.Windows.Forms.Panel panelLeft_STS;
        private System.Windows.Forms.Splitter splitterMain_STS;
        private System.Windows.Forms.Panel panelFill_STS;
        private System.Windows.Forms.GroupBox groupBoxInPutData_STS;
        private System.Windows.Forms.Label labelStopStep_STS;
        private System.Windows.Forms.Label labelStartStep_STS;
        private System.Windows.Forms.TextBox textBoxStopStep_STS;
        private System.Windows.Forms.TextBox textBoxStartStep_STS;
        private System.Windows.Forms.GroupBox groupBoxTask_STS;
        private System.Windows.Forms.TextBox textBoxTask_STS;
        private System.Windows.Forms.Button buttonDone_STS;
        private System.Windows.Forms.Button buttonHelp_STS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_STS;
        private System.Windows.Forms.TextBox textBoxOutPutData_STS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_STS;
    }
}

