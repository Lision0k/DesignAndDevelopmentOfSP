namespace Level1
{
    partial class Task3Form
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
            this.buttonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCount.Location = new System.Drawing.Point(12, 85);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(346, 40);
            this.buttonCount.TabIndex = 14;
            this.buttonCount.Text = "Заполнить и подсчитать";
            this.buttonCount.UseVisualStyleBackColor = false;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(741, 293);
            this.label1.TabIndex = 15;
            // 
            // Task3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.buttonBack);
            this.Name = "Task3Form";
            this.Text = "Task3Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Label label1;
    }
}
