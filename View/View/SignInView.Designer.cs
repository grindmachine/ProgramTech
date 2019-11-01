using System.Windows.Forms;

namespace View
{
    partial class SignInView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.BookerButton = new System.Windows.Forms.Button();
            this.StorekeeperButton = new System.Windows.Forms.Button();
            this.PurcрManagerButton = new System.Windows.Forms.Button();
            this.ClientManagerButton = new System.Windows.Forms.Button();
            this.CourierButton = new System.Windows.Forms.Button();
            this.FlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpButton
            // 
            this.FlowLayout.Controls.Add(this.BookerButton);
            this.FlowLayout.Controls.Add(this.StorekeeperButton);
            this.FlowLayout.Controls.Add(this.PurcрManagerButton);
            this.FlowLayout.Controls.Add(this.ClientManagerButton);
            this.FlowLayout.Controls.Add(this.CourierButton);
            this.FlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayout.Location = new System.Drawing.Point(0, 0);
            this.FlowLayout.Name = "flpButton";
            this.FlowLayout.Size = new System.Drawing.Size(186, 529);
            this.FlowLayout.TabIndex = 0;
            // 
            // bookerButton
            // 
            this.BookerButton.AutoSize = true;
            this.BookerButton.Location = new System.Drawing.Point(3, 3);
            this.BookerButton.Name = "bookerButton";
            this.BookerButton.Size = new System.Drawing.Size(180, 100);
            this.BookerButton.TabIndex = 0;
            this.BookerButton.Text = "Бухгалтер";
            this.BookerButton.UseVisualStyleBackColor = true;
            this.BookerButton.Click += btn_bookerButton_Click;

            // 
            // storekeeperButton
            // 
            this.StorekeeperButton.AutoSize = true;
            this.StorekeeperButton.Location = new System.Drawing.Point(3, 109);
            this.StorekeeperButton.Name = "storekeeperButton";
            this.StorekeeperButton.Size = new System.Drawing.Size(180, 100);
            this.StorekeeperButton.TabIndex = 1;
            this.StorekeeperButton.Text = "Кладовщик";
            this.StorekeeperButton.UseVisualStyleBackColor = true;
            this.StorekeeperButton.Click += btn_storekeeperButton_Click;
            // 
            // PurcрManagerButton
            // 
            this.PurcрManagerButton.AutoSize = true;
            this.PurcрManagerButton.Location = new System.Drawing.Point(3, 215);
            this.PurcрManagerButton.Name = "PurcрManagerButton";
            this.PurcрManagerButton.Size = new System.Drawing.Size(180, 100);
            this.PurcрManagerButton.TabIndex = 2;
            this.PurcрManagerButton.Text = "Менеджер по закупкам";
            this.PurcрManagerButton.UseVisualStyleBackColor = true;
            this.PurcрManagerButton.Click += btn_PurcрManagerButton_Click;
            // 
            // ClientManagerButton
            // 
            this.ClientManagerButton.AutoSize = true;
            this.ClientManagerButton.Location = new System.Drawing.Point(3, 321);
            this.ClientManagerButton.Name = "ClientManagerButton";
            this.ClientManagerButton.Size = new System.Drawing.Size(180, 100);
            this.ClientManagerButton.TabIndex = 3;
            this.ClientManagerButton.Text = "Менеджер по клиентам";
            this.ClientManagerButton.UseVisualStyleBackColor = true;
            this.ClientManagerButton.Click += btn_ClientManagerButton_Click;
            // 
            // CourierButton
            // 
            this.CourierButton.Location = new System.Drawing.Point(3, 427);
            this.CourierButton.Name = "CourierButton";
            this.CourierButton.Size = new System.Drawing.Size(180, 100);
            this.CourierButton.TabIndex = 4;
            this.CourierButton.Text = "Курьер";
            this.CourierButton.UseVisualStyleBackColor = true;
            this.CourierButton.Click += btn_CourierButton_Click;
            // 
            // SignInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 529);
            this.Controls.Add(this.FlowLayout);
            this.MinimumSize = new System.Drawing.Size(0, 252);
            this.Name = "SignInView";
            this.Text = "Окно авторизации";
            this.FlowLayout.ResumeLayout(false);
            this.FlowLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        private void PurcрManagerButton_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
        private Button BookerButton;
        private Button StorekeeperButton;
        private Button PurcрManagerButton;
        private Button ClientManagerButton;
        private Button CourierButton;
    }
}

