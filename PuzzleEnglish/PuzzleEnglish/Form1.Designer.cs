namespace PuzzleEnglish
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_russian = new System.Windows.Forms.Label();
            this.label_english = new System.Windows.Forms.Label();
            this.picture_card = new System.Windows.Forms.PictureBox();
            this.button_prev = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_card)).BeginInit();
            this.SuspendLayout();
            // 
            // label_russian
            // 
            this.label_russian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_russian.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_russian.ForeColor = System.Drawing.Color.Red;
            this.label_russian.Location = new System.Drawing.Point(68, 12);
            this.label_russian.Name = "label_russian";
            this.label_russian.Size = new System.Drawing.Size(205, 41);
            this.label_russian.TabIndex = 0;
            this.label_russian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_english
            // 
            this.label_english.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_english.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_english.ForeColor = System.Drawing.Color.Blue;
            this.label_english.Location = new System.Drawing.Point(68, 261);
            this.label_english.Name = "label_english";
            this.label_english.Size = new System.Drawing.Size(205, 52);
            this.label_english.TabIndex = 1;
            this.label_english.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picture_card
            // 
            this.picture_card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_card.Location = new System.Drawing.Point(68, 54);
            this.picture_card.Name = "picture_card";
            this.picture_card.Size = new System.Drawing.Size(205, 205);
            this.picture_card.TabIndex = 2;
            this.picture_card.TabStop = false;
            // 
            // button_prev
            // 
            this.button_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_prev.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_prev.Location = new System.Drawing.Point(5, 114);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(62, 68);
            this.button_prev.TabIndex = 3;
            this.button_prev.Text = "<<";
            this.button_prev.UseVisualStyleBackColor = true;
            // 
            // button_next
            // 
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_next.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_next.Location = new System.Drawing.Point(279, 114);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(62, 68);
            this.button_next.TabIndex = 4;
            this.button_next.Text = ">>";
            this.button_next.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "+ видео";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.picture_card);
            this.Controls.Add(this.label_english);
            this.Controls.Add(this.label_russian);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle English";
            ((System.ComponentModel.ISupportInitialize)(this.picture_card)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_russian;
        private System.Windows.Forms.Label label_english;
        private System.Windows.Forms.PictureBox picture_card;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label label1;
    }
}

