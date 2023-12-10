
namespace Tyuiu.ShustovTS.Sprint6.Task7.V7
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_STS = new System.Windows.Forms.Panel();
            this.panelLeft_STS = new System.Windows.Forms.Panel();
            this.splitterMain_STS = new System.Windows.Forms.Splitter();
            this.panelFill_STS = new System.Windows.Forms.Panel();
            this.buttonOpenFile_STS = new System.Windows.Forms.Button();
            this.buttonDone_STS = new System.Windows.Forms.Button();
            this.buttonAbout_STS = new System.Windows.Forms.Button();
            this.buttonSave_STS = new System.Windows.Forms.Button();
            this.groupBoxTask_STS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_STS = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_STS = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPutData_STS = new System.Windows.Forms.DataGridView();
            this.groupBoxOutPutData_STS = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPutData_STS = new System.Windows.Forms.DataGridView();
            this.openFileDialog_STS = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_STS = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog_STS = new System.Windows.Forms.SaveFileDialog();
            this.panelTop_STS.SuspendLayout();
            this.panelLeft_STS.SuspendLayout();
            this.panelFill_STS.SuspendLayout();
            this.groupBoxTask_STS.SuspendLayout();
            this.groupBoxInPutData_STS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_STS)).BeginInit();
            this.groupBoxOutPutData_STS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_STS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_STS
            // 
            this.panelTop_STS.Controls.Add(this.groupBoxTask_STS);
            this.panelTop_STS.Controls.Add(this.buttonSave_STS);
            this.panelTop_STS.Controls.Add(this.buttonAbout_STS);
            this.panelTop_STS.Controls.Add(this.buttonDone_STS);
            this.panelTop_STS.Controls.Add(this.buttonOpenFile_STS);
            this.panelTop_STS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_STS.Location = new System.Drawing.Point(0, 0);
            this.panelTop_STS.Name = "panelTop_STS";
            this.panelTop_STS.Size = new System.Drawing.Size(1028, 236);
            this.panelTop_STS.TabIndex = 0;
            // 
            // panelLeft_STS
            // 
            this.panelLeft_STS.Controls.Add(this.groupBoxInPutData_STS);
            this.panelLeft_STS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_STS.Location = new System.Drawing.Point(0, 236);
            this.panelLeft_STS.Name = "panelLeft_STS";
            this.panelLeft_STS.Size = new System.Drawing.Size(476, 440);
            this.panelLeft_STS.TabIndex = 1;
            // 
            // splitterMain_STS
            // 
            this.splitterMain_STS.Location = new System.Drawing.Point(476, 236);
            this.splitterMain_STS.Name = "splitterMain_STS";
            this.splitterMain_STS.Size = new System.Drawing.Size(3, 440);
            this.splitterMain_STS.TabIndex = 2;
            this.splitterMain_STS.TabStop = false;
            // 
            // panelFill_STS
            // 
            this.panelFill_STS.Controls.Add(this.groupBoxOutPutData_STS);
            this.panelFill_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_STS.Location = new System.Drawing.Point(479, 236);
            this.panelFill_STS.Name = "panelFill_STS";
            this.panelFill_STS.Size = new System.Drawing.Size(549, 440);
            this.panelFill_STS.TabIndex = 3;
            // 
            // buttonOpenFile_STS
            // 
            this.buttonOpenFile_STS.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_STS.Image")));
            this.buttonOpenFile_STS.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_STS.Name = "buttonOpenFile_STS";
            this.buttonOpenFile_STS.Size = new System.Drawing.Size(75, 66);
            this.buttonOpenFile_STS.TabIndex = 2;
            this.toolTip_STS.SetToolTip(this.buttonOpenFile_STS, "Открыть файл для обработки в формате CSV");
            this.buttonOpenFile_STS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_STS.Click += new System.EventHandler(this.buttonOpenFile_STS_Click);
            this.buttonOpenFile_STS.MouseEnter += new System.EventHandler(this.buttonOpenFile_STS_MouseEnter);
            // 
            // buttonDone_STS
            // 
            this.buttonDone_STS.Enabled = false;
            this.buttonDone_STS.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_STS.Image")));
            this.buttonDone_STS.Location = new System.Drawing.Point(93, 12);
            this.buttonDone_STS.Name = "buttonDone_STS";
            this.buttonDone_STS.Size = new System.Drawing.Size(75, 66);
            this.buttonDone_STS.TabIndex = 3;
            this.toolTip_STS.SetToolTip(this.buttonDone_STS, "Выполнить обработку данных");
            this.buttonDone_STS.UseVisualStyleBackColor = true;
            this.buttonDone_STS.Click += new System.EventHandler(this.buttonDone_STS_Click);
            this.buttonDone_STS.MouseEnter += new System.EventHandler(this.buttonDone_STS_MouseEnter);
            // 
            // buttonAbout_STS
            // 
            this.buttonAbout_STS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout_STS.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout_STS.Image")));
            this.buttonAbout_STS.Location = new System.Drawing.Point(941, 11);
            this.buttonAbout_STS.Name = "buttonAbout_STS";
            this.buttonAbout_STS.Size = new System.Drawing.Size(75, 67);
            this.buttonAbout_STS.TabIndex = 4;
            this.toolTip_STS.SetToolTip(this.buttonAbout_STS, "Сведения о программе");
            this.buttonAbout_STS.UseVisualStyleBackColor = true;
            this.buttonAbout_STS.Click += new System.EventHandler(this.buttonAbout_STS_Click);
            this.buttonAbout_STS.MouseEnter += new System.EventHandler(this.buttonAbout_STS_MouseEnter);
            // 
            // buttonSave_STS
            // 
            this.buttonSave_STS.Enabled = false;
            this.buttonSave_STS.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_STS.Image")));
            this.buttonSave_STS.Location = new System.Drawing.Point(174, 12);
            this.buttonSave_STS.Name = "buttonSave_STS";
            this.buttonSave_STS.Size = new System.Drawing.Size(75, 66);
            this.buttonSave_STS.TabIndex = 5;
            this.buttonSave_STS.Text = "\r\n";
            this.buttonSave_STS.UseVisualStyleBackColor = true;
            this.buttonSave_STS.Click += new System.EventHandler(this.buttonSave_STS_Click);
            this.buttonSave_STS.MouseEnter += new System.EventHandler(this.buttonSave_STS_MouseEnter);
            // 
            // groupBoxTask_STS
            // 
            this.groupBoxTask_STS.Controls.Add(this.textBoxTask_STS);
            this.groupBoxTask_STS.Location = new System.Drawing.Point(13, 85);
            this.groupBoxTask_STS.Name = "groupBoxTask_STS";
            this.groupBoxTask_STS.Size = new System.Drawing.Size(929, 145);
            this.groupBoxTask_STS.TabIndex = 6;
            this.groupBoxTask_STS.TabStop = false;
            this.groupBoxTask_STS.Text = "Условие:";
            // 
            // textBoxTask_STS
            // 
            this.textBoxTask_STS.Location = new System.Drawing.Point(7, 26);
            this.textBoxTask_STS.Multiline = true;
            this.textBoxTask_STS.Name = "textBoxTask_STS";
            this.textBoxTask_STS.ReadOnly = true;
            this.textBoxTask_STS.Size = new System.Drawing.Size(916, 113);
            this.textBoxTask_STS.TabIndex = 0;
            this.textBoxTask_STS.Text = resources.GetString("textBoxTask_STS.Text");
            // 
            // groupBoxInPutData_STS
            // 
            this.groupBoxInPutData_STS.Controls.Add(this.dataGridViewInPutData_STS);
            this.groupBoxInPutData_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPutData_STS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPutData_STS.Name = "groupBoxInPutData_STS";
            this.groupBoxInPutData_STS.Size = new System.Drawing.Size(476, 440);
            this.groupBoxInPutData_STS.TabIndex = 0;
            this.groupBoxInPutData_STS.TabStop = false;
            this.groupBoxInPutData_STS.Text = "Ввод данных:";
            // 
            // dataGridViewInPutData_STS
            // 
            this.dataGridViewInPutData_STS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPutData_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPutData_STS.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewInPutData_STS.Name = "dataGridViewInPutData_STS";
            this.dataGridViewInPutData_STS.RowHeadersVisible = false;
            this.dataGridViewInPutData_STS.RowHeadersWidth = 62;
            this.dataGridViewInPutData_STS.RowTemplate.Height = 28;
            this.dataGridViewInPutData_STS.Size = new System.Drawing.Size(470, 415);
            this.dataGridViewInPutData_STS.TabIndex = 0;
            // 
            // groupBoxOutPutData_STS
            // 
            this.groupBoxOutPutData_STS.Controls.Add(this.dataGridViewOutPutData_STS);
            this.groupBoxOutPutData_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_STS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_STS.Name = "groupBoxOutPutData_STS";
            this.groupBoxOutPutData_STS.Size = new System.Drawing.Size(549, 440);
            this.groupBoxOutPutData_STS.TabIndex = 0;
            this.groupBoxOutPutData_STS.TabStop = false;
            this.groupBoxOutPutData_STS.Text = "Вывод данных:";
            // 
            // dataGridViewOutPutData_STS
            // 
            this.dataGridViewOutPutData_STS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutData_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPutData_STS.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewOutPutData_STS.Name = "dataGridViewOutPutData_STS";
            this.dataGridViewOutPutData_STS.RowHeadersVisible = false;
            this.dataGridViewOutPutData_STS.RowHeadersWidth = 62;
            this.dataGridViewOutPutData_STS.RowTemplate.Height = 28;
            this.dataGridViewOutPutData_STS.Size = new System.Drawing.Size(543, 415);
            this.dataGridViewOutPutData_STS.TabIndex = 0;
            this.toolTip_STS.SetToolTip(this.dataGridViewOutPutData_STS, "Сохранить обработанные данные в файл в формате CSV");
            // 
            // openFileDialog_STS
            // 
            this.openFileDialog_STS.FileName = "openFileDialog1";
            // 
            // toolTip_STS
            // 
            this.toolTip_STS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 676);
            this.Controls.Add(this.panelFill_STS);
            this.Controls.Add(this.splitterMain_STS);
            this.Controls.Add(this.panelLeft_STS);
            this.Controls.Add(this.panelTop_STS);
            this.MinimumSize = new System.Drawing.Size(1050, 732);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 7 | Шустов Т.С.";
            this.panelTop_STS.ResumeLayout(false);
            this.panelLeft_STS.ResumeLayout(false);
            this.panelFill_STS.ResumeLayout(false);
            this.groupBoxTask_STS.ResumeLayout(false);
            this.groupBoxTask_STS.PerformLayout();
            this.groupBoxInPutData_STS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_STS)).EndInit();
            this.groupBoxOutPutData_STS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_STS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_STS;
        private System.Windows.Forms.Panel panelLeft_STS;
        private System.Windows.Forms.Splitter splitterMain_STS;
        private System.Windows.Forms.Panel panelFill_STS;
        private System.Windows.Forms.Button buttonOpenFile_STS;
        private System.Windows.Forms.Button buttonDone_STS;
        private System.Windows.Forms.Button buttonAbout_STS;
        private System.Windows.Forms.Button buttonSave_STS;
        private System.Windows.Forms.GroupBox groupBoxTask_STS;
        private System.Windows.Forms.TextBox textBoxTask_STS;
        private System.Windows.Forms.GroupBox groupBoxInPutData_STS;
        private System.Windows.Forms.DataGridView dataGridViewInPutData_STS;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_STS;
        private System.Windows.Forms.DataGridView dataGridViewOutPutData_STS;
        private System.Windows.Forms.ToolTip toolTip_STS;
        private System.Windows.Forms.OpenFileDialog openFileDialog_STS;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_STS;
    }
}

