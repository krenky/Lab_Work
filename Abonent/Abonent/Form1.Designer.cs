
namespace Abonent
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
            this.BookBox = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.MinLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BookBox
            // 
            this.BookBox.FormattingEnabled = true;
            this.BookBox.Location = new System.Drawing.Point(12, 12);
            this.BookBox.Name = "BookBox";
            this.BookBox.Size = new System.Drawing.Size(121, 21);
            this.BookBox.TabIndex = 0;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(12, 39);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 1;
            this.NameBox.Text = "Имя";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 78);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить абонента";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(12, 107);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(121, 23);
            this.ChangeButton.TabIndex = 4;
            this.ChangeButton.Text = "Изменить минуты";
            this.ChangeButton.UseVisualStyleBackColor = true;
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.Location = new System.Drawing.Point(9, 62);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(46, 13);
            this.MinLabel.TabIndex = 5;
            this.MinLabel.Text = "Минуты";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 146);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.BookBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BookBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label MinLabel;
    }
}

