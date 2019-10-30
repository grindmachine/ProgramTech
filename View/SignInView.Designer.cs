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
            this.flpButton = new System.Windows.Forms.FlowLayoutPanel();
            this.bookerButton = new System.Windows.Forms.Button();
            this.storekeeperButton = new System.Windows.Forms.Button();
            this.PurcрManagerButton = new System.Windows.Forms.Button();
            this.ClientManagerButton = new System.Windows.Forms.Button();
            this.flpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpButton
            // 
            this.flpButton.Controls.Add(this.bookerButton);
            this.flpButton.Controls.Add(this.storekeeperButton);
            this.flpButton.Controls.Add(this.PurcрManagerButton);
            this.flpButton.Controls.Add(this.ClientManagerButton);
            this.flpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpButton.Location = new System.Drawing.Point(0, 0);
            this.flpButton.Name = "flpButton";
            this.flpButton.Size = new System.Drawing.Size(374, 213);
            this.flpButton.TabIndex = 0;
            // 
            // bookerButton
            // 
            this.bookerButton.AutoSize = true;
            this.bookerButton.Location = new System.Drawing.Point(3, 3);
            this.bookerButton.Name = "Бухгалтер";
            this.bookerButton.Size = new System.Drawing.Size(180, 100);
            this.bookerButton.TabIndex = 0;
            this.bookerButton.Text = "Бухгалтер";
            this.bookerButton.UseVisualStyleBackColor = true;
            this.bookerButton.Click += btn_bookerButton_Click;
            // 
            // storekeeperButton
            // 
            this.storekeeperButton.AutoSize = true;
            this.storekeeperButton.Location = new System.Drawing.Point(189, 3);
            this.storekeeperButton.Name = "Кладовщик";
            this.storekeeperButton.Size = new System.Drawing.Size(180, 100);
            this.storekeeperButton.TabIndex = 1;
            this.storekeeperButton.Text = "Кладовщик";
            this.storekeeperButton.UseVisualStyleBackColor = true;
            this.storekeeperButton.Click += btn_storekeeperButton_Click;
            // 
            // PurcрManagerButton
            // 
            this.PurcрManagerButton.AutoSize = true;
            this.PurcрManagerButton.Location = new System.Drawing.Point(3, 109);
            this.PurcрManagerButton.Name = "Менеджер по закупкам";
            this.PurcрManagerButton.Size = new System.Drawing.Size(180, 100);
            this.PurcрManagerButton.TabIndex = 2;
            this.PurcрManagerButton.Text = "Менеджер по закупкам";
            this.PurcрManagerButton.UseVisualStyleBackColor = true;
            this.PurcрManagerButton.Click += btn_PurcрManagerButton_Click;
            // 
            // ClientManagerButton
            // 
            this.ClientManagerButton.AutoSize = true;
            this.ClientManagerButton.Location = new System.Drawing.Point(189, 109);
            this.ClientManagerButton.Name = "Менеджер по работе с клиентами";
            this.ClientManagerButton.Size = new System.Drawing.Size(180, 100);
            this.ClientManagerButton.TabIndex = 3;
            this.ClientManagerButton.Text = "Менеджер по клиентам";
            this.ClientManagerButton.UseVisualStyleBackColor = true;
            this.ClientManagerButton.Click += btn_ClientManagerButton_Click;
            // 
            // SignInView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 213);
            this.Controls.Add(this.flpButton);
            this.MaximumSize = new System.Drawing.Size(390, 252);
            this.MinimumSize = new System.Drawing.Size(390, 252);
            this.Name = "SignInView";
            this.Text = "Окно авторизации";
            this.flpButton.ResumeLayout(false);
            this.flpButton.PerformLayout();
            this.ResumeLayout(false);

        }

        private void PurcрManagerButton_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpButton;
        private Button bookerButton;
        private Button storekeeperButton;
        private Button PurcрManagerButton;
        private Button ClientManagerButton;
    }
}

