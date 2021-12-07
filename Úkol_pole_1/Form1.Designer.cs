
namespace Úkol_pole_1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox = new System.Windows.Forms.TextBox();
            this.listBox_before = new System.Windows.Forms.ListBox();
            this.listBox_after = new System.Windows.Forms.ListBox();
            this.button = new System.Windows.Forms.Button();
            this.radioButton_sestupne = new System.Windows.Forms.RadioButton();
            this.radioButton_vzestupne = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(234, 32);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(112, 22);
            this.textBox.TabIndex = 0;
            // 
            // listBox_before
            // 
            this.listBox_before.FormattingEnabled = true;
            this.listBox_before.ItemHeight = 16;
            this.listBox_before.Location = new System.Drawing.Point(28, 22);
            this.listBox_before.Name = "listBox_before";
            this.listBox_before.Size = new System.Drawing.Size(92, 276);
            this.listBox_before.TabIndex = 1;
            // 
            // listBox_after
            // 
            this.listBox_after.FormattingEnabled = true;
            this.listBox_after.ItemHeight = 16;
            this.listBox_after.Location = new System.Drawing.Point(126, 22);
            this.listBox_after.Name = "listBox_after";
            this.listBox_after.Size = new System.Drawing.Size(92, 276);
            this.listBox_after.TabIndex = 2;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(361, 27);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(83, 33);
            this.button.TabIndex = 3;
            this.button.Text = "Setřiď";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton_sestupne
            // 
            this.radioButton_sestupne.AutoSize = true;
            this.radioButton_sestupne.ForeColor = System.Drawing.Color.White;
            this.radioButton_sestupne.Location = new System.Drawing.Point(234, 85);
            this.radioButton_sestupne.Name = "radioButton_sestupne";
            this.radioButton_sestupne.Size = new System.Drawing.Size(89, 21);
            this.radioButton_sestupne.TabIndex = 4;
            this.radioButton_sestupne.TabStop = true;
            this.radioButton_sestupne.Text = "Sestupně";
            this.radioButton_sestupne.UseVisualStyleBackColor = true;
            // 
            // radioButton_vzestupne
            // 
            this.radioButton_vzestupne.AutoSize = true;
            this.radioButton_vzestupne.ForeColor = System.Drawing.Color.White;
            this.radioButton_vzestupne.Location = new System.Drawing.Point(234, 123);
            this.radioButton_vzestupne.Name = "radioButton_vzestupne";
            this.radioButton_vzestupne.Size = new System.Drawing.Size(96, 21);
            this.radioButton_vzestupne.TabIndex = 5;
            this.radioButton_vzestupne.TabStop = true;
            this.radioButton_vzestupne.Text = "Vzestupně";
            this.radioButton_vzestupne.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(467, 323);
            this.Controls.Add(this.radioButton_vzestupne);
            this.Controls.Add(this.radioButton_sestupne);
            this.Controls.Add(this.button);
            this.Controls.Add(this.listBox_after);
            this.Controls.Add(this.listBox_before);
            this.Controls.Add(this.textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Úkol pole 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ListBox listBox_before;
        private System.Windows.Forms.ListBox listBox_after;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.RadioButton radioButton_sestupne;
        private System.Windows.Forms.RadioButton radioButton_vzestupne;
    }
}

