using System.Threading;

namespace View
{
    partial class ClientManagerAddOrderSecondStepView
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
            this.PanelAddProduct = new System.Windows.Forms.Panel();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.PanelGeneral = new System.Windows.Forms.FlowLayoutPanel();
            this.GroupBoxListProducts = new System.Windows.Forms.GroupBox();
            this.PanelListProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelControlButtons = new System.Windows.Forms.Panel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.PanelAddProduct.SuspendLayout();
            this.PanelGeneral.SuspendLayout();
            this.GroupBoxListProducts.SuspendLayout();
            this.PanelControlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelAddProduct
            // 
            this.PanelAddProduct.Controls.Add(this.ButtonAddProduct);
            this.PanelAddProduct.Location = new System.Drawing.Point(3, 3);
            this.PanelAddProduct.Name = "PanelAddProduct";
            this.PanelAddProduct.Size = new System.Drawing.Size(770, 47);
            this.PanelAddProduct.TabIndex = 1;
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddProduct.Location = new System.Drawing.Point(3, 3);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(222, 41);
            this.ButtonAddProduct.TabIndex = 1;
            this.ButtonAddProduct.Text = "Добавить товар";
            this.ButtonAddProduct.UseVisualStyleBackColor = true;
            this.ButtonAddProduct.Click += btn_AddProduct_Click;
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.Controls.Add(this.PanelAddProduct);
            this.PanelGeneral.Controls.Add(this.GroupBoxListProducts);
            this.PanelGeneral.Controls.Add(this.PanelControlButtons);
            this.PanelGeneral.Location = new System.Drawing.Point(12, 12);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.Size = new System.Drawing.Size(776, 511);
            this.PanelGeneral.TabIndex = 3;
            // 
            // GroupBoxListProducts
            // 
            this.GroupBoxListProducts.Controls.Add(this.PanelListProducts);
            this.GroupBoxListProducts.Location = new System.Drawing.Point(3, 56);
            this.GroupBoxListProducts.Name = "GroupBoxListProducts";
            this.GroupBoxListProducts.Size = new System.Drawing.Size(773, 392);
            this.GroupBoxListProducts.TabIndex = 3;
            this.GroupBoxListProducts.TabStop = false;
            this.GroupBoxListProducts.Text = "Товары в корзине";
            // 
            // PanelListProducts
            // 
            this.PanelListProducts.AutoScroll = true;
            this.PanelListProducts.Location = new System.Drawing.Point(-3, 21);
            this.PanelListProducts.Name = "PanelListProducts";
            this.PanelListProducts.Size = new System.Drawing.Size(773, 368);
            this.PanelListProducts.TabIndex = 0;
            // 
            // PanelControlButtons
            // 
            this.PanelControlButtons.Controls.Add(this.ButtonCancel);
            this.PanelControlButtons.Controls.Add(this.ButtonBack);
            this.PanelControlButtons.Location = new System.Drawing.Point(3, 454);
            this.PanelControlButtons.Name = "PanelControlButtons";
            this.PanelControlButtons.Size = new System.Drawing.Size(770, 51);
            this.PanelControlButtons.TabIndex = 2;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCancel.Location = new System.Drawing.Point(674, 7);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(93, 41);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += btn_Cancel_Click;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(3, 7);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(93, 41);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += btn_Back_Click;
            // 
            // ClientManagerAddOrderSecondStepView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.PanelGeneral);
            this.MaximumSize = new System.Drawing.Size(818, 578);
            this.MinimumSize = new System.Drawing.Size(818, 578);
            this.Name = "ClientManagerAddOrderSecondStepView";
            this.Text = " ";
            this.PanelAddProduct.ResumeLayout(false);
            this.PanelGeneral.ResumeLayout(false);
            this.GroupBoxListProducts.ResumeLayout(false);
            this.PanelControlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelAddProduct;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.FlowLayoutPanel PanelGeneral;
        private System.Windows.Forms.Button ButtonAddProduct;
        private System.Windows.Forms.Panel PanelControlButtons;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.GroupBox GroupBoxListProducts;
        private System.Windows.Forms.FlowLayoutPanel PanelListProducts;
    }
}