
namespace WindowsFormsApp3
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
            this.buttonSolve = new System.Windows.Forms.Button();
            this.inputNumber1 = new System.Windows.Forms.TextBox();
            this.inputNumber2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSolve
            // 
            this.buttonSolve.Location = new System.Drawing.Point(389, 236);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(75, 23);
            this.buttonSolve.TabIndex = 0;
            this.buttonSolve.Text = "button1";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // inputNumber1
            // 
            this.inputNumber1.Location = new System.Drawing.Point(101, 177);
            this.inputNumber1.Name = "inputNumber1";
            this.inputNumber1.Size = new System.Drawing.Size(100, 22);
            this.inputNumber1.TabIndex = 1;
            // 
            // inputNumber2
            // 
            this.inputNumber2.Location = new System.Drawing.Point(563, 177);
            this.inputNumber2.Name = "inputNumber2";
            this.inputNumber2.Size = new System.Drawing.Size(100, 22);
            this.inputNumber2.TabIndex = 2;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(389, 315);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(46, 17);
            this.result.TabIndex = 3;
            this.result.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.inputNumber2);
            this.Controls.Add(this.inputNumber1);
            this.Controls.Add(this.buttonSolve);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.TextBox inputNumber1;
        private System.Windows.Forms.TextBox inputNumber2;
        private System.Windows.Forms.Label result;
    }
}

