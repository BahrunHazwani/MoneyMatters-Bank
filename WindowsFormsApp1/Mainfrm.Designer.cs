
namespace Moneymattersbank
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnWithDraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnREMOVEACCOUNT = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblACCOUNTBALANCE = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAccountBalance = new System.Windows.Forms.TextBox();
            this.txtAccountType = new System.Windows.Forms.TextBox();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txticname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.BackColor = System.Drawing.SystemColors.Info;
            this.lblAccountNumber.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.lblAccountNumber.Location = new System.Drawing.Point(878, 192);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(184, 24);
            this.lblAccountNumber.TabIndex = 2;
            this.lblAccountNumber.Text = "ACCOUNT NUMBER:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(1051, 247);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(286, 52);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnWithDraw
            // 
            this.btnWithDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnWithDraw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnWithDraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnWithDraw.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnWithDraw.Location = new System.Drawing.Point(398, 419);
            this.btnWithDraw.Name = "btnWithDraw";
            this.btnWithDraw.Size = new System.Drawing.Size(198, 52);
            this.btnWithDraw.TabIndex = 5;
            this.btnWithDraw.Text = "WITHDRAW";
            this.btnWithDraw.UseVisualStyleBackColor = false;
            this.btnWithDraw.Click += new System.EventHandler(this.btnWithDraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDeposit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnDeposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnDeposit.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDeposit.Location = new System.Drawing.Point(149, 415);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(198, 52);
            this.btnDeposit.TabIndex = 6;
            this.btnDeposit.Text = "DEPOSIT";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnREMOVEACCOUNT
            // 
            this.btnREMOVEACCOUNT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnREMOVEACCOUNT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnREMOVEACCOUNT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnREMOVEACCOUNT.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnREMOVEACCOUNT.Location = new System.Drawing.Point(149, 336);
            this.btnREMOVEACCOUNT.Name = "btnREMOVEACCOUNT";
            this.btnREMOVEACCOUNT.Size = new System.Drawing.Size(198, 51);
            this.btnREMOVEACCOUNT.TabIndex = 7;
            this.btnREMOVEACCOUNT.Text = "REMOVE ACCOUNT";
            this.btnREMOVEACCOUNT.UseVisualStyleBackColor = false;
            this.btnREMOVEACCOUNT.Click += new System.EventHandler(this.btnREMOVEACCOUNT_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCreateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnCreateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnCreateAccount.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCreateAccount.Location = new System.Drawing.Point(398, 335);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(198, 52);
            this.btnCreateAccount.TabIndex = 8;
            this.btnCreateAccount.Text = "CREATE ACCOUNT";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnViewAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnViewAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnViewAccount.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnViewAccount.Location = new System.Drawing.Point(229, 501);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(308, 67);
            this.btnViewAccount.TabIndex = 10;
            this.btnViewAccount.Text = "VIEW ACCOUNT TRANSACTIONS";
            this.btnViewAccount.UseVisualStyleBackColor = false;
            this.btnViewAccount.Click += new System.EventHandler(this.btnViewAccount_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.Info;
            this.lblName.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(878, 344);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 24);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "NAME:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.SystemColors.Info;
            this.lblPhone.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(878, 521);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(158, 24);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "PHONE NUMBER:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.SystemColors.Info;
            this.lblGender.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.lblGender.Location = new System.Drawing.Point(878, 584);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(89, 24);
            this.lblGender.TabIndex = 20;
            this.lblGender.Text = "GENDER:";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.BackColor = System.Drawing.SystemColors.Info;
            this.lblAccountType.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.lblAccountType.Location = new System.Drawing.Point(878, 646);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(157, 24);
            this.lblAccountType.TabIndex = 22;
            this.lblAccountType.Text = "ACCOUNT TYPE:";
            // 
            // lblACCOUNTBALANCE
            // 
            this.lblACCOUNTBALANCE.AutoSize = true;
            this.lblACCOUNTBALANCE.BackColor = System.Drawing.SystemColors.Info;
            this.lblACCOUNTBALANCE.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.lblACCOUNTBALANCE.Location = new System.Drawing.Point(878, 699);
            this.lblACCOUNTBALANCE.Name = "lblACCOUNTBALANCE";
            this.lblACCOUNTBALANCE.Size = new System.Drawing.Size(238, 24);
            this.lblACCOUNTBALANCE.TabIndex = 24;
            this.lblACCOUNTBALANCE.Text = "ACCOUNT BALANCE (RM):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(878, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "IC NUMBER:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.SystemColors.Info;
            this.lblAddress.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(878, 463);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(96, 24);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "ADDRESS:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1507, 28);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.txtAccountNumber.Location = new System.Drawing.Point(1161, 189);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(265, 28);
            this.txtAccountNumber.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Desktop;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Bernard MT Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(474, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(460, 51);
            this.label7.TabIndex = 29;
            this.label7.Text = "MONEYMATTERS BANK";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.txtAccountBalance.Location = new System.Drawing.Point(1161, 704);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.Size = new System.Drawing.Size(265, 28);
            this.txtAccountBalance.TabIndex = 37;
            // 
            // txtAccountType
            // 
            this.txtAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.txtAccountType.Location = new System.Drawing.Point(1161, 648);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Size = new System.Drawing.Size(265, 28);
            this.txtAccountType.TabIndex = 35;
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbAccountType.Location = new System.Drawing.Point(1161, 648);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(176, 24);
            this.cmbAccountType.TabIndex = 36;
            this.cmbAccountType.Visible = false;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.txtGender.Location = new System.Drawing.Point(1161, 586);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(265, 28);
            this.txtGender.TabIndex = 33;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.txtPhone.Location = new System.Drawing.Point(1161, 526);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(265, 28);
            this.txtPhone.TabIndex = 34;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtAddress.Location = new System.Drawing.Point(1161, 465);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(265, 27);
            this.txtAddress.TabIndex = 32;
            // 
            // txticname
            // 
            this.txticname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.txticname.Location = new System.Drawing.Point(1161, 408);
            this.txticname.Name = "txticname";
            this.txticname.Size = new System.Drawing.Size(265, 28);
            this.txticname.TabIndex = 31;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(1161, 346);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 28);
            this.txtName.TabIndex = 30;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1507, 811);
            this.Controls.Add(this.txtAccountBalance);
            this.Controls.Add(this.txtAccountType);
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txticname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblACCOUNTBALANCE);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnViewAccount);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.btnREMOVEACCOUNT);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithDraw);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1525, 858);
            this.MinimumSize = new System.Drawing.Size(1525, 858);
            this.Name = "MainForm";
            this.Text = "MONEY MATTERS BANK";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseHover += new System.EventHandler(this.btn_MouscHover);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnWithDraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnREMOVEACCOUNT;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblACCOUNTBALANCE;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAccountBalance;
        private System.Windows.Forms.TextBox txtAccountType;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txticname;
        private System.Windows.Forms.TextBox txtName;
    }
}

