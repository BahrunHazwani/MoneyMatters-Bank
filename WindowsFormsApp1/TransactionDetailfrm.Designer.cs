
namespace Moneymattersbank
{
    partial class TransactionDetailfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionDetailfrm));
            this.dgrdTransaction = new System.Windows.Forms.DataGridView();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lbldWithdraw = new System.Windows.Forms.Label();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lbldDeposit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrdTransaction
            // 
            this.dgrdTransaction.BackgroundColor = System.Drawing.Color.Silver;
            this.dgrdTransaction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgrdTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdTransaction.Location = new System.Drawing.Point(256, 212);
            this.dgrdTransaction.Name = "dgrdTransaction";
            this.dgrdTransaction.RowHeadersWidth = 51;
            this.dgrdTransaction.RowTemplate.Height = 24;
            this.dgrdTransaction.Size = new System.Drawing.Size(776, 353);
            this.dgrdTransaction.TabIndex = 0;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.BackColor = System.Drawing.SystemColors.Info;
            this.lblAccountNumber.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.lblAccountNumber.Location = new System.Drawing.Point(252, 163);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(166, 24);
            this.lblAccountNumber.TabIndex = 11;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // lbldWithdraw
            // 
            this.lbldWithdraw.AutoSize = true;
            this.lbldWithdraw.BackColor = System.Drawing.Color.White;
            this.lbldWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lbldWithdraw.Location = new System.Drawing.Point(772, 629);
            this.lbldWithdraw.Name = "lbldWithdraw";
            this.lbldWithdraw.Size = new System.Drawing.Size(96, 24);
            this.lbldWithdraw.TabIndex = 23;
            this.lbldWithdraw.Text = "Withdraw";
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.BackColor = System.Drawing.SystemColors.Info;
            this.lblWithdraw.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.lblWithdraw.Location = new System.Drawing.Point(595, 629);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(154, 24);
            this.lblWithdraw.TabIndex = 22;
            this.lblWithdraw.Text = "Total Withdraw:";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.BackColor = System.Drawing.SystemColors.Info;
            this.lblDeposit.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.lblDeposit.Location = new System.Drawing.Point(280, 629);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(135, 24);
            this.lblDeposit.TabIndex = 20;
            this.lblDeposit.Text = "Total Deposit:";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.txtAccountNumber.Location = new System.Drawing.Point(440, 160);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(200, 28);
            this.txtAccountNumber.TabIndex = 18;
            // 
            // lbldDeposit
            // 
            this.lbldDeposit.AutoSize = true;
            this.lbldDeposit.BackColor = System.Drawing.Color.White;
            this.lbldDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lbldDeposit.Location = new System.Drawing.Point(436, 629);
            this.lbldDeposit.Name = "lbldDeposit";
            this.lbldDeposit.Size = new System.Drawing.Size(80, 24);
            this.lbldDeposit.TabIndex = 24;
            this.lbldDeposit.Text = "Deposit";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Desktop;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Bernard MT Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(522, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 57);
            this.label7.TabIndex = 41;
            this.label7.Text = "TRANSACTION DETAIL";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnSearch.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(684, 155);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(348, 41);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // TransactionDetailfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1298, 693);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbldDeposit);
            this.Controls.Add(this.lbldWithdraw);
            this.Controls.Add(this.lblWithdraw);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.dgrdTransaction);
            this.MaximumSize = new System.Drawing.Size(1316, 740);
            this.MinimumSize = new System.Drawing.Size(1316, 740);
            this.Name = "TransactionDetailfrm";
            this.Text = "TRANSACTION DETAIL";
            this.Load += new System.EventHandler(this.TransactionDetailfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrdTransaction;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lbldWithdraw;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lbldDeposit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
    }
}