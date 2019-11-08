namespace View
{
    partial class ClientManagerInspectOrderView
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
            this.PanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelHead = new System.Windows.Forms.Panel();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxOrderNumber = new System.Windows.Forms.MaskedTextBox();
            this.LabelMessageInput = new System.Windows.Forms.Label();
            this.PanelProductsList = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelOrderNotFound = new System.Windows.Forms.Panel();
            this.LabelOrderNotFound = new System.Windows.Forms.Label();
            this.PanelSecondaryButtons = new System.Windows.Forms.Panel();
            this.ButtonCancelOrder = new System.Windows.Forms.Button();
            this.ButtonEditOrder = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelMain.SuspendLayout();
            this.PanelHead.SuspendLayout();
            this.PanelProductsList.SuspendLayout();
            this.PanelOrderNotFound.SuspendLayout();
            this.PanelSecondaryButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.PanelHead);
            this.PanelMain.Controls.Add(this.PanelProductsList);
            this.PanelMain.Controls.Add(this.PanelSecondaryButtons);
            this.PanelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelMain.Location = new System.Drawing.Point(12, 12);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(776, 594);
            this.PanelMain.TabIndex = 0;
            // 
            // PanelHead
            // 
            this.PanelHead.Controls.Add(this.ButtonSearch);
            this.PanelHead.Controls.Add(this.TextBoxOrderNumber);
            this.PanelHead.Controls.Add(this.LabelMessageInput);
            this.PanelHead.Location = new System.Drawing.Point(3, 3);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(773, 58);
            this.PanelHead.TabIndex = 0;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSearch.Location = new System.Drawing.Point(624, 7);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(135, 39);
            this.ButtonSearch.TabIndex = 2;
            this.ButtonSearch.Text = "Поиск";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // TextBoxOrderNumber
            // 
            this.TextBoxOrderNumber.Location = new System.Drawing.Point(233, 15);
            this.TextBoxOrderNumber.Mask = "00000";
            this.TextBoxOrderNumber.Name = "TextBoxOrderNumber";
            this.TextBoxOrderNumber.Size = new System.Drawing.Size(58, 22);
            this.TextBoxOrderNumber.TabIndex = 1;
            this.TextBoxOrderNumber.ValidatingType = typeof(int);
            // 
            // LabelMessageInput
            // 
            this.LabelMessageInput.AutoSize = true;
            this.LabelMessageInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMessageInput.Location = new System.Drawing.Point(3, 15);
            this.LabelMessageInput.Name = "LabelMessageInput";
            this.LabelMessageInput.Size = new System.Drawing.Size(224, 24);
            this.LabelMessageInput.TabIndex = 0;
            this.LabelMessageInput.Text = "Введите номер заказа: ";
            // 
            // PanelProductsList
            // 
            this.PanelProductsList.AutoScroll = true;
            this.PanelProductsList.Controls.Add(this.PanelOrderNotFound);
            this.PanelProductsList.Location = new System.Drawing.Point(3, 67);
            this.PanelProductsList.Name = "PanelProductsList";
            this.PanelProductsList.Size = new System.Drawing.Size(773, 414);
            this.PanelProductsList.TabIndex = 1;
            // 
            // PanelOrderNotFound
            // 
            this.PanelOrderNotFound.Controls.Add(this.LabelOrderNotFound);
            this.PanelOrderNotFound.Location = new System.Drawing.Point(3, 3);
            this.PanelOrderNotFound.Name = "PanelOrderNotFound";
            this.PanelOrderNotFound.Size = new System.Drawing.Size(767, 92);
            this.PanelOrderNotFound.TabIndex = 0;
            this.PanelOrderNotFound.Visible = false;
            // 
            // LabelOrderNotFound
            // 
            this.LabelOrderNotFound.AutoSize = true;
            this.LabelOrderNotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOrderNotFound.Location = new System.Drawing.Point(138, 19);
            this.LabelOrderNotFound.Name = "LabelOrderNotFound";
            this.LabelOrderNotFound.Size = new System.Drawing.Size(478, 48);
            this.LabelOrderNotFound.TabIndex = 0;
            this.LabelOrderNotFound.Text = "Заказ с таким номером не был найден. \r\nПроверьте правильность ввода и повторите п" +
    "оиск";
            this.LabelOrderNotFound.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PanelSecondaryButtons
            // 
            this.PanelSecondaryButtons.Controls.Add(this.ButtonCancelOrder);
            this.PanelSecondaryButtons.Controls.Add(this.ButtonEditOrder);
            this.PanelSecondaryButtons.Controls.Add(this.ButtonBack);
            this.PanelSecondaryButtons.Location = new System.Drawing.Point(3, 487);
            this.PanelSecondaryButtons.Name = "PanelSecondaryButtons";
            this.PanelSecondaryButtons.Size = new System.Drawing.Size(770, 100);
            this.PanelSecondaryButtons.TabIndex = 2;
            // 
            // ButtonCancelOrder
            // 
            this.ButtonCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCancelOrder.Location = new System.Drawing.Point(386, 8);
            this.ButtonCancelOrder.Name = "ButtonCancelOrder";
            this.ButtonCancelOrder.Size = new System.Drawing.Size(181, 36);
            this.ButtonCancelOrder.TabIndex = 4;
            this.ButtonCancelOrder.Text = "Отменить заказ";
            this.ButtonCancelOrder.UseVisualStyleBackColor = true;
            this.ButtonCancelOrder.Visible = false;
            // 
            // ButtonEditOrder
            // 
            this.ButtonEditOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEditOrder.Location = new System.Drawing.Point(588, 8);
            this.ButtonEditOrder.Name = "ButtonEditOrder";
            this.ButtonEditOrder.Size = new System.Drawing.Size(171, 36);
            this.ButtonEditOrder.TabIndex = 3;
            this.ButtonEditOrder.Text = "Редактировать";
            this.ButtonEditOrder.UseVisualStyleBackColor = true;
            this.ButtonEditOrder.Visible = false;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(7, 50);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(117, 36);
            this.ButtonBack.TabIndex = 2;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += btn_Back_Click;
            // 
            // ClientManagerInspectOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.PanelMain);
            this.Name = "ClientManagerInspectOrderView";
            this.Text = "ClientManagerInspectOrderView";
            this.PanelMain.ResumeLayout(false);
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            this.PanelProductsList.ResumeLayout(false);
            this.PanelOrderNotFound.ResumeLayout(false);
            this.PanelOrderNotFound.PerformLayout();
            this.PanelSecondaryButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelMain;
        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.MaskedTextBox TextBoxOrderNumber;
        private System.Windows.Forms.Label LabelMessageInput;
        private System.Windows.Forms.FlowLayoutPanel PanelProductsList;
        private System.Windows.Forms.Panel PanelSecondaryButtons;
        private System.Windows.Forms.Button ButtonCancelOrder;
        private System.Windows.Forms.Button ButtonEditOrder;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Panel PanelOrderNotFound;
        private System.Windows.Forms.Label LabelOrderNotFound;
    }
}