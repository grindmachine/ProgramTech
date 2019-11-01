namespace View
{
    partial class CourierView
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.GetInfoOrderButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.GetInfoOrderButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 156);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // GetInfoOrderButton
            // 
            this.GetInfoOrderButton.Location = new System.Drawing.Point(7, 7);
            this.GetInfoOrderButton.Margin = new System.Windows.Forms.Padding(7);
            this.GetInfoOrderButton.Name = "GetInfoOrderButton";
            this.GetInfoOrderButton.Size = new System.Drawing.Size(185, 141);
            this.GetInfoOrderButton.TabIndex = 0;
            this.GetInfoOrderButton.Text = "Получить информацию о заказе";
            this.GetInfoOrderButton.UseVisualStyleBackColor = true;
            // 
            // CourierView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 156);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(216, 195);
            this.MinimumSize = new System.Drawing.Size(216, 195);
            this.Name = "CourierView";
            this.Text = "Курьер";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button GetInfoOrderButton;
    }
}