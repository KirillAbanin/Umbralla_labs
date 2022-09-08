
namespace WindowsFormsApp2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.precision = new System.Windows.Forms.TextBox();
            this.inputX = new System.Windows.Forms.TextBox();
            this.solve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.arcsinResult = new System.Windows.Forms.Label();
            this.sumResult = new System.Windows.Forms.Label();
            this.iterResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Снимок;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(87, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 191);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите точность 0 < x < 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите аргумент x";
            // 
            // precision
            // 
            this.precision.Location = new System.Drawing.Point(137, 236);
            this.precision.Name = "precision";
            this.precision.Size = new System.Drawing.Size(100, 22);
            this.precision.TabIndex = 3;
            this.precision.TextChanged += new System.EventHandler(this.precision_TextChanged);
            this.precision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precision_KeyPress);
            // 
            // inputX
            // 
            this.inputX.Location = new System.Drawing.Point(539, 236);
            this.inputX.Name = "inputX";
            this.inputX.Size = new System.Drawing.Size(100, 22);
            this.inputX.TabIndex = 4;
            this.inputX.TextChanged += new System.EventHandler(this.inputX_TextChanged);
            // 
            // solve
            // 
            this.solve.Enabled = false;
            this.solve.Location = new System.Drawing.Point(345, 281);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(94, 35);
            this.solve.TabIndex = 5;
            this.solve.Text = "Вычислить";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "arcsin(x) = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Сумма ряда ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Количество членов ряда ";
            // 
            // arcsinResult
            // 
            this.arcsinResult.AutoSize = true;
            this.arcsinResult.Location = new System.Drawing.Point(172, 347);
            this.arcsinResult.Name = "arcsinResult";
            this.arcsinResult.Size = new System.Drawing.Size(0, 17);
            this.arcsinResult.TabIndex = 9;
            // 
            // sumResult
            // 
            this.sumResult.AutoSize = true;
            this.sumResult.Location = new System.Drawing.Point(184, 382);
            this.sumResult.Name = "sumResult";
            this.sumResult.Size = new System.Drawing.Size(0, 17);
            this.sumResult.TabIndex = 10;
            // 
            // iterResult
            // 
            this.iterResult.AutoSize = true;
            this.iterResult.Location = new System.Drawing.Point(271, 418);
            this.iterResult.Name = "iterResult";
            this.iterResult.Size = new System.Drawing.Size(0, 17);
            this.iterResult.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.iterResult);
            this.Controls.Add(this.sumResult);
            this.Controls.Add(this.arcsinResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.inputX);
            this.Controls.Add(this.precision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox precision;
        private System.Windows.Forms.TextBox inputX;
        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label arcsinResult;
        private System.Windows.Forms.Label sumResult;
        private System.Windows.Forms.Label iterResult;
    }
}

