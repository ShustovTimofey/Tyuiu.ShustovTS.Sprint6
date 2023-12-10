
namespace Tyuiu.ShustovTS.Sprint6.Task6.V8
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
            this.groupBoxTask_STS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_STS = new System.Windows.Forms.TextBox();
            this.buttonDone_STS = new System.Windows.Forms.Button();
            this.buttonOpenFile_STS = new System.Windows.Forms.Button();
            this.buttonAbout_STS = new System.Windows.Forms.Button();
            this.panelLeft_STS = new System.Windows.Forms.Panel();
            this.groupBoxInPutData_STS = new System.Windows.Forms.GroupBox();
            this.textBoxInPutData_STS = new System.Windows.Forms.TextBox();
            this.splitterMain_STS = new System.Windows.Forms.Splitter();
            this.panelFill_STS = new System.Windows.Forms.Panel();
            this.groupBoxOutPutData_STS = new System.Windows.Forms.GroupBox();
            this.textBoxOutPutData_STS = new System.Windows.Forms.TextBox();
            this.openFileDialog_STS = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_STS = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_STS.SuspendLayout();
            this.groupBoxTask_STS.SuspendLayout();
            this.panelLeft_STS.SuspendLayout();
            this.groupBoxInPutData_STS.SuspendLayout();
            this.panelFill_STS.SuspendLayout();
            this.groupBoxOutPutData_STS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_STS
            // 
            this.panelTop_STS.Controls.Add(this.groupBoxTask_STS);
            this.panelTop_STS.Controls.Add(this.buttonDone_STS);
            this.panelTop_STS.Controls.Add(this.buttonOpenFile_STS);
            this.panelTop_STS.Controls.Add(this.buttonAbout_STS);
            this.panelTop_STS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_STS.Location = new System.Drawing.Point(0, 0);
            this.panelTop_STS.Name = "panelTop_STS";
            this.panelTop_STS.Size = new System.Drawing.Size(993, 198);
            this.panelTop_STS.TabIndex = 0;
            // 
            // groupBoxTask_STS
            // 
            this.groupBoxTask_STS.Controls.Add(this.textBoxTask_STS);
            this.groupBoxTask_STS.Location = new System.Drawing.Point(13, 86);
            this.groupBoxTask_STS.Name = "groupBoxTask_STS";
            this.groupBoxTask_STS.Size = new System.Drawing.Size(968, 100);
            this.groupBoxTask_STS.TabIndex = 2;
            this.groupBoxTask_STS.TabStop = false;
            this.groupBoxTask_STS.Text = "Условие:";
            // 
            // textBoxTask_STS
            // 
            this.textBoxTask_STS.Location = new System.Drawing.Point(7, 26);
            this.textBoxTask_STS.Multiline = true;
            this.textBoxTask_STS.Name = "textBoxTask_STS";
            this.textBoxTask_STS.ReadOnly = true;
            this.textBoxTask_STS.Size = new System.Drawing.Size(955, 68);
            this.textBoxTask_STS.TabIndex = 0;
            this.textBoxTask_STS.Text = resources.GetString("textBoxTask_STS.Text");
            // 
            // buttonDone_STS
            // 
            this.buttonDone_STS.Enabled = false;
            this.buttonDone_STS.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_STS.Image")));
            this.buttonDone_STS.Location = new System.Drawing.Point(94, 13);
            this.buttonDone_STS.Name = "buttonDone_STS";
            this.buttonDone_STS.Size = new System.Drawing.Size(75, 66);
            this.buttonDone_STS.TabIndex = 1;
            this.toolTip_STS.SetToolTip(this.buttonDone_STS, "Производит поиск слов, в которых встречается \"z\" и выводит их");
            this.buttonDone_STS.UseVisualStyleBackColor = true;
            this.buttonDone_STS.Click += new System.EventHandler(this.buttonDone_STS_Click);
            // 
            // buttonOpenFile_STS
            // 
            this.buttonOpenFile_STS.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_STS.Image")));
            this.buttonOpenFile_STS.Location = new System.Drawing.Point(13, 13);
            this.buttonOpenFile_STS.Name = "buttonOpenFile_STS";
            this.buttonOpenFile_STS.Size = new System.Drawing.Size(75, 66);
            this.buttonOpenFile_STS.TabIndex = 1;
            this.toolTip_STS.SetToolTip(this.buttonOpenFile_STS, "Открыть файл\r\nВыберите нужный файл для обработки данных");
            this.buttonOpenFile_STS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_STS.Click += new System.EventHandler(this.buttonOpenFile_STS_Click);
            // 
            // buttonAbout_STS
            // 
            this.buttonAbout_STS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout_STS.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout_STS.Image")));
            this.buttonAbout_STS.Location = new System.Drawing.Point(906, 12);
            this.buttonAbout_STS.Name = "buttonAbout_STS";
            this.buttonAbout_STS.Size = new System.Drawing.Size(75, 67);
            this.buttonAbout_STS.TabIndex = 0;
            this.toolTip_STS.SetToolTip(this.buttonAbout_STS, "Сведения о программе");
            this.buttonAbout_STS.UseVisualStyleBackColor = true;
            this.buttonAbout_STS.Click += new System.EventHandler(this.buttonAbout_STS_Click);
            // 
            // panelLeft_STS
            // 
            this.panelLeft_STS.Controls.Add(this.groupBoxInPutData_STS);
            this.panelLeft_STS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_STS.Location = new System.Drawing.Point(0, 198);
            this.panelLeft_STS.Name = "panelLeft_STS";
            this.panelLeft_STS.Size = new System.Drawing.Size(456, 449);
            this.panelLeft_STS.TabIndex = 1;
            // 
            // groupBoxInPutData_STS
            // 
            this.groupBoxInPutData_STS.Controls.Add(this.textBoxInPutData_STS);
            this.groupBoxInPutData_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPutData_STS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPutData_STS.Name = "groupBoxInPutData_STS";
            this.groupBoxInPutData_STS.Size = new System.Drawing.Size(456, 449);
            this.groupBoxInPutData_STS.TabIndex = 0;
            this.groupBoxInPutData_STS.TabStop = false;
            this.groupBoxInPutData_STS.Text = "Ввод:";
            // 
            // textBoxInPutData_STS
            // 
            this.textBoxInPutData_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInPutData_STS.Location = new System.Drawing.Point(3, 22);
            this.textBoxInPutData_STS.Multiline = true;
            this.textBoxInPutData_STS.Name = "textBoxInPutData_STS";
            this.textBoxInPutData_STS.ReadOnly = true;
            this.textBoxInPutData_STS.Size = new System.Drawing.Size(450, 424);
            this.textBoxInPutData_STS.TabIndex = 0;
            // 
            // splitterMain_STS
            // 
            this.splitterMain_STS.Location = new System.Drawing.Point(456, 198);
            this.splitterMain_STS.Name = "splitterMain_STS";
            this.splitterMain_STS.Size = new System.Drawing.Size(3, 449);
            this.splitterMain_STS.TabIndex = 2;
            this.splitterMain_STS.TabStop = false;
            // 
            // panelFill_STS
            // 
            this.panelFill_STS.Controls.Add(this.groupBoxOutPutData_STS);
            this.panelFill_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_STS.Location = new System.Drawing.Point(459, 198);
            this.panelFill_STS.Name = "panelFill_STS";
            this.panelFill_STS.Size = new System.Drawing.Size(534, 449);
            this.panelFill_STS.TabIndex = 3;
            // 
            // groupBoxOutPutData_STS
            // 
            this.groupBoxOutPutData_STS.Controls.Add(this.textBoxOutPutData_STS);
            this.groupBoxOutPutData_STS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutData_STS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutData_STS.Name = "groupBoxOutPutData_STS";
            this.groupBoxOutPutData_STS.Size = new System.Drawing.Size(534, 449);
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
            this.textBoxOutPutData_STS.Size = new System.Drawing.Size(528, 424);
            this.textBoxOutPutData_STS.TabIndex = 0;
            // 
            // openFileDialog_STS
            // 
            this.openFileDialog_STS.FileName = "openFileDialog1";
            this.openFileDialog_STS.Title = "Открыть файл";
            // 
            // toolTip_STS
            // 
            this.toolTip_STS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_STS.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 647);
            this.Controls.Add(this.panelFill_STS);
            this.Controls.Add(this.splitterMain_STS);
            this.Controls.Add(this.panelLeft_STS);
            this.Controls.Add(this.panelTop_STS);
            this.MinimumSize = new System.Drawing.Size(1015, 703);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 8 | Шустов Т.С.";
            this.panelTop_STS.ResumeLayout(false);
            this.groupBoxTask_STS.ResumeLayout(false);
            this.groupBoxTask_STS.PerformLayout();
            this.panelLeft_STS.ResumeLayout(false);
            this.groupBoxInPutData_STS.ResumeLayout(false);
            this.groupBoxInPutData_STS.PerformLayout();
            this.panelFill_STS.ResumeLayout(false);
            this.groupBoxOutPutData_STS.ResumeLayout(false);
            this.groupBoxOutPutData_STS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_STS;
        private System.Windows.Forms.Panel panelLeft_STS;
        private System.Windows.Forms.Splitter splitterMain_STS;
        private System.Windows.Forms.Panel panelFill_STS;
        private System.Windows.Forms.Button buttonDone_STS;
        private System.Windows.Forms.Button buttonOpenFile_STS;
        private System.Windows.Forms.Button buttonAbout_STS;
        private System.Windows.Forms.GroupBox groupBoxTask_STS;
        private System.Windows.Forms.TextBox textBoxTask_STS;
        private System.Windows.Forms.GroupBox groupBoxInPutData_STS;
        private System.Windows.Forms.TextBox textBoxInPutData_STS;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_STS;
        private System.Windows.Forms.TextBox textBoxOutPutData_STS;
        private System.Windows.Forms.OpenFileDialog openFileDialog_STS;
        private System.Windows.Forms.ToolTip toolTip_STS;
    }
}

