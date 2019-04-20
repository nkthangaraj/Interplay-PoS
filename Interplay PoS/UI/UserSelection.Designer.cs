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
            this.userScreenTablelayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelUserSelection = new System.Windows.Forms.FlowLayoutPanel();
            this.userScreenTablelayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userScreenTablelayoutPanel
            // 
            this.userScreenTablelayoutPanel.ColumnCount = 1;
            this.userScreenTablelayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.userScreenTablelayoutPanel.Controls.Add(this.flowLayoutPanelUserSelection, 0, 0);
            this.userScreenTablelayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userScreenTablelayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.userScreenTablelayoutPanel.Name = "userScreenTablelayoutPanel";
            this.userScreenTablelayoutPanel.RowCount = 1;
            this.userScreenTablelayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.userScreenTablelayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.userScreenTablelayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.userScreenTablelayoutPanel.TabIndex = 0;
            // 
            // flowLayoutPanelUserSelection
            // 
            this.flowLayoutPanelUserSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelUserSelection.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelUserSelection.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelUserSelection.Name = "flowLayoutPanelUserSelection";
            this.flowLayoutPanelUserSelection.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanelUserSelection.TabIndex = 5;
            // 
            // UserSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userScreenTablelayoutPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserSelection";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "UserSelection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.userScreenTablelayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel userScreenTablelayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelUserSelection;
    }
}