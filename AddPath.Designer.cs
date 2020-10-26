namespace Video_Processors
{
    partial class AddPath
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
            this.txtpath = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpath
            // 
            this.txtpath.Location = new System.Drawing.Point(12, 25);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(302, 20);
            this.txtpath.TabIndex = 0;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(320, 23);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(46, 23);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // AddPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 66);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtpath);
            this.Name = "AddPath";
            this.Text = "AddPath";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Button btnok;
    }
}