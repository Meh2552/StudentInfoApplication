namespace StudentInfoApplication
{
    partial class frmStudentInfo
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
            this.tblpnHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lbHeader = new System.Windows.Forms.Label();
            this.tblpnMain = new System.Windows.Forms.TableLayoutPanel();
            this.txbxLastN = new System.Windows.Forms.TextBox();
            this.txbxFirstN = new System.Windows.Forms.TextBox();
            this.lbLastN = new System.Windows.Forms.Label();
            this.lbFirstN = new System.Windows.Forms.Label();
            this.lbStuNo = new System.Windows.Forms.Label();
            this.txbxStudentNo = new System.Windows.Forms.TextBox();
            this.btnConf = new System.Windows.Forms.Button();
            this.lsbxStNo = new System.Windows.Forms.ListBox();
            this.lsbxFirstN = new System.Windows.Forms.ListBox();
            this.lsbxLastN = new System.Windows.Forms.ListBox();
            this.tblpnHeader.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.tblpnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpnHeader
            // 
            this.tblpnHeader.BackColor = System.Drawing.Color.PapayaWhip;
            this.tblpnHeader.ColumnCount = 1;
            this.tblpnHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnHeader.Controls.Add(this.pnHeader, 0, 0);
            this.tblpnHeader.Controls.Add(this.tblpnMain, 0, 1);
            this.tblpnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnHeader.Location = new System.Drawing.Point(0, 0);
            this.tblpnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnHeader.Name = "tblpnHeader";
            this.tblpnHeader.RowCount = 2;
            this.tblpnHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tblpnHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tblpnHeader.Size = new System.Drawing.Size(800, 450);
            this.tblpnHeader.TabIndex = 0;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(50)))), ((int)(((byte)(45)))));
            this.pnHeader.BackgroundImage = global::StudentInfoApplication.Properties.Resources.Untitled_1;
            this.pnHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnHeader.Controls.Add(this.lbHeader);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(800, 54);
            this.pnHeader.TabIndex = 0;
            // 
            // lbHeader
            // 
            this.lbHeader.BackColor = System.Drawing.Color.Transparent;
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.White;
            this.lbHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbHeader.Location = new System.Drawing.Point(0, 0);
            this.lbHeader.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Padding = new System.Windows.Forms.Padding(20, 3, 0, 0);
            this.lbHeader.Size = new System.Drawing.Size(800, 54);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Student Information";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblpnMain
            // 
            this.tblpnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tblpnMain.ColumnCount = 3;
            this.tblpnMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333F));
            this.tblpnMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.333F));
            this.tblpnMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.334F));
            this.tblpnMain.Controls.Add(this.txbxLastN, 2, 1);
            this.tblpnMain.Controls.Add(this.txbxFirstN, 1, 1);
            this.tblpnMain.Controls.Add(this.lbLastN, 2, 0);
            this.tblpnMain.Controls.Add(this.lbFirstN, 1, 0);
            this.tblpnMain.Controls.Add(this.lbStuNo, 0, 0);
            this.tblpnMain.Controls.Add(this.txbxStudentNo, 0, 1);
            this.tblpnMain.Controls.Add(this.btnConf, 2, 2);
            this.tblpnMain.Controls.Add(this.lsbxStNo, 0, 3);
            this.tblpnMain.Controls.Add(this.lsbxFirstN, 1, 3);
            this.tblpnMain.Controls.Add(this.lsbxLastN, 2, 3);
            this.tblpnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnMain.Location = new System.Drawing.Point(0, 54);
            this.tblpnMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnMain.Name = "tblpnMain";
            this.tblpnMain.RowCount = 4;
            this.tblpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.838384F));
            this.tblpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.85859F));
            this.tblpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblpnMain.Size = new System.Drawing.Size(800, 396);
            this.tblpnMain.TabIndex = 1;
            // 
            // txbxLastN
            // 
            this.txbxLastN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxLastN.BackColor = System.Drawing.Color.Gainsboro;
            this.txbxLastN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxLastN.Location = new System.Drawing.Point(549, 46);
            this.txbxLastN.Margin = new System.Windows.Forms.Padding(17, 3, 10, 3);
            this.txbxLastN.Name = "txbxLastN";
            this.txbxLastN.Size = new System.Drawing.Size(241, 20);
            this.txbxLastN.TabIndex = 5;
            // 
            // txbxFirstN
            // 
            this.txbxFirstN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxFirstN.BackColor = System.Drawing.Color.Gainsboro;
            this.txbxFirstN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxFirstN.Location = new System.Drawing.Point(283, 46);
            this.txbxFirstN.Margin = new System.Windows.Forms.Padding(17, 3, 10, 3);
            this.txbxFirstN.Name = "txbxFirstN";
            this.txbxFirstN.Size = new System.Drawing.Size(239, 20);
            this.txbxFirstN.TabIndex = 4;
            // 
            // lbLastN
            // 
            this.lbLastN.AutoSize = true;
            this.lbLastN.BackColor = System.Drawing.Color.Transparent;
            this.lbLastN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLastN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastN.ForeColor = System.Drawing.Color.White;
            this.lbLastN.Location = new System.Drawing.Point(535, 0);
            this.lbLastN.Name = "lbLastN";
            this.lbLastN.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbLastN.Size = new System.Drawing.Size(262, 35);
            this.lbLastN.TabIndex = 2;
            this.lbLastN.Text = "Last Name:";
            this.lbLastN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFirstN
            // 
            this.lbFirstN.AutoSize = true;
            this.lbFirstN.BackColor = System.Drawing.Color.Transparent;
            this.lbFirstN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFirstN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstN.ForeColor = System.Drawing.Color.White;
            this.lbFirstN.Location = new System.Drawing.Point(269, 0);
            this.lbFirstN.Name = "lbFirstN";
            this.lbFirstN.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbFirstN.Size = new System.Drawing.Size(260, 35);
            this.lbFirstN.TabIndex = 1;
            this.lbFirstN.Text = "First Name:";
            this.lbFirstN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbStuNo
            // 
            this.lbStuNo.AutoSize = true;
            this.lbStuNo.BackColor = System.Drawing.Color.Transparent;
            this.lbStuNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStuNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStuNo.ForeColor = System.Drawing.Color.White;
            this.lbStuNo.Location = new System.Drawing.Point(3, 0);
            this.lbStuNo.Name = "lbStuNo";
            this.lbStuNo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbStuNo.Size = new System.Drawing.Size(260, 35);
            this.lbStuNo.TabIndex = 0;
            this.lbStuNo.Text = "Student No:";
            this.lbStuNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbxStudentNo
            // 
            this.txbxStudentNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxStudentNo.BackColor = System.Drawing.Color.Gainsboro;
            this.txbxStudentNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxStudentNo.Location = new System.Drawing.Point(17, 46);
            this.txbxStudentNo.Margin = new System.Windows.Forms.Padding(17, 3, 10, 3);
            this.txbxStudentNo.Name = "txbxStudentNo";
            this.txbxStudentNo.Size = new System.Drawing.Size(239, 20);
            this.txbxStudentNo.TabIndex = 3;
            // 
            // btnConf
            // 
            this.btnConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(50)))), ((int)(((byte)(45)))));
            this.btnConf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConf.FlatAppearance.BorderSize = 0;
            this.btnConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConf.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConf.ForeColor = System.Drawing.Color.White;
            this.btnConf.Location = new System.Drawing.Point(682, 85);
            this.btnConf.Margin = new System.Windows.Forms.Padding(150, 7, 10, 7);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(108, 25);
            this.btnConf.TabIndex = 6;
            this.btnConf.Text = "Confirm";
            this.btnConf.UseVisualStyleBackColor = false;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // lsbxStNo
            // 
            this.lsbxStNo.BackColor = System.Drawing.Color.Gainsboro;
            this.lsbxStNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbxStNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbxStNo.FormattingEnabled = true;
            this.lsbxStNo.Location = new System.Drawing.Point(17, 120);
            this.lsbxStNo.Margin = new System.Windows.Forms.Padding(17, 3, 10, 20);
            this.lsbxStNo.Name = "lsbxStNo";
            this.lsbxStNo.Size = new System.Drawing.Size(239, 256);
            this.lsbxStNo.TabIndex = 7;
            // 
            // lsbxFirstN
            // 
            this.lsbxFirstN.BackColor = System.Drawing.Color.Gainsboro;
            this.lsbxFirstN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbxFirstN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbxFirstN.FormattingEnabled = true;
            this.lsbxFirstN.Location = new System.Drawing.Point(283, 120);
            this.lsbxFirstN.Margin = new System.Windows.Forms.Padding(17, 3, 10, 20);
            this.lsbxFirstN.Name = "lsbxFirstN";
            this.lsbxFirstN.Size = new System.Drawing.Size(239, 256);
            this.lsbxFirstN.TabIndex = 8;
            // 
            // lsbxLastN
            // 
            this.lsbxLastN.BackColor = System.Drawing.Color.Gainsboro;
            this.lsbxLastN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsbxLastN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbxLastN.FormattingEnabled = true;
            this.lsbxLastN.Location = new System.Drawing.Point(549, 120);
            this.lsbxLastN.Margin = new System.Windows.Forms.Padding(17, 3, 10, 20);
            this.lsbxLastN.Name = "lsbxLastN";
            this.lsbxLastN.Size = new System.Drawing.Size(241, 256);
            this.lsbxLastN.TabIndex = 9;
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblpnHeader);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "frmStudentInfo";
            this.Text = "Student Information Application";
            this.tblpnHeader.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.tblpnMain.ResumeLayout(false);
            this.tblpnMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpnHeader;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.TableLayoutPanel tblpnMain;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Label lbLastN;
        private System.Windows.Forms.Label lbFirstN;
        private System.Windows.Forms.Label lbStuNo;
        private System.Windows.Forms.TextBox txbxStudentNo;
        private System.Windows.Forms.TextBox txbxLastN;
        private System.Windows.Forms.TextBox txbxFirstN;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.ListBox lsbxStNo;
        private System.Windows.Forms.ListBox lsbxFirstN;
        private System.Windows.Forms.ListBox lsbxLastN;
    }
}

