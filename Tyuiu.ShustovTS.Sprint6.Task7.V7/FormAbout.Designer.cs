
namespace Tyuiu.ShustovTS.Sprint6.Task7.V7
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonOK_STS = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_STS = new System.Windows.Forms.PictureBox();
            this.textBoxAbout_STS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_STS)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_STS
            // 
            this.buttonOK_STS.Location = new System.Drawing.Point(683, 376);
            this.buttonOK_STS.Name = "buttonOK_STS";
            this.buttonOK_STS.Size = new System.Drawing.Size(105, 62);
            this.buttonOK_STS.TabIndex = 1;
            this.buttonOK_STS.Text = "OK";
            this.buttonOK_STS.UseVisualStyleBackColor = true;
            this.buttonOK_STS.Click += new System.EventHandler(this.buttonOK_STS_Click);
            // 
            // pictureBoxAvatar_STS
            // 
            this.pictureBoxAvatar_STS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_STS.Image")));
            this.pictureBoxAvatar_STS.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_STS.Name = "pictureBoxAvatar_STS";
            this.pictureBoxAvatar_STS.Size = new System.Drawing.Size(165, 206);
            this.pictureBoxAvatar_STS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_STS.TabIndex = 2;
            this.pictureBoxAvatar_STS.TabStop = false;
            // 
            // textBoxAbout_STS
            // 
            this.textBoxAbout_STS.Location = new System.Drawing.Point(184, 12);
            this.textBoxAbout_STS.Multiline = true;
            this.textBoxAbout_STS.Name = "textBoxAbout_STS";
            this.textBoxAbout_STS.ReadOnly = true;
            this.textBoxAbout_STS.Size = new System.Drawing.Size(604, 206);
            this.textBoxAbout_STS.TabIndex = 3;
            this.textBoxAbout_STS.Text = resources.GetString("textBoxAbout_STS.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAbout_STS);
            this.Controls.Add(this.pictureBoxAvatar_STS);
            this.Controls.Add(this.buttonOK_STS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О разработчике";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_STS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_STS;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_STS;
        private System.Windows.Forms.TextBox textBoxAbout_STS;
    }
}