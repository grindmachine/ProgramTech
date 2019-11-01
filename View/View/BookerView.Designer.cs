namespace View
{
    partial class BookerView
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
            this.CheckClientPaymentButton = new System.Windows.Forms.Button();
            this.PayOrderProviderButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.CheckClientPaymentButton);
            this.flowLayoutPanel1.Controls.Add(this.PayOrderProviderButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(192, 226);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // CheckClientPaymentButton
            // 
            this.CheckClientPaymentButton.Location = new System.Drawing.Point(5, 5);
            this.CheckClientPaymentButton.Margin = new System.Windows.Forms.Padding(5);
            this.CheckClientPaymentButton.Name = "CheckClientPaymentButton";
            this.CheckClientPaymentButton.Size = new System.Drawing.Size(181, 103);
            this.CheckClientPaymentButton.TabIndex = 0;
            this.CheckClientPaymentButton.Text = "Проверить платежи клиентов";
            this.CheckClientPaymentButton.UseVisualStyleBackColor = true;
            // 
            // PayOrderProviderButton
            // 
            this.PayOrderProviderButton.Location = new System.Drawing.Point(5, 118);
            this.PayOrderProviderButton.Margin = new System.Windows.Forms.Padding(5);
            this.PayOrderProviderButton.Name = "PayOrderProviderButton";
            this.PayOrderProviderButton.Size = new System.Drawing.Size(181, 103);
            this.PayOrderProviderButton.TabIndex = 1;
            this.PayOrderProviderButton.Text = "Оплатить заказы у поставщиков";
            this.PayOrderProviderButton.UseVisualStyleBackColor = true;
            // 
            // BookerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 226);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(208, 265);
            this.MinimumSize = new System.Drawing.Size(208, 265);
            this.Name = "BookerView";
            this.Text = "BookerView";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CheckClientPaymentButton;
        private System.Windows.Forms.Button PayOrderProviderButton;
    }
}