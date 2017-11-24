namespace task_3
{
    partial class Form1
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
            this.btnCreatFile = new System.Windows.Forms.Button();
            this.ShablonInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreatFile
            // 
            this.btnCreatFile.Location = new System.Drawing.Point(12, 265);
            this.btnCreatFile.Name = "btnCreatFile";
            this.btnCreatFile.Size = new System.Drawing.Size(259, 153);
            this.btnCreatFile.TabIndex = 0;
            this.btnCreatFile.Text = "Создать Заявление";
            this.btnCreatFile.UseVisualStyleBackColor = true;
            this.btnCreatFile.Click += new System.EventHandler(this.btnCreatFile_Click);
            // 
            // ShablonInfo
            // 
            this.ShablonInfo.Location = new System.Drawing.Point(291, 13);
            this.ShablonInfo.Multiline = true;
            this.ShablonInfo.Name = "ShablonInfo";
            this.ShablonInfo.Size = new System.Drawing.Size(587, 560);
            this.ShablonInfo.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 574);
            this.Controls.Add(this.ShablonInfo);
            this.Controls.Add(this.btnCreatFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreatFile;
        private System.Windows.Forms.TextBox ShablonInfo;
    }
}

