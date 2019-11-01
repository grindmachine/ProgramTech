namespace View
{
    partial class StorekeeperView
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
            this.SearchPurchInvoiceButton = new System.Windows.Forms.Button();
            this.SearchExprenseInvoiceButton = new System.Windows.Forms.Button();
            this.ShowListClientPurchButton = new System.Windows.Forms.Button();
            this.ShowListCourierPurchButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.SearchPurchInvoiceButton);
            this.flowLayoutPanel1.Controls.Add(this.SearchExprenseInvoiceButton);
            this.flowLayoutPanel1.Controls.Add(this.ShowListClientPurchButton);
            this.flowLayoutPanel1.Controls.Add(this.ShowListCourierPurchButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(208, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // SearchPurchInvoiceButton
            // 
            this.SearchPurchInvoiceButton.Location = new System.Drawing.Point(6, 6);
            this.SearchPurchInvoiceButton.Name = "SearchPurchInvoiceButton";
            this.SearchPurchInvoiceButton.Size = new System.Drawing.Size(195, 105);
            this.SearchPurchInvoiceButton.TabIndex = 0;
            this.SearchPurchInvoiceButton.Text = "Поиск приходной накладной";
            this.SearchPurchInvoiceButton.UseVisualStyleBackColor = true;
            // 
            // SearchExprenseInvoiceButton
            // 
            this.SearchExprenseInvoiceButton.Location = new System.Drawing.Point(6, 117);
            this.SearchExprenseInvoiceButton.Name = "SearchExprenseInvoiceButton";
            this.SearchExprenseInvoiceButton.Size = new System.Drawing.Size(195, 105);
            this.SearchExprenseInvoiceButton.TabIndex = 1;
            this.SearchExprenseInvoiceButton.Text = "Поиск расходной накладной";
            this.SearchExprenseInvoiceButton.UseVisualStyleBackColor = true;
            // 
            // ShowListClientPurchButton
            // 
            this.ShowListClientPurchButton.Location = new System.Drawing.Point(6, 228);
            this.ShowListClientPurchButton.Name = "ShowListClientPurchButton";
            this.ShowListClientPurchButton.Size = new System.Drawing.Size(195, 105);
            this.ShowListClientPurchButton.TabIndex = 2;
            this.ShowListClientPurchButton.Text = "Просмотреть список несформированных заказов клиентов";
            this.ShowListClientPurchButton.UseVisualStyleBackColor = true;
            // 
            // ShowListCourierPurchButton
            // 
            this.ShowListCourierPurchButton.Location = new System.Drawing.Point(6, 339);
            this.ShowListCourierPurchButton.Name = "ShowListCourierPurchButton";
            this.ShowListCourierPurchButton.Size = new System.Drawing.Size(195, 105);
            this.ShowListCourierPurchButton.TabIndex = 3;
            this.ShowListCourierPurchButton.Text = "Просмотреть список несформированных заказов для курьеров";
            this.ShowListCourierPurchButton.UseVisualStyleBackColor = true;
            // 
            // StorekeeperView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(224, 489);
            this.MinimumSize = new System.Drawing.Size(224, 489);
            this.Name = "StorekeeperView";
            this.Text = "StorekeeperView";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button SearchPurchInvoiceButton;
        private System.Windows.Forms.Button SearchExprenseInvoiceButton;
        private System.Windows.Forms.Button ShowListClientPurchButton;
        private System.Windows.Forms.Button ShowListCourierPurchButton;
    }
}