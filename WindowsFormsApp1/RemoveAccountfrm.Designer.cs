
namespace Moneymattersbank
{
    partial class RemoveAccountfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveAccountfrm));
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnRemove.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRemove.Location = new System.Drawing.Point(109, 246);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(381, 71);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.txtAccountNumber.Location = new System.Drawing.Point(297, 165);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(202, 28);
            this.txtAccountNumber.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Desktop;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Bernard MT Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(182, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 57);
            this.label7.TabIndex = 40;
            this.label7.Text = "REMOVE ACCOUNT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.BackColor = System.Drawing.SystemColors.Info;
            this.lblAccountNumber.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.lblAccountNumber.Location = new System.Drawing.Point(105, 165);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(166, 24);
            this.lblAccountNumber.TabIndex = 41;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // RemoveAccountfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(620, 382);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.btnRemove);
            this.MaximumSize = new System.Drawing.Size(638, 429);
            this.MinimumSize = new System.Drawing.Size(638, 429);
            this.Name = "RemoveAccountfrm";
            this.Text = "REMOVE ACCOUNT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAccountNumber;
    }
}