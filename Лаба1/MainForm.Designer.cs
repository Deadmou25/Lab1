namespace Лаба_1_По_Тп
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.DialogWindow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListButton = new System.Windows.Forms.Button();
            this.TwoLists = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(38, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Вызов окна сообщений";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DialogWindow
            // 
            this.DialogWindow.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DialogWindow.Location = new System.Drawing.Point(38, 75);
            this.DialogWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DialogWindow.Name = "DialogWindow";
            this.DialogWindow.Size = new System.Drawing.Size(207, 26);
            this.DialogWindow.TabIndex = 1;
            this.DialogWindow.Text = "Вызов диалогового окна";
            this.DialogWindow.UseVisualStyleBackColor = false;
            this.DialogWindow.Click += new System.EventHandler(this.DialogWindow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вызов модальных форм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выбор форма для работы со списками";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ListButton
            // 
            this.ListButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ListButton.Location = new System.Drawing.Point(38, 121);
            this.ListButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(207, 26);
            this.ListButton.TabIndex = 4;
            this.ListButton.Text = "Работа с одиночным списком";
            this.ListButton.UseVisualStyleBackColor = false;
            this.ListButton.Click += new System.EventHandler(this.ListButton_Click);
            // 
            // TwoLists
            // 
            this.TwoLists.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TwoLists.Location = new System.Drawing.Point(38, 152);
            this.TwoLists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TwoLists.Name = "TwoLists";
            this.TwoLists.Size = new System.Drawing.Size(207, 26);
            this.TwoLists.TabIndex = 5;
            this.TwoLists.Text = "Работа с несколькими списками";
            this.TwoLists.UseVisualStyleBackColor = false;
            this.TwoLists.Click += new System.EventHandler(this.TwoLists_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(288, 243);
            this.Controls.Add(this.TwoLists);
            this.Controls.Add(this.ListButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DialogWindow);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DialogWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ListButton;
        private System.Windows.Forms.Button TwoLists;
    }
}

