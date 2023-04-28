namespace WindowsFormsApp20
{
    partial class Form1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtSumma = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(699, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(12, 65);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(142, 20);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "0";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(188, 65);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(142, 20);
            this.txtB.TabIndex = 2;
            this.txtB.Text = "0";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(359, 65);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(142, 20);
            this.txtC.TabIndex = 3;
            this.txtC.Text = "0";
            this.txtC.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtSumma
            // 
            this.txtSumma.Location = new System.Drawing.Point(531, 65);
            this.txtSumma.Name = "txtSumma";
            this.txtSumma.Size = new System.Drawing.Size(142, 20);
            this.txtSumma.TabIndex = 4;
            this.txtSumma.Text = "0";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(570, 385);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(92, 31);
            this.btnCount.TabIndex = 5;
            this.btnCount.Text = "Вычислить";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtSumma);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtSumma;
        private System.Windows.Forms.Button btnCount;
    }
}

