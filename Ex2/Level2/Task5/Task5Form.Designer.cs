namespace Level1
{
    partial class Task5Form
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonCount = new System.Windows.Forms.Button();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(123, 40);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonCount
            // 
            this.buttonCount.BackColor = System.Drawing.Color.LightGreen;
            this.buttonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCount.Location = new System.Drawing.Point(12, 126);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(464, 40);
            this.buttonCount.TabIndex = 15;
            this.buttonCount.Text = "Сгенерировать и сдвинуть массив";
            this.buttonCount.UseVisualStyleBackColor = false;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // textBox0
            // 
            this.textBox0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox0.Location = new System.Drawing.Point(12, 80);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(490, 27);
            this.textBox0.TabIndex = 14;
            this.textBox0.Text = "Введите размерность массива: ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 258);
            this.label1.TabIndex = 16;
            // 
            // Task5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.textBox0);
            this.Controls.Add(this.buttonBack);
            this.Name = "Task5Form";
            this.Text = "Task5Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.Label label1;
    }
}
