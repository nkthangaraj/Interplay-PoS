using UI.Storage;

namespace UI
{
    partial class Authentication
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
            this.authenticationTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblInvalidUserMessage = new System.Windows.Forms.Label();
            this.lblEnterPIN = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.authenticationTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // authenticationTableLayout
            // 
            this.authenticationTableLayout.ColumnCount = 2;
            this.authenticationTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.02847F));
            this.authenticationTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.97153F));
            this.authenticationTableLayout.Controls.Add(this.lblInvalidUserMessage, 1, 2);
            this.authenticationTableLayout.Controls.Add(this.lblEnterPIN, 0, 1);
            this.authenticationTableLayout.Controls.Add(this.txtPassword, 1, 1);
            this.authenticationTableLayout.Location = new System.Drawing.Point(37, 12);
            this.authenticationTableLayout.Name = "authenticationTableLayout";
            this.authenticationTableLayout.RowCount = 3;
            this.authenticationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.authenticationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.authenticationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.authenticationTableLayout.Size = new System.Drawing.Size(281, 85);
            this.authenticationTableLayout.TabIndex = 0;
            // 
            // lblInvalidUserMessage
            // 
            this.lblInvalidUserMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInvalidUserMessage.AutoSize = true;
            this.lblInvalidUserMessage.Location = new System.Drawing.Point(185, 65);
            this.lblInvalidUserMessage.Name = "lblInvalidUserMessage";
            this.lblInvalidUserMessage.Size = new System.Drawing.Size(0, 13);
            this.lblInvalidUserMessage.TabIndex = 8;
            this.lblInvalidUserMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnterPIN
            // 
            this.lblEnterPIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnterPIN.AutoSize = true;
            this.lblEnterPIN.Font = new System.Drawing.Font("Leelawadee", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPIN.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEnterPIN.Location = new System.Drawing.Point(7, 35);
            this.lblEnterPIN.Name = "lblEnterPIN";
            this.lblEnterPIN.Size = new System.Drawing.Size(74, 16);
            this.lblEnterPIN.TabIndex = 2;
            this.lblEnterPIN.Text = "Enter PIN:";
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(92, 32);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '#';
            this.txtPassword.Size = new System.Drawing.Size(186, 27);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(354, 110);
            this.Controls.Add(this.authenticationTableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authentication";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.authenticationTableLayout.ResumeLayout(false);
            this.authenticationTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel authenticationTableLayout;
        private System.Windows.Forms.Label lblEnterPIN;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblInvalidUserMessage;
    }
}