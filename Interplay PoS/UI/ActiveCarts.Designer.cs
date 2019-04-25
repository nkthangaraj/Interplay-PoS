namespace UI
{
    partial class ActiveCarts
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
            this.flowLayoutPanelCarts = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelCarts
            // 
            this.flowLayoutPanelCarts.AutoScroll = true;
            this.flowLayoutPanelCarts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCarts.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelCarts.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelCarts.Name = "flowLayoutPanelCarts";
            this.flowLayoutPanelCarts.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelCarts.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanelCarts.TabIndex = 0;
            // 
            // ActiveCarts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanelCarts);
            this.Name = "ActiveCarts";
            this.Text = "ActiveCarts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCarts;
    }
}