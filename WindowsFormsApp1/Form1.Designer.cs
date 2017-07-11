namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Link = new System.Windows.Forms.TextBox();
            this.DD = new System.Windows.Forms.TextBox();
            this.foldD = new System.Windows.Forms.FolderBrowserDialog();
            this.Browse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UName = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.None = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.PDF = new System.Windows.Forms.RadioButton();
            this.Delete = new System.Windows.Forms.CheckBox();
            this.Start = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.About = new System.Windows.Forms.ToolStripStatusLabel();
            this.Progress = new System.Windows.Forms.ToolStripProgressBar();
            this.PNo = new System.Windows.Forms.ToolStripStatusLabel();
            this.INo = new System.Windows.Forms.ToolStripStatusLabel();
            this.MName = new System.Windows.Forms.ToolStripStatusLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Link to Comic *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Download Directory";
            // 
            // Link
            // 
            this.Link.BackColor = System.Drawing.Color.Black;
            this.Link.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Link.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link.ForeColor = System.Drawing.Color.White;
            this.Link.Location = new System.Drawing.Point(23, 44);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(467, 26);
            this.Link.TabIndex = 2;
            this.Link.Text = "http://";
            // 
            // DD
            // 
            this.DD.BackColor = System.Drawing.Color.Black;
            this.DD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DD.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DD.ForeColor = System.Drawing.Color.White;
            this.DD.Location = new System.Drawing.Point(23, 190);
            this.DD.Name = "DD";
            this.DD.Size = new System.Drawing.Size(361, 26);
            this.DD.TabIndex = 3;
            // 
            // foldD
            // 
            this.foldD.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.Color.Black;
            this.Browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Browse.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Browse.Location = new System.Drawing.Point(388, 189);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(104, 27);
            this.Browse.TabIndex = 4;
            this.Browse.Text = "Browse...";
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // UName
            // 
            this.UName.BackColor = System.Drawing.Color.Black;
            this.UName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UName.ForeColor = System.Drawing.Color.White;
            this.UName.Location = new System.Drawing.Point(68, 263);
            this.UName.Name = "UName";
            this.UName.Size = new System.Drawing.Size(185, 26);
            this.UName.TabIndex = 7;
            // 
            // Pass
            // 
            this.Pass.BackColor = System.Drawing.Color.Black;
            this.Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pass.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.ForeColor = System.Drawing.Color.White;
            this.Pass.Location = new System.Drawing.Point(264, 263);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(184, 26);
            this.Pass.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Range";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "From";
            // 
            // From
            // 
            this.From.BackColor = System.Drawing.Color.Black;
            this.From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.From.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.ForeColor = System.Drawing.Color.White;
            this.From.Location = new System.Drawing.Point(88, 115);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(64, 26);
            this.From.TabIndex = 11;
            // 
            // To
            // 
            this.To.BackColor = System.Drawing.Color.Black;
            this.To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.To.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.ForeColor = System.Drawing.Color.White;
            this.To.Location = new System.Drawing.Point(227, 115);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(64, 26);
            this.To.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(189, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "To";
            // 
            // None
            // 
            this.None.AutoSize = true;
            this.None.Checked = true;
            this.None.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.None.Location = new System.Drawing.Point(180, 338);
            this.None.Name = "None";
            this.None.Size = new System.Drawing.Size(72, 21);
            this.None.TabIndex = 14;
            this.None.TabStop = true;
            this.None.Text = "None";
            this.None.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 311);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Convert To:";
            // 
            // PDF
            // 
            this.PDF.AutoSize = true;
            this.PDF.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDF.Location = new System.Drawing.Point(264, 338);
            this.PDF.Name = "PDF";
            this.PDF.Size = new System.Drawing.Size(62, 21);
            this.PDF.TabIndex = 16;
            this.PDF.Text = "PDF";
            this.PDF.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.AutoSize = true;
            this.Delete.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(107, 404);
            this.Delete.Name = "Delete";
            this.Delete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Delete.Size = new System.Drawing.Size(296, 21);
            this.Delete.TabIndex = 17;
            this.Delete.Text = "Delete files after conversion";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Black;
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Start.Location = new System.Drawing.Point(386, 451);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(104, 36);
            this.Start.TabIndex = 18;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 464);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "* Fields are required";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Copperplate Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(220, 169);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "  [Default : Downloads]";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About,
            this.Progress,
            this.PNo,
            this.INo,
            this.MName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(511, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.White;
            this.About.ForeColor = System.Drawing.Color.Black;
            this.About.Name = "About";
            this.About.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.About.Size = new System.Drawing.Size(60, 17);
            this.About.Text = "About";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Progress
            // 
            this.Progress.AutoSize = false;
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(140, 16);
            this.Progress.Visible = false;
            // 
            // PNo
            // 
            this.PNo.AutoSize = false;
            this.PNo.BackColor = System.Drawing.Color.White;
            this.PNo.ForeColor = System.Drawing.Color.Black;
            this.PNo.Name = "PNo";
            this.PNo.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.PNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PNo.Size = new System.Drawing.Size(48, 17);
            this.PNo.Text = "01.jpg";
            this.PNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PNo.Visible = false;
            // 
            // INo
            // 
            this.INo.AutoSize = false;
            this.INo.BackColor = System.Drawing.Color.White;
            this.INo.ForeColor = System.Drawing.Color.Black;
            this.INo.Name = "INo";
            this.INo.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.INo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.INo.Size = new System.Drawing.Size(110, 17);
            this.INo.Text = "Issue No. - 1";
            this.INo.Visible = false;
            // 
            // MName
            // 
            this.MName.AutoSize = false;
            this.MName.BackColor = System.Drawing.Color.White;
            this.MName.ForeColor = System.Drawing.Color.Black;
            this.MName.Name = "MName";
            this.MName.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.MName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MName.Size = new System.Drawing.Size(140, 17);
            this.MName.Text = "MName";
            this.MName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MName.Visible = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(471, 44);
            this.label11.TabIndex = 23;
            this.label11.Text = "by Xonshiz";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Visible = false;
            this.label11.Click += new System.EventHandler(this.picBox_Click);
            // 
            // picBox
            // 
            this.picBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox.BackgroundImage")));
            this.picBox.Enabled = false;
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(1, 0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(505, 490);
            this.picBox.TabIndex = 24;
            this.picBox.TabStop = false;
            this.picBox.Visible = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Copperplate Gothic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(471, 46);
            this.label12.TabIndex = 25;
            this.label12.Text = "Comic-DL";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Visible = false;
            this.label12.Click += new System.EventHandler(this.picBox_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(385, 453);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this.label13.Size = new System.Drawing.Size(96, 32);
            this.label13.TabIndex = 26;
            this.label13.Text = "Start";
            this.label13.Visible = false;
            this.label13.Click += new System.EventHandler(this.picBox_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(511, 512);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.PDF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.None);
            this.Controls.Add(this.To);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.From);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.UName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.DD);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Comic-dl [GUI]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Link;
        private System.Windows.Forms.TextBox DD;
        private System.Windows.Forms.FolderBrowserDialog foldD;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UName;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox From;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton None;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton PDF;
        private System.Windows.Forms.CheckBox Delete;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel About;
        private System.Windows.Forms.ToolStripProgressBar Progress;
        private System.Windows.Forms.ToolStripStatusLabel PNo;
        private System.Windows.Forms.ToolStripStatusLabel INo;
        private System.Windows.Forms.ToolStripStatusLabel MName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

