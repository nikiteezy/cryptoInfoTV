namespace TVTestForm
{
    partial class FormMain
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
            this.coinName_first = new System.Windows.Forms.Label();
            this.coinBid_first = new System.Windows.Forms.Label();
            this.coinLast_first = new System.Windows.Forms.Label();
            this.coinAsk_first = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // coinName_first
            // 
            this.coinName_first.AutoSize = true;
            this.coinName_first.Location = new System.Drawing.Point(70, 29);
            this.coinName_first.Name = "coinName_first";
            this.coinName_first.Size = new System.Drawing.Size(35, 13);
            this.coinName_first.TabIndex = 0;
            this.coinName_first.Text = "label1";
            // 
            // coinBid_first
            // 
            this.coinBid_first.AutoSize = true;
            this.coinBid_first.Location = new System.Drawing.Point(25, 82);
            this.coinBid_first.Name = "coinBid_first";
            this.coinBid_first.Size = new System.Drawing.Size(35, 13);
            this.coinBid_first.TabIndex = 1;
            this.coinBid_first.Text = "label1";
            // 
            // coinLast_first
            // 
            this.coinLast_first.AutoSize = true;
            this.coinLast_first.Location = new System.Drawing.Point(61, 57);
            this.coinLast_first.Name = "coinLast_first";
            this.coinLast_first.Size = new System.Drawing.Size(35, 13);
            this.coinLast_first.TabIndex = 2;
            this.coinLast_first.Text = "label1";
            // 
            // coinAsk_first
            // 
            this.coinAsk_first.AutoSize = true;
            this.coinAsk_first.Location = new System.Drawing.Point(95, 82);
            this.coinAsk_first.Name = "coinAsk_first";
            this.coinAsk_first.Size = new System.Drawing.Size(35, 13);
            this.coinAsk_first.TabIndex = 3;
            this.coinAsk_first.Text = "label1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 985);
            this.Controls.Add(this.coinAsk_first);
            this.Controls.Add(this.coinLast_first);
            this.Controls.Add(this.coinBid_first);
            this.Controls.Add(this.coinName_first);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypto Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label coinName_first;
        private System.Windows.Forms.Label coinBid_first;
        private System.Windows.Forms.Label coinLast_first;
        private System.Windows.Forms.Label coinAsk_first;
    }
}

