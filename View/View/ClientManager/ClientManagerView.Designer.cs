namespace View
{
    partial class ClientManagerView
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
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.LookOrderButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.AddOrderButton);
            this.flowLayoutPanel1.Controls.Add(this.LookOrderButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(234, 357);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(8, 8);
            this.AddOrderButton.Margin = new System.Windows.Forms.Padding(8);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(215, 123);
            this.AddOrderButton.TabIndex = 0;
            this.AddOrderButton.Text = "Добавить заказ";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += btn_AddOrder_click;
            // 
            // LookOrderButton
            // 
            this.LookOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LookOrderButton.Location = new System.Drawing.Point(8, 147);
            this.LookOrderButton.Margin = new System.Windows.Forms.Padding(8);
            this.LookOrderButton.Name = "LookOrderButton";
            this.LookOrderButton.Size = new System.Drawing.Size(215, 123);
            this.LookOrderButton.TabIndex = 1;
            this.LookOrderButton.Text = "Просмотреть заказы";
            this.LookOrderButton.UseVisualStyleBackColor = true;
            this.LookOrderButton.Click += btn_LookOrder_click;
            // 
            // ClientManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 276);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(246, 315);
            this.MinimumSize = new System.Drawing.Size(246, 315);
            this.Name = "ClientManagerView";
            this.Text = "Менеджер по работе с клиентами";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button LookOrderButton;
    }
}