namespace View.Storekeeper
{
    partial class StorekeeperSearchSalesInvoiceView
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
            this.LabelExplaneMessage = new System.Windows.Forms.Label();
            this.TextBoxNumberInvoice = new System.Windows.Forms.MaskedTextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.PanelNotFoundInvoice = new System.Windows.Forms.Panel();
            this.LabelNotFoundInvoice = new System.Windows.Forms.Label();
            this.PanelFoundInvoice = new System.Windows.Forms.Panel();
            this.BtnIssuanceAdmission = new System.Windows.Forms.Button();
            this.BtnShowInvoiceContent = new System.Windows.Forms.Button();
            this.LabelFoundInvoice = new System.Windows.Forms.Label();
            this.PanelInvoiceInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelNumber = new System.Windows.Forms.Label();
            this.LabelNumberSet = new System.Windows.Forms.Label();
            this.LabelNameOrganization = new System.Windows.Forms.Label();
            this.LabelNameOrganizSet = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.LabelCostSet = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.GeneralPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.PanelNotFoundInvoice.SuspendLayout();
            this.PanelFoundInvoice.SuspendLayout();
            this.PanelInvoiceInfo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.GeneralPanel.Size = new System.Drawing.Size(873, 375);
            this.GeneralPanel.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.LabelExplaneMessage);
            this.flowLayoutPanel2.Controls.Add(this.TextBoxNumberInvoice);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(426, 36);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // LabelExplaneMessage
            // 
            this.LabelExplaneMessage.AutoSize = true;
            this.LabelExplaneMessage.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelExplaneMessage.Location = new System.Drawing.Point(1, 7);
            this.LabelExplaneMessage.Margin = new System.Windows.Forms.Padding(1, 7, 1, 1);
            this.LabelExplaneMessage.Name = "LabelExplaneMessage";
            this.LabelExplaneMessage.Size = new System.Drawing.Size(241, 17);
            this.LabelExplaneMessage.TabIndex = 0;
            this.LabelExplaneMessage.Text = "Введите номер расходной накладной:";
            // 
            // TextBoxNumberInvoice
            // 
            this.TextBoxNumberInvoice.Location = new System.Drawing.Point(246, 3);
            this.TextBoxNumberInvoice.Mask = "00000";
            this.TextBoxNumberInvoice.Name = "TextBoxNumberInvoice";
            this.TextBoxNumberInvoice.Size = new System.Drawing.Size(100, 23);
            this.TextBoxNumberInvoice.TabIndex = 1;
            this.TextBoxNumberInvoice.ValidatingType = typeof(int);
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
            this.PanelFoundInvoice.Controls.Add(this.BtnIssuanceAdmission);
            this.PanelFoundInvoice.Controls.Add(this.BtnShowInvoiceContent);
            this.PanelFoundInvoice.Controls.Add(this.LabelFoundInvoice);
            this.PanelFoundInvoice.Controls.Add(this.PanelInvoiceInfo);
            this.PanelFoundInvoice.Location = new System.Drawing.Point(3, 145);
            this.PanelFoundInvoice.Name = "PanelFoundInvoice";
            this.PanelFoundInvoice.Size = new System.Drawing.Size(867, 225);
            this.PanelFoundInvoice.TabIndex = 6;
            // 
            // BtnIssuanceAdmission
            // 
            this.BtnIssuanceAdmission.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnIssuanceAdmission.Location = new System.Drawing.Point(547, 107);
            this.BtnIssuanceAdmission.Name = "BtnIssuanceAdmission";
            this.BtnIssuanceAdmission.Size = new System.Drawing.Size(262, 56);
            this.BtnIssuanceAdmission.TabIndex = 2;
            this.BtnIssuanceAdmission.Text = "Подтвердить выдачу заказа";
            this.BtnIssuanceAdmission.UseVisualStyleBackColor = true;
            this.BtnIssuanceAdmission.Click += btn_IssuanceAdmission_Click;
            // 
            // BtnShowInvoiceContent
            // 
            this.BtnShowInvoiceContent.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnShowInvoiceContent.Location = new System.Drawing.Point(64, 107);
            this.BtnShowInvoiceContent.Name = "BtnShowInvoiceContent";
            this.BtnShowInvoiceContent.Size = new System.Drawing.Size(262, 56);
            this.BtnShowInvoiceContent.TabIndex = 1;
            this.BtnShowInvoiceContent.Text = "Просмотреть содержимое заказа";
            this.BtnShowInvoiceContent.UseVisualStyleBackColor = true;
            this.BtnShowInvoiceContent.Click += btn_ShowInvcCont_Click;
            // 
            // LabelFoundInvoice
            // 
            this.LabelFoundInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFoundInvoice.AutoSize = true;
            this.LabelFoundInvoice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFoundInvoice.Location = new System.Drawing.Point(188, 3);
            this.LabelFoundInvoice.Margin = new System.Windows.Forms.Padding(3);
            this.LabelFoundInvoice.Name = "LabelFoundInvoice";
            this.LabelFoundInvoice.Size = new System.Drawing.Size(476, 19);
            this.LabelFoundInvoice.TabIndex = 0;
            this.LabelFoundInvoice.Text = "Накладная была найдена в системе. Выберите дальнейшее действие:";
            // 
            // PanelInvoiceInfo
            // 
            this.PanelInvoiceInfo.Controls.Add(this.LabelNumber);
            this.PanelInvoiceInfo.Controls.Add(this.LabelNumberSet);
            this.PanelInvoiceInfo.Controls.Add(this.LabelNameOrganization);
            this.PanelInvoiceInfo.Controls.Add(this.LabelNameOrganizSet);
            this.PanelInvoiceInfo.Controls.Add(this.LabelCost);
            this.PanelInvoiceInfo.Controls.Add(this.LabelCostSet);
            this.PanelInvoiceInfo.Location = new System.Drawing.Point(3, 28);
            this.PanelInvoiceInfo.Name = "PanelInvoiceInfo";
            this.PanelInvoiceInfo.Size = new System.Drawing.Size(864, 73);
            this.PanelInvoiceInfo.TabIndex = 7;
            // 
            // LabelNumber
            // 
            this.LabelNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNumber.AutoSize = true;
            this.LabelNumber.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNumber.Location = new System.Drawing.Point(1, 3);
            this.LabelNumber.Margin = new System.Windows.Forms.Padding(1, 3, 3, 0);
            this.LabelNumber.Name = "LabelNumber";
            this.LabelNumber.Size = new System.Drawing.Size(137, 17);
            this.LabelNumber.TabIndex = 2;
            this.LabelNumber.Text = "Номер накладной:";
            // 
            // LabelNumberSet
            // 
            this.LabelNumberSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNumberSet.AutoSize = true;
            this.LabelNumberSet.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNumberSet.Location = new System.Drawing.Point(142, 3);
            this.LabelNumberSet.Margin = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this.LabelNumberSet.Name = "LabelNumberSet";
            this.LabelNumberSet.Size = new System.Drawing.Size(43, 17);
            this.LabelNumberSet.TabIndex = 3;
            this.LabelNumberSet.Text = "12345";
            // 
            // LabelNameOrganization
            // 
            this.LabelNameOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNameOrganization.AutoSize = true;
            this.LabelNameOrganization.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameOrganization.Location = new System.Drawing.Point(189, 3);
            this.LabelNameOrganization.Margin = new System.Windows.Forms.Padding(4, 3, 0, 0);
            this.LabelNameOrganization.Name = "LabelNameOrganization";
            this.LabelNameOrganization.Size = new System.Drawing.Size(175, 17);
            this.LabelNameOrganization.TabIndex = 0;
            this.LabelNameOrganization.Text = "ФИО заказчика: ";
            // 
            // LabelNameOrganizSet
            // 
            this.LabelNameOrganizSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNameOrganizSet.AutoSize = true;
            this.LabelNameOrganizSet.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameOrganizSet.Location = new System.Drawing.Point(365, 3);
            this.LabelNameOrganizSet.Margin = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this.LabelNameOrganizSet.Name = "LabelNameOrganizSet";
            this.LabelNameOrganizSet.Size = new System.Drawing.Size(212, 17);
            this.LabelNameOrganizSet.TabIndex = 1;
            this.LabelNameOrganizSet.Text = "ОАО \"Брестский мясокомбинат\"";
            // 
            // LabelCost
            // 
            this.LabelCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCost.AutoSize = true;
            this.LabelCost.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCost.Location = new System.Drawing.Point(581, 3);
            this.LabelCost.Margin = new System.Windows.Forms.Padding(4, 3, 0, 0);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(62, 17);
            this.LabelCost.TabIndex = 4;
            this.LabelCost.Text = "Сумма: ";
            // 
            // LabelCostSet
            // 
            this.LabelCostSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCostSet.AutoSize = true;
            this.LabelCostSet.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCostSet.Location = new System.Drawing.Point(644, 3);
            this.LabelCostSet.Margin = new System.Windows.Forms.Padding(1, 3, 0, 0);
            this.LabelCostSet.Name = "LabelCostSet";
            this.LabelCostSet.Size = new System.Drawing.Size(90, 17);
            this.LabelCostSet.TabIndex = 5;
            this.LabelCostSet.Text = "10324 рублей";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnBack);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 388);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(873, 114);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnBack.Location = new System.Drawing.Point(3, 78);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(126, 33);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += btn_Back_Click;
            // 
            // StorekeeperSearchIncomingInvoiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 514);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.GeneralPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximumSize = new System.Drawing.Size(918, 553);
            this.MinimumSize = new System.Drawing.Size(918, 553);
            this.Name = "StorekeeperSearchSalesInvoiceView";
            this.Text = "Поиск расходной накладной";
            this.GeneralPanel.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.PanelNotFoundInvoice.ResumeLayout(false);
            this.PanelNotFoundInvoice.PerformLayout();
            this.PanelFoundInvoice.ResumeLayout(false);
            this.PanelFoundInvoice.PerformLayout();
            this.PanelInvoiceInfo.ResumeLayout(false);
            this.PanelInvoiceInfo.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel GeneralPanel;
        private System.Windows.Forms.Label LabelExplaneMessage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.MaskedTextBox TextBoxNumberInvoice;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Panel PanelNotFoundInvoice;
        private System.Windows.Forms.Label LabelNotFoundInvoice;
        private System.Windows.Forms.Panel PanelFoundInvoice;
        private System.Windows.Forms.Button BtnIssuanceAdmission;
        private System.Windows.Forms.Button BtnShowInvoiceContent;
        private System.Windows.Forms.Label LabelFoundInvoice;
        private System.Windows.Forms.FlowLayoutPanel PanelInvoiceInfo;
        private System.Windows.Forms.Label LabelNameOrganization;
        private System.Windows.Forms.Label LabelNameOrganizSet;
        private System.Windows.Forms.Label LabelNumber;
        private System.Windows.Forms.Label LabelNumberSet;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Label LabelCostSet;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnBack;
    }
}