namespace Лаба_1_По_Тп
{
    partial class ListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewElemTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.NumElemTextBox = new System.Windows.Forms.TextBox();
            this.SearchNumberTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.StringListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchSuccessTextBox = new System.Windows.Forms.TextBox();
            this.EmptyPrTextBox = new System.Windows.Forms.TextBox();
            this.elemNumberTextBox = new System.Windows.Forms.TextBox();
            this.IndexTextBox = new System.Windows.Forms.TextBox();
            this.ActiveElemTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новый элемент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер элемента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Элемент поиска ";
            // 
            // NewElemTextBox
            // 
            this.NewElemTextBox.Location = new System.Drawing.Point(122, 54);
            this.NewElemTextBox.Name = "NewElemTextBox";
            this.NewElemTextBox.Size = new System.Drawing.Size(100, 20);
            this.NewElemTextBox.TabIndex = 3;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(132, 80);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить ";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // NumElemTextBox
            // 
            this.NumElemTextBox.Location = new System.Drawing.Point(122, 109);
            this.NumElemTextBox.Name = "NumElemTextBox";
            this.NumElemTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumElemTextBox.TabIndex = 5;
            // 
            // SearchNumberTextBox
            // 
            this.SearchNumberTextBox.Location = new System.Drawing.Point(122, 138);
            this.SearchNumberTextBox.Name = "SearchNumberTextBox";
            this.SearchNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchNumberTextBox.TabIndex = 6;
            this.SearchNumberTextBox.TextChanged += new System.EventHandler(this.SearchNumberTextBox_TextChanged);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(132, 164);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Поиск ";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Аргументы";
            // 
            // StringListBox
            // 
            this.StringListBox.FormattingEnabled = true;
            this.StringListBox.Location = new System.Drawing.Point(248, 54);
            this.StringListBox.Name = "StringListBox";
            this.StringListBox.Size = new System.Drawing.Size(120, 95);
            this.StringListBox.TabIndex = 9;
            this.StringListBox.SelectedIndexChanged += new System.EventHandler(this.StringListBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Список";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Результаты запроса ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Активный элемент";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Индекс";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(399, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Количество элементов";
            // 
            // SearchSuccessTextBox
            // 
            this.SearchSuccessTextBox.Location = new System.Drawing.Point(539, 167);
            this.SearchSuccessTextBox.Name = "SearchSuccessTextBox";
            this.SearchSuccessTextBox.Size = new System.Drawing.Size(100, 20);
            this.SearchSuccessTextBox.TabIndex = 24;
            // 
            // EmptyPrTextBox
            // 
            this.EmptyPrTextBox.Location = new System.Drawing.Point(539, 141);
            this.EmptyPrTextBox.Name = "EmptyPrTextBox";
            this.EmptyPrTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmptyPrTextBox.TabIndex = 23;
            // 
            // elemNumberTextBox
            // 
            this.elemNumberTextBox.Location = new System.Drawing.Point(539, 112);
            this.elemNumberTextBox.Name = "elemNumberTextBox";
            this.elemNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.elemNumberTextBox.TabIndex = 22;
            // 
            // IndexTextBox
            // 
            this.IndexTextBox.Location = new System.Drawing.Point(539, 83);
            this.IndexTextBox.Name = "IndexTextBox";
            this.IndexTextBox.Size = new System.Drawing.Size(100, 20);
            this.IndexTextBox.TabIndex = 21;
            // 
            // ActiveElemTextBox
            // 
            this.ActiveElemTextBox.Location = new System.Drawing.Point(539, 54);
            this.ActiveElemTextBox.Name = "ActiveElemTextBox";
            this.ActiveElemTextBox.Size = new System.Drawing.Size(100, 20);
            this.ActiveElemTextBox.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Пустой список?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(399, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Успешен ли поиск?";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(257, 164);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(104, 23);
            this.ClearButton.TabIndex = 28;
            this.ClearButton.Text = "Очистить список";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 238);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SearchSuccessTextBox);
            this.Controls.Add(this.EmptyPrTextBox);
            this.Controls.Add(this.elemNumberTextBox);
            this.Controls.Add(this.IndexTextBox);
            this.Controls.Add(this.ActiveElemTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StringListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.SearchNumberTextBox);
            this.Controls.Add(this.NumElemTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NewElemTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с одиночным списком";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewElemTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox NumElemTextBox;
        private System.Windows.Forms.TextBox SearchNumberTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox StringListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SearchSuccessTextBox;
        private System.Windows.Forms.TextBox elemNumberTextBox;
        private System.Windows.Forms.TextBox IndexTextBox;
        private System.Windows.Forms.TextBox ActiveElemTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox EmptyPrTextBox;
        private System.Windows.Forms.Button ClearButton;
    }
}