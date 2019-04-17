namespace UI
{
    partial class UserSelection
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
            this.flowLayoutPanelUserSelection = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelUserSelection
            // 
            this.flowLayoutPanelUserSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelUserSelection.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelUserSelection.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelUserSelection.Name = "flowLayoutPanelUserSelection";
            this.flowLayoutPanelUserSelection.Padding = new System.Windows.Forms.Padding(33);
            this.flowLayoutPanelUserSelection.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanelUserSelection.TabIndex = 0;
            // 
            // UserSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanelUserSelection);
            this.Name = "UserSelection";
            this.Text = "UserSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUserSelection;
    }
}