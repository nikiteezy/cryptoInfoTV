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
            this.nameCoinFirstLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameCoinFirstLbl
            // 
            this.nameCoinFirstLbl.AutoSize = true;
            this.nameCoinFirstLbl.Location = new System.Drawing.Point(47, 32);
            this.nameCoinFirstLbl.Name = "nameCoinFirstLbl";
            this.nameCoinFirstLbl.Size = new System.Drawing.Size(35, 13);
            this.nameCoinFirstLbl.TabIndex = 0;
            this.nameCoinFirstLbl.Text = "label1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 985);
            this.Controls.Add(this.nameCoinFirstLbl);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypto Info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameCoinFirstLbl;
    }
}

