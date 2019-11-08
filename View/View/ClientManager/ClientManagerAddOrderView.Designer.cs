namespace View
{
    partial class ClientManagerAddOrderView
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
            this.GroupBoxInitials = new System.Windows.Forms.GroupBox();
            this.TextBoxPatronymic = new System.Windows.Forms.MaskedTextBox();
            this.LabelPatronymic = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.MaskedTextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxSurname = new System.Windows.Forms.MaskedTextBox();
            this.LabelSurname = new System.Windows.Forms.Label();
            this.GroupBoxHomeAddress = new System.Windows.Forms.GroupBox();
            this.TextBoxFlat = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxHouseNumber = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxPavilion = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxStreet = new System.Windows.Forms.MaskedTextBox();
            this.TextBoxCity = new System.Windows.Forms.MaskedTextBox();
            this.LabelFlat = new System.Windows.Forms.Label();
            this.LabelStreet = new System.Windows.Forms.Label();
            this.LabelPavilion = new System.Windows.Forms.Label();
            this.LabelHouseNumber = new System.Windows.Forms.Label();
            this.LabelCity = new System.Windows.Forms.Label();
            this.PanelMainContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.GroupBoxContactInfo = new System.Windows.Forms.GroupBox();
            this.TextBoxEmailAddress = new System.Windows.Forms.MaskedTextBox();
            this.LabelEmailAddress = new System.Windows.Forms.Label();
            this.TextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.LabelPhoneNumber = new System.Windows.Forms.Label();
            this.GroupBoxOrderReceiptMethod = new System.Windows.Forms.GroupBox();
            this.RadiobuttonDelivery = new System.Windows.Forms.RadioButton();
            this.RadioButtonPickup = new System.Windows.Forms.RadioButton();
            this.PanelControlButtons = new System.Windows.Forms.Panel();
            this.ButtonNextStep = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.LabelMessageRequiredFields = new System.Windows.Forms.Label();
            this.GroupBoxInitials.SuspendLayout();
            this.GroupBoxHomeAddress.SuspendLayout();
            this.PanelMainContainer.SuspendLayout();
            this.GroupBoxContactInfo.SuspendLayout();
            this.GroupBoxOrderReceiptMethod.SuspendLayout();
            this.PanelControlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxInitials
            // 
            this.GroupBoxInitials.Controls.Add(this.TextBoxPatronymic);
            this.GroupBoxInitials.Controls.Add(this.LabelPatronymic);
            this.GroupBoxInitials.Controls.Add(this.TextBoxName);
            this.GroupBoxInitials.Controls.Add(this.LabelName);
            this.GroupBoxInitials.Controls.Add(this.TextBoxSurname);
            this.GroupBoxInitials.Controls.Add(this.LabelSurname);
            this.GroupBoxInitials.Location = new System.Drawing.Point(4, 4);
            this.GroupBoxInitials.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBoxInitials.Name = "GroupBoxInitials";
            this.GroupBoxInitials.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBoxInitials.Size = new System.Drawing.Size(1035, 101);
            this.GroupBoxInitials.TabIndex = 0;
            this.GroupBoxInitials.TabStop = false;
            this.GroupBoxInitials.Text = "Инициалы заказчика";
            // 
            // TextBoxPatronymic
            // 
            this.TextBoxPatronymic.Location = new System.Drawing.Point(443, 49);
            this.TextBoxPatronymic.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPatronymic.Name = "TextBoxPatronymic";
            this.TextBoxPatronymic.Size = new System.Drawing.Size(132, 22);
            this.TextBoxPatronymic.TabIndex = 5;
            // 
            // LabelPatronymic
            // 
            this.LabelPatronymic.AutoSize = true;
            this.LabelPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPatronymic.Location = new System.Drawing.Point(439, 20);
            this.LabelPatronymic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPatronymic.Name = "LabelPatronymic";
            this.LabelPatronymic.Size = new System.Drawing.Size(105, 24);
            this.LabelPatronymic.TabIndex = 4;
            this.LabelPatronymic.Text = "Отчество*";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(229, 50);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(161, 22);
            this.TextBoxName.TabIndex = 3;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(225, 20);
            this.LabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(53, 24);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Имя*";
            // 
            // TextBoxSurname
            // 
            this.TextBoxSurname.Location = new System.Drawing.Point(12, 50);
            this.TextBoxSurname.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSurname.Name = "TextBoxSurname";
            this.TextBoxSurname.Size = new System.Drawing.Size(157, 22);
            this.TextBoxSurname.TabIndex = 1;
            // 
            // LabelSurname
            // 
            this.LabelSurname.AutoSize = true;
            this.LabelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSurname.Location = new System.Drawing.Point(8, 20);
            this.LabelSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(98, 24);
            this.LabelSurname.TabIndex = 0;
            this.LabelSurname.Text = "Фамилия*";
            // 
            // GroupBoxHomeAddress
            // 
            this.GroupBoxHomeAddress.Controls.Add(this.TextBoxFlat);
            this.GroupBoxHomeAddress.Controls.Add(this.TextBoxHouseNumber);
            this.GroupBoxHomeAddress.Controls.Add(this.TextBoxPavilion);
            this.GroupBoxHomeAddress.Controls.Add(this.TextBoxStreet);
            this.GroupBoxHomeAddress.Controls.Add(this.TextBoxCity);
            this.GroupBoxHomeAddress.Controls.Add(this.LabelFlat);
            this.GroupBoxHomeAddress.Controls.Add(this.LabelStreet);
            this.GroupBoxHomeAddress.Controls.Add(this.LabelPavilion);
            this.GroupBoxHomeAddress.Controls.Add(this.LabelHouseNumber);
            this.GroupBoxHomeAddress.Controls.Add(this.LabelCity);
            this.GroupBoxHomeAddress.Location = new System.Drawing.Point(0, 61);
            this.GroupBoxHomeAddress.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBoxHomeAddress.Name = "GroupBoxHomeAddress";
            this.GroupBoxHomeAddress.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBoxHomeAddress.Size = new System.Drawing.Size(1006, 106);
            this.GroupBoxHomeAddress.TabIndex = 1;
            this.GroupBoxHomeAddress.TabStop = false;
            this.GroupBoxHomeAddress.Text = "Адрес доставки";
            this.GroupBoxHomeAddress.Visible = false;
            // 
            // TextBoxFlat
            // 
            this.TextBoxFlat.Location = new System.Drawing.Point(707, 46);
            this.TextBoxFlat.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxFlat.Name = "TextBoxFlat";
            this.TextBoxFlat.Size = new System.Drawing.Size(72, 22);
            this.TextBoxFlat.TabIndex = 12;
            // 
            // TextBoxHouseNumber
            // 
            this.TextBoxHouseNumber.Location = new System.Drawing.Point(443, 46);
            this.TextBoxHouseNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxHouseNumber.Name = "TextBoxHouseNumber";
            this.TextBoxHouseNumber.Size = new System.Drawing.Size(72, 22);
            this.TextBoxHouseNumber.TabIndex = 11;
            // 
            // TextBoxPavilion
            // 
            this.TextBoxPavilion.Location = new System.Drawing.Point(567, 46);
            this.TextBoxPavilion.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPavilion.Name = "TextBoxPavilion";
            this.TextBoxPavilion.Size = new System.Drawing.Size(72, 22);
            this.TextBoxPavilion.TabIndex = 9;
            // 
            // TextBoxStreet
            // 
            this.TextBoxStreet.Location = new System.Drawing.Point(229, 46);
            this.TextBoxStreet.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxStreet.Name = "TextBoxStreet";
            this.TextBoxStreet.Size = new System.Drawing.Size(161, 22);
            this.TextBoxStreet.TabIndex = 7;
            // 
            // TextBoxCity
            // 
            this.TextBoxCity.Location = new System.Drawing.Point(12, 46);
            this.TextBoxCity.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxCity.Name = "TextBoxCity";
            this.TextBoxCity.Size = new System.Drawing.Size(161, 22);
            this.TextBoxCity.TabIndex = 6;
            // 
            // LabelFlat
            // 
            this.LabelFlat.AutoSize = true;
            this.LabelFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFlat.Location = new System.Drawing.Point(703, 20);
            this.LabelFlat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelFlat.Name = "LabelFlat";
            this.LabelFlat.Size = new System.Drawing.Size(103, 24);
            this.LabelFlat.TabIndex = 5;
            this.LabelFlat.Text = "Квартира*";
            // 
            // LabelStreet
            // 
            this.LabelStreet.AutoSize = true;
            this.LabelStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelStreet.Location = new System.Drawing.Point(225, 20);
            this.LabelStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelStreet.Name = "LabelStreet";
            this.LabelStreet.Size = new System.Drawing.Size(71, 24);
            this.LabelStreet.TabIndex = 4;
            this.LabelStreet.Text = "Улица*";
            // 
            // LabelPavilion
            // 
            this.LabelPavilion.AutoSize = true;
            this.LabelPavilion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPavilion.Location = new System.Drawing.Point(563, 20);
            this.LabelPavilion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPavilion.Name = "LabelPavilion";
            this.LabelPavilion.Size = new System.Drawing.Size(81, 24);
            this.LabelPavilion.TabIndex = 3;
            this.LabelPavilion.Text = "Корпус*";
            // 
            // LabelHouseNumber
            // 
            this.LabelHouseNumber.AutoSize = true;
            this.LabelHouseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelHouseNumber.Location = new System.Drawing.Point(439, 20);
            this.LabelHouseNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelHouseNumber.Name = "LabelHouseNumber";
            this.LabelHouseNumber.Size = new System.Drawing.Size(55, 24);
            this.LabelHouseNumber.TabIndex = 2;
            this.LabelHouseNumber.Text = "Дом*";
            // 
            // LabelCity
            // 
            this.LabelCity.AutoSize = true;
            this.LabelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCity.Location = new System.Drawing.Point(8, 20);
            this.LabelCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCity.Name = "LabelCity";
            this.LabelCity.Size = new System.Drawing.Size(73, 24);
            this.LabelCity.TabIndex = 1;
            this.LabelCity.Text = "Город*";
            // 
            // PanelMainContainer
            // 
            this.PanelMainContainer.Controls.Add(this.GroupBoxInitials);
            this.PanelMainContainer.Controls.Add(this.GroupBoxContactInfo);
            this.PanelMainContainer.Controls.Add(this.GroupBoxOrderReceiptMethod);
            this.PanelMainContainer.Controls.Add(this.PanelControlButtons);
            this.PanelMainContainer.Location = new System.Drawing.Point(16, 15);
            this.PanelMainContainer.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMainContainer.Name = "PanelMainContainer";
            this.PanelMainContainer.Size = new System.Drawing.Size(1035, 524);
            this.PanelMainContainer.TabIndex = 2;
            // 
            // GroupBoxContactInfo
            // 
            this.GroupBoxContactInfo.Controls.Add(this.TextBoxEmailAddress);
            this.GroupBoxContactInfo.Controls.Add(this.LabelEmailAddress);
            this.GroupBoxContactInfo.Controls.Add(this.TextBoxPhoneNumber);
            this.GroupBoxContactInfo.Controls.Add(this.LabelPhoneNumber);
            this.GroupBoxContactInfo.Location = new System.Drawing.Point(3, 112);
            this.GroupBoxContactInfo.Name = "GroupBoxContactInfo";
            this.GroupBoxContactInfo.Size = new System.Drawing.Size(1032, 100);
            this.GroupBoxContactInfo.TabIndex = 3;
            this.GroupBoxContactInfo.TabStop = false;
            this.GroupBoxContactInfo.Text = "Контактные данные";
            // 
            // TextBoxEmailAddress
            // 
            this.TextBoxEmailAddress.Location = new System.Drawing.Point(230, 46);
            this.TextBoxEmailAddress.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxEmailAddress.Name = "TextBoxEmailAddress";
            this.TextBoxEmailAddress.Size = new System.Drawing.Size(244, 22);
            this.TextBoxEmailAddress.TabIndex = 9;
            // 
            // LabelEmailAddress
            // 
            this.LabelEmailAddress.AutoSize = true;
            this.LabelEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelEmailAddress.Location = new System.Drawing.Point(226, 18);
            this.LabelEmailAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelEmailAddress.Name = "LabelEmailAddress";
            this.LabelEmailAddress.Size = new System.Drawing.Size(248, 24);
            this.LabelEmailAddress.TabIndex = 8;
            this.LabelEmailAddress.Text = "Адрес электронной почты";
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(13, 46);
            this.TextBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPhoneNumber.Mask = "(00) 000-00-00";
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(161, 22);
            this.TextBoxPhoneNumber.TabIndex = 7;
            // 
            // LabelPhoneNumber
            // 
            this.LabelPhoneNumber.AutoSize = true;
            this.LabelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPhoneNumber.Location = new System.Drawing.Point(9, 18);
            this.LabelPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPhoneNumber.Name = "LabelPhoneNumber";
            this.LabelPhoneNumber.Size = new System.Drawing.Size(143, 24);
            this.LabelPhoneNumber.TabIndex = 1;
            this.LabelPhoneNumber.Text = "Моб. телефон*";
            // 
            // GroupBoxOrderReceiptMethod
            // 
            this.GroupBoxOrderReceiptMethod.Controls.Add(this.RadiobuttonDelivery);
            this.GroupBoxOrderReceiptMethod.Controls.Add(this.RadioButtonPickup);
            this.GroupBoxOrderReceiptMethod.Controls.Add(this.GroupBoxHomeAddress);
            this.GroupBoxOrderReceiptMethod.Location = new System.Drawing.Point(4, 219);
            this.GroupBoxOrderReceiptMethod.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBoxOrderReceiptMethod.Name = "GroupBoxOrderReceiptMethod";
            this.GroupBoxOrderReceiptMethod.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBoxOrderReceiptMethod.Size = new System.Drawing.Size(1031, 186);
            this.GroupBoxOrderReceiptMethod.TabIndex = 2;
            this.GroupBoxOrderReceiptMethod.TabStop = false;
            this.GroupBoxOrderReceiptMethod.Text = "Способ получения заказа";
            // 
            // RadiobuttonDelivery
            // 
            this.RadiobuttonDelivery.AutoSize = true;
            this.RadiobuttonDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadiobuttonDelivery.Location = new System.Drawing.Point(180, 23);
            this.RadiobuttonDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.RadiobuttonDelivery.Name = "RadiobuttonDelivery";
            this.RadiobuttonDelivery.Size = new System.Drawing.Size(116, 28);
            this.RadiobuttonDelivery.TabIndex = 1;
            this.RadiobuttonDelivery.TabStop = true;
            this.RadiobuttonDelivery.Text = "Доставка";
            this.RadiobuttonDelivery.UseVisualStyleBackColor = true;
            this.RadiobuttonDelivery.Click += radioBtn_Delivery_Clicked;
            // 
            // RadioButtonPickup
            // 
            this.RadioButtonPickup.AutoSize = true;
            this.RadioButtonPickup.Checked = true;
            this.RadioButtonPickup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonPickup.Location = new System.Drawing.Point(12, 25);
            this.RadioButtonPickup.Margin = new System.Windows.Forms.Padding(4);
            this.RadioButtonPickup.Name = "RadioButtonPickup";
            this.RadioButtonPickup.Size = new System.Drawing.Size(134, 28);
            this.RadioButtonPickup.TabIndex = 0;
            this.RadioButtonPickup.TabStop = true;
            this.RadioButtonPickup.Text = "Самовывоз";
            this.RadioButtonPickup.UseVisualStyleBackColor = true;
            this.RadioButtonPickup.Click += radioBtn_PickUp_Clicked;
            // 
            // PanelControlButtons
            // 
            this.PanelControlButtons.Controls.Add(this.LabelMessageRequiredFields);
            this.PanelControlButtons.Controls.Add(this.ButtonNextStep);
            this.PanelControlButtons.Controls.Add(this.ButtonBack);
            this.PanelControlButtons.Location = new System.Drawing.Point(3, 412);
            this.PanelControlButtons.Name = "PanelControlButtons";
            this.PanelControlButtons.Size = new System.Drawing.Size(1032, 112);
            this.PanelControlButtons.TabIndex = 4;
            // 
            // ButtonNextStep
            // 
            this.ButtonNextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNextStep.Location = new System.Drawing.Point(885, 81);
            this.ButtonNextStep.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonNextStep.Name = "ButtonNextStep";
            this.ButtonNextStep.Size = new System.Drawing.Size(132, 31);
            this.ButtonNextStep.TabIndex = 1;
            this.ButtonNextStep.Text = "Далее";
            this.ButtonNextStep.UseVisualStyleBackColor = true;
            this.ButtonNextStep.Click += btn_NextStepClick;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(13, 81);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(132, 31);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += btn_Back_Click;
            // 
            // LabelMessageRequiredFields
            // 
            this.LabelMessageRequiredFields.AutoSize = true;
            this.LabelMessageRequiredFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMessageRequiredFields.Location = new System.Drawing.Point(96, 16);
            this.LabelMessageRequiredFields.Name = "LabelMessageRequiredFields";
            this.LabelMessageRequiredFields.Size = new System.Drawing.Size(844, 24);
            this.LabelMessageRequiredFields.TabIndex = 2;
            this.LabelMessageRequiredFields.Text = "Были введены не все обязательные поля(*). Проверьте ввод и повторите попытку ещё " +
    "раз.";
            this.LabelMessageRequiredFields.Visible = false;
            // 
            // ClientManagerAddOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PanelMainContainer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1085, 601);
            this.MinimumSize = new System.Drawing.Size(1085, 601);
            this.Name = "ClientManagerAddOrderView";
            this.Text = "ClientManagerAddOrderView";
            this.GroupBoxInitials.ResumeLayout(false);
            this.GroupBoxInitials.PerformLayout();
            this.GroupBoxHomeAddress.ResumeLayout(false);
            this.GroupBoxHomeAddress.PerformLayout();
            this.PanelMainContainer.ResumeLayout(false);
            this.GroupBoxContactInfo.ResumeLayout(false);
            this.GroupBoxContactInfo.PerformLayout();
            this.GroupBoxOrderReceiptMethod.ResumeLayout(false);
            this.GroupBoxOrderReceiptMethod.PerformLayout();
            this.PanelControlButtons.ResumeLayout(false);
            this.PanelControlButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxInitials;
        private System.Windows.Forms.MaskedTextBox TextBoxPatronymic;
        private System.Windows.Forms.Label LabelPatronymic;
        private System.Windows.Forms.MaskedTextBox TextBoxName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.MaskedTextBox TextBoxSurname;
        private System.Windows.Forms.Label LabelSurname;
        private System.Windows.Forms.GroupBox GroupBoxHomeAddress;
        private System.Windows.Forms.Label LabelStreet;
        private System.Windows.Forms.Label LabelPavilion;
        private System.Windows.Forms.Label LabelHouseNumber;
        private System.Windows.Forms.Label LabelCity;
        private System.Windows.Forms.MaskedTextBox TextBoxFlat;
        private System.Windows.Forms.MaskedTextBox TextBoxHouseNumber;
        private System.Windows.Forms.MaskedTextBox TextBoxPavilion;
        private System.Windows.Forms.MaskedTextBox TextBoxStreet;
        private System.Windows.Forms.MaskedTextBox TextBoxCity;
        private System.Windows.Forms.Label LabelFlat;
        private System.Windows.Forms.FlowLayoutPanel PanelMainContainer;
        private System.Windows.Forms.GroupBox GroupBoxOrderReceiptMethod;
        private System.Windows.Forms.RadioButton RadiobuttonDelivery;
        private System.Windows.Forms.RadioButton RadioButtonPickup;
        private System.Windows.Forms.GroupBox GroupBoxContactInfo;
        private System.Windows.Forms.MaskedTextBox TextBoxEmailAddress;
        private System.Windows.Forms.Label LabelEmailAddress;
        private System.Windows.Forms.MaskedTextBox TextBoxPhoneNumber;
        private System.Windows.Forms.Label LabelPhoneNumber;
        private System.Windows.Forms.Panel PanelControlButtons;
        private System.Windows.Forms.Button ButtonNextStep;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label LabelMessageRequiredFields;
    }
}