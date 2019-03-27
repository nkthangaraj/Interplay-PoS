namespace UI
{
    partial class Quantity
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
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnQuantityOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(71, 13);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(91, 20);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Text = "1";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(21, 16);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnQuantityOK
            // 
            this.btnQuantityOK.Location = new System.Drawing.Point(24, 42);
            this.btnQuantityOK.Name = "btnQuantityOK";
            this.btnQuantityOK.Size = new System.Drawing.Size(138, 23);
            this.btnQuantityOK.TabIndex = 3;
            this.btnQuantityOK.Text = "OK";
            this.btnQuantityOK.UseVisualStyleBackColor = true;
            this.btnQuantityOK.Click += new System.EventHandler(this.btnQuantityOK_Click);
            // 
            // Quantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 87);
            this.Controls.Add(this.btnQuantityOK);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Name = "Quantity";
            this.Text = "Quantity";
            this.Load += new System.EventHandler(this.Quantity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnQuantityOK;
    }
}