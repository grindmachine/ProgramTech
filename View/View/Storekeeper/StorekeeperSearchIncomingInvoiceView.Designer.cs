namespace View.Storekeeper
{
    partial class StorekeeperSearchIncomingInvoiceView
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
            this.GeneralPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.PanelNotFoundInvoice = new System.Windows.Forms.Panel();
            this.LabelNotFoundInvoice = new System.Windows.Forms.Label();
            this.PanelFoundInvoice = new System.Windows.Forms.Panel();
            this.BtnConfirmAdmission = new System.Windows.Forms.Button();
            this.BtnShowInvoiceContent = new System.Windows.Forms.Button();
            this.LabelFoundInvoice = new System.Windows.Forms.Label();
            this.GeneralPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.PanelNotFoundInvoice.SuspendLayout();
            this.PanelFoundInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.AutoScroll = true;
            this.GeneralPanel.Controls.Add(this.flowLayoutPanel2);
            this.GeneralPanel.Controls.Add(this.flowLayoutPanel3);
            this.GeneralPanel.Controls.Add(this.PanelNotFoundInvoice);
            this.GeneralPanel.Controls.Add(this.PanelFoundInvoice);
            this.GeneralPanel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GeneralPanel.Location = new System.Drawing.Point(14, 12);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(873, 481);
            this.GeneralPanel.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.maskedTextBox1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(426, 36);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 7, 1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите номер приходной накладной:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(246, 3);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.BtnSearch);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(426, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(447, 36);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(332, 3);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(112, 27);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Поиск";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += btn_Search_Click;
            // 
            // PanelNotFoundInvoice
            // 
            this.PanelNotFoundInvoice.Controls.Add(this.LabelNotFoundInvoice);
            this.PanelNotFoundInvoice.Location = new System.Drawing.Point(3, 39);
            this.PanelNotFoundInvoice.Name = "PanelNotFoundInvoice";
            this.PanelNotFoundInvoice.Size = new System.Drawing.Size(867, 100);
            this.PanelNotFoundInvoice.TabIndex = 5;
            this.PanelNotFoundInvoice.Visible = false;
            // 
            // LabelNotFoundInvoice
            // 
            this.LabelNotFoundInvoice.AutoSize = true;
            this.LabelNotFoundInvoice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNotFoundInvoice.Location = new System.Drawing.Point(239, 29);
            this.LabelNotFoundInvoice.Name = "LabelNotFoundInvoice";
            this.LabelNotFoundInvoice.Size = new System.Drawing.Size(417, 38);
            this.LabelNotFoundInvoice.TabIndex = 0;
            this.LabelNotFoundInvoice.Text = "К сожалению, накладная с таким номером не найдена. \r\nПроверьте правильность ввода" +
    " и повторите поиска ещё раз.";
            this.LabelNotFoundInvoice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PanelFoundInvoice
            // 
            this.PanelFoundInvoice.Controls.Add(this.BtnConfirmAdmission);
            this.PanelFoundInvoice.Controls.Add(this.BtnShowInvoiceContent);
            this.PanelFoundInvoice.Controls.Add(this.LabelFoundInvoice);
            this.PanelFoundInvoice.Location = new System.Drawing.Point(3, 145);
            this.PanelFoundInvoice.Name = "PanelFoundInvoice";
            this.PanelFoundInvoice.Size = new System.Drawing.Size(867, 110);
            this.PanelFoundInvoice.TabIndex = 6;
            this.PanelFoundInvoice.Visible = false;
            // 
            // BtnConfirmAdmission
            // 
            this.BtnConfirmAdmission.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnConfirmAdmission.Location = new System.Drawing.Point(525, 51);
            this.BtnConfirmAdmission.Name = "BtnConfirmAdmission";
            this.BtnConfirmAdmission.Size = new System.Drawing.Size(262, 56);
            this.BtnConfirmAdmission.TabIndex = 2;
            this.BtnConfirmAdmission.Text = "Подтвердить приём заказа";
            this.BtnConfirmAdmission.UseVisualStyleBackColor = true;
            // 
            // BtnShowInvoiceContent
            // 
            this.BtnShowInvoiceContent.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnShowInvoiceContent.Location = new System.Drawing.Point(70, 51);
            this.BtnShowInvoiceContent.Name = "BtnShowInvoiceContent";
            this.BtnShowInvoiceContent.Size = new System.Drawing.Size(262, 56);
            this.BtnShowInvoiceContent.TabIndex = 1;
            this.BtnShowInvoiceContent.Text = "Просмотреть содержимое заказа";
            this.BtnShowInvoiceContent.UseVisualStyleBackColor = true;
            // 
            // LabelFoundInvoice
            // 
            this.LabelFoundInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFoundInvoice.AutoSize = true;
            this.LabelFoundInvoice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFoundInvoice.Location = new System.Drawing.Point(200, 3);
            this.LabelFoundInvoice.Margin = new System.Windows.Forms.Padding(3);
            this.LabelFoundInvoice.Name = "LabelFoundInvoice";
            this.LabelFoundInvoice.Size = new System.Drawing.Size(476, 19);
            this.LabelFoundInvoice.TabIndex = 0;
            this.LabelFoundInvoice.Text = "Накладная была найдена в системе. Выберите дальнейшее действие:";
            // 
            // StorekeeperSearchIncomingInvoiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 514);
            this.Controls.Add(this.GeneralPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximumSize = new System.Drawing.Size(918, 553);
            this.MinimumSize = new System.Drawing.Size(918, 553);
            this.Name = "StorekeeperSearchIncomingInvoiceView";
            this.Text = "Поиск приходной накладной";
            this.GeneralPanel.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.PanelNotFoundInvoice.ResumeLayout(false);
            this.PanelNotFoundInvoice.PerformLayout();
            this.PanelFoundInvoice.ResumeLayout(false);
            this.PanelFoundInvoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel GeneralPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Panel PanelNotFoundInvoice;
        private System.Windows.Forms.Label LabelNotFoundInvoice;
        private System.Windows.Forms.Panel PanelFoundInvoice;
        private System.Windows.Forms.Button BtnConfirmAdmission;
        private System.Windows.Forms.Button BtnShowInvoiceContent;
        private System.Windows.Forms.Label LabelFoundInvoice;
    }
}