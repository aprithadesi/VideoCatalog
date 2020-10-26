namespace Video_Processors
{
    partial class Loaders
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem11 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem12 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem13 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem14 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_pro = new System.Windows.Forms.Button();
            this.btn_pre = new System.Windows.Forms.Button();
            this.btn_copyonly = new System.Windows.Forms.Button();
            this.btn_both = new System.Windows.Forms.Button();
            this.btn_panic = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.btn_rbc = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_pre = new System.Windows.Forms.Label();
            this.lbl_pro = new System.Windows.Forms.Label();
            this.lbl_copy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_thumbgen = new System.Windows.Forms.Button();
            this.btnaddpath = new System.Windows.Forms.Button();
            this.dtptime = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.ddltype = new Telerik.WinControls.UI.RadDropDownList();
            this.ddlcategory = new Telerik.WinControls.UI.RadDropDownList();
            this.txtname = new Telerik.WinControls.UI.RadTextBox();
            this.btn_mst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddltype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlcategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(12, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 314);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textbox1_dragdrop);
            this.textBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.textbox1_dragover);
            // 
            // btn_pro
            // 
            this.btn_pro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_pro.Location = new System.Drawing.Point(529, 207);
            this.btn_pro.Name = "btn_pro";
            this.btn_pro.Size = new System.Drawing.Size(132, 79);
            this.btn_pro.TabIndex = 2;
            this.btn_pro.Text = "PRO";
            this.btn_pro.UseVisualStyleBackColor = false;
            this.btn_pro.Click += new System.EventHandler(this.btn_pro_Click);
            // 
            // btn_pre
            // 
            this.btn_pre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_pre.Location = new System.Drawing.Point(381, 208);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(132, 79);
            this.btn_pre.TabIndex = 3;
            this.btn_pre.Text = "PRE";
            this.btn_pre.UseVisualStyleBackColor = false;
            this.btn_pre.Click += new System.EventHandler(this.btn__Click);
            // 
            // btn_copyonly
            // 
            this.btn_copyonly.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_copyonly.Location = new System.Drawing.Point(358, 122);
            this.btn_copyonly.Name = "btn_copyonly";
            this.btn_copyonly.Size = new System.Drawing.Size(322, 79);
            this.btn_copyonly.TabIndex = 4;
            this.btn_copyonly.Text = "Copy";
            this.btn_copyonly.UseVisualStyleBackColor = false;
            this.btn_copyonly.Click += new System.EventHandler(this.Btn_copyonly_Click);
            // 
            // btn_both
            // 
            this.btn_both.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_both.Location = new System.Drawing.Point(358, 293);
            this.btn_both.Name = "btn_both";
            this.btn_both.Size = new System.Drawing.Size(322, 87);
            this.btn_both.TabIndex = 5;
            this.btn_both.Text = "Both";
            this.btn_both.UseVisualStyleBackColor = false;
            this.btn_both.Click += new System.EventHandler(this.Btn_both_Click);
            // 
            // btn_panic
            // 
            this.btn_panic.BackColor = System.Drawing.Color.Red;
            this.btn_panic.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btn_panic.FlatAppearance.BorderSize = 3;
            this.btn_panic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_panic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_panic.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_panic.Location = new System.Drawing.Point(12, 386);
            this.btn_panic.Name = "btn_panic";
            this.btn_panic.Size = new System.Drawing.Size(426, 79);
            this.btn_panic.TabIndex = 6;
            this.btn_panic.Text = "PANIC";
            this.btn_panic.UseVisualStyleBackColor = false;
            this.btn_panic.Click += new System.EventHandler(this.Btn_panic_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(46, 13);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(75, 23);
            this.btn_clr.TabIndex = 7;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // btn_rbc
            // 
            this.btn_rbc.Location = new System.Drawing.Point(165, 13);
            this.btn_rbc.Name = "btn_rbc";
            this.btn_rbc.Size = new System.Drawing.Size(151, 23);
            this.btn_rbc.TabIndex = 8;
            this.btn_rbc.Text = "Recycle Bin + Clear";
            this.btn_rbc.UseVisualStyleBackColor = true;
            this.btn_rbc.Click += new System.EventHandler(this.btn_rbc_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 679);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1419, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_pre
            // 
            this.lbl_pre.AutoSize = true;
            this.lbl_pre.Location = new System.Drawing.Point(1137, 45);
            this.lbl_pre.Name = "lbl_pre";
            this.lbl_pre.Size = new System.Drawing.Size(35, 13);
            this.lbl_pre.TabIndex = 10;
            this.lbl_pre.Text = "label1";
            // 
            // lbl_pro
            // 
            this.lbl_pro.AutoSize = true;
            this.lbl_pro.Location = new System.Drawing.Point(1148, 127);
            this.lbl_pro.Name = "lbl_pro";
            this.lbl_pro.Size = new System.Drawing.Size(35, 13);
            this.lbl_pro.TabIndex = 11;
            this.lbl_pro.Text = "label1";
            // 
            // lbl_copy
            // 
            this.lbl_copy.AutoSize = true;
            this.lbl_copy.Location = new System.Drawing.Point(1148, 214);
            this.lbl_copy.Name = "lbl_copy";
            this.lbl_copy.Size = new System.Drawing.Size(35, 13);
            this.lbl_copy.TabIndex = 12;
            this.lbl_copy.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(704, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 318);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btn_thumbgen
            // 
            this.btn_thumbgen.Location = new System.Drawing.Point(704, 24);
            this.btn_thumbgen.Name = "btn_thumbgen";
            this.btn_thumbgen.Size = new System.Drawing.Size(75, 23);
            this.btn_thumbgen.TabIndex = 14;
            this.btn_thumbgen.Text = "Thumb Gen";
            this.btn_thumbgen.UseVisualStyleBackColor = true;
            this.btn_thumbgen.Click += new System.EventHandler(this.btn_thumbgen_Click);
            // 
            // btnaddpath
            // 
            this.btnaddpath.Location = new System.Drawing.Point(785, 24);
            this.btnaddpath.Name = "btnaddpath";
            this.btnaddpath.Size = new System.Drawing.Size(164, 23);
            this.btnaddpath.TabIndex = 15;
            this.btnaddpath.Text = "MPC-HC Path";
            this.btnaddpath.UseVisualStyleBackColor = true;
            this.btnaddpath.Click += new System.EventHandler(this.btnaddpath_Click_1);
            // 
            // dtptime
            // 
            this.dtptime.Location = new System.Drawing.Point(977, 26);
            this.dtptime.Name = "dtptime";
            this.dtptime.Size = new System.Drawing.Size(105, 20);
            this.dtptime.TabIndex = 16;
            this.dtptime.Text = "00:00:00";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(853, 386);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(132, 32);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // ddltype
            // 
            radListDataItem1.Text = "PRE";
            radListDataItem2.Text = "PRO";
            radListDataItem11.Text = "Creampie";
            radListDataItem12.Text = "PRE MUST";
            radListDataItem13.Text = "PRO MUST";
            radListDataItem14.Text = "Force";
            this.ddltype.Items.Add(radListDataItem1);
            this.ddltype.Items.Add(radListDataItem2);
            this.ddltype.Items.Add(radListDataItem11);
            this.ddltype.Items.Add(radListDataItem12);
            this.ddltype.Items.Add(radListDataItem13);
            this.ddltype.Items.Add(radListDataItem14);
            this.ddltype.Location = new System.Drawing.Point(1241, 120);
            this.ddltype.Name = "ddltype";
            this.ddltype.Size = new System.Drawing.Size(125, 20);
            this.ddltype.TabIndex = 18;
            // 
            // ddlcategory
            // 
            radListDataItem3.Text = "General";
            radListDataItem4.Text = "ACTOR";
            this.ddlcategory.Items.Add(radListDataItem3);
            this.ddlcategory.Items.Add(radListDataItem4);
            this.ddlcategory.Location = new System.Drawing.Point(1241, 207);
            this.ddlcategory.Name = "ddlcategory";
            this.ddlcategory.Size = new System.Drawing.Size(125, 20);
            this.ddlcategory.TabIndex = 19;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(1137, 71);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(258, 20);
            this.txtname.TabIndex = 20;
            // 
            // btn_mst
            // 
            this.btn_mst.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_mst.Location = new System.Drawing.Point(358, 62);
            this.btn_mst.Name = "btn_mst";
            this.btn_mst.Size = new System.Drawing.Size(322, 54);
            this.btn_mst.TabIndex = 21;
            this.btn_mst.Text = "MUST";
            this.btn_mst.UseVisualStyleBackColor = false;
            this.btn_mst.Click += new System.EventHandler(this.btn_mst_Click);
            // 
            // Loaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 701);
            this.Controls.Add(this.btn_mst);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.ddlcategory);
            this.Controls.Add(this.ddltype);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dtptime);
            this.Controls.Add(this.btnaddpath);
            this.Controls.Add(this.btn_thumbgen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_copy);
            this.Controls.Add(this.lbl_pro);
            this.Controls.Add(this.lbl_pre);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_rbc);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.btn_panic);
            this.Controls.Add(this.btn_both);
            this.Controls.Add(this.btn_copyonly);
            this.Controls.Add(this.btn_pre);
            this.Controls.Add(this.btn_pro);
            this.Controls.Add(this.textBox1);
            this.Name = "Loaders";
            this.Text = "Processors";
            this.Load += new System.EventHandler(this.Loaders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddltype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlcategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_pro;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Button btn_copyonly;
        private System.Windows.Forms.Button btn_both;
        private System.Windows.Forms.Button btn_panic;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.Button btn_rbc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lbl_pre;
        private System.Windows.Forms.Label lbl_pro;
        private System.Windows.Forms.Label lbl_copy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_thumbgen;
        private System.Windows.Forms.Button btnaddpath;
        private System.Windows.Forms.TextBox dtptime;
        private System.Windows.Forms.Button btn_save;
        private Telerik.WinControls.UI.RadDropDownList ddltype;
        private Telerik.WinControls.UI.RadDropDownList ddlcategory;
        private Telerik.WinControls.UI.RadTextBox txtname;
        private System.Windows.Forms.Button btn_mst;
    }
}

