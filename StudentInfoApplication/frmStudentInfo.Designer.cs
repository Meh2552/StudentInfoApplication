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
            this.lbStuNo = new System.Windows.Forms.Label();
            this.lbFirstN = new System.Windows.Forms.Label();
            this.lbLastN = new System.Windows.Forms.Label();
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
            this.pnHeader.BackColor = System.Drawing.Color.Red;
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
            this.lbHeader.BackColor = System.Drawing.Color.Red;
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeader.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.White;
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
            this.tblpnMain.Controls.Add(this.lbLastN, 2, 0);
            this.tblpnMain.Controls.Add(this.lbFirstN, 1, 0);
            this.tblpnMain.Controls.Add(this.lbStuNo, 0, 0);
            this.tblpnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnMain.Location = new System.Drawing.Point(0, 54);
            this.tblpnMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnMain.Name = "tblpnMain";
            this.tblpnMain.RowCount = 4;
            this.tblpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tblpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tblpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblpnMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblpnMain.Size = new System.Drawing.Size(800, 396);
            this.tblpnMain.TabIndex = 1;
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
            this.lbStuNo.Size = new System.Drawing.Size(260, 27);
            this.lbStuNo.TabIndex = 0;
            this.lbStuNo.Text = "Student No:";
            this.lbStuNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lbFirstN.Size = new System.Drawing.Size(260, 27);
            this.lbFirstN.TabIndex = 1;
            this.lbFirstN.Text = "First Name:";
            this.lbFirstN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lbLastN.Size = new System.Drawing.Size(262, 27);
            this.lbLastN.TabIndex = 2;
            this.lbLastN.Text = "Last Name:";
            this.lbLastN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblpnHeader);
            this.Name = "frmStudentInfo";
            this.Text = "Form1";
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
    }
}

