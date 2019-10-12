namespace Лаба_1_По_Тп
{
    partial class TwoLists
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SelectedItems = new System.Windows.Forms.Button();
            this.AllItems = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1212121",
            "121212121212",
            "13245263254435",
            "3245325234535",
            "4543523453245"});
            this.listBox1.Location = new System.Drawing.Point(27, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(130, 95);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.Enter += new System.EventHandler(this.listBox1_Enter);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(259, 43);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.Sorted = true;
            this.listBox2.TabIndex = 1;
            this.listBox2.Enter += new System.EventHandler(this.listBox2_Enter);
            // 
            // SelectedItems
            // 
            this.SelectedItems.Location = new System.Drawing.Point(178, 53);
            this.SelectedItems.Name = "SelectedItems";
            this.SelectedItems.Size = new System.Drawing.Size(55, 23);
            this.SelectedItems.TabIndex = 2;
            this.SelectedItems.Text = ">";
            this.SelectedItems.UseVisualStyleBackColor = true;
            this.SelectedItems.Click += new System.EventHandler(this.button1_Click);
            // 
            // AllItems
            // 
            this.AllItems.Location = new System.Drawing.Point(178, 98);
            this.AllItems.Name = "AllItems";
            this.AllItems.Size = new System.Drawing.Size(55, 23);
            this.AllItems.TabIndex = 3;
            this.AllItems.Text = ">>";
            this.AllItems.UseVisualStyleBackColor = true;
            this.AllItems.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Сохранить выбор";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(259, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Не сохранять ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // TwoLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(422, 258);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AllItems);
            this.Controls.Add(this.SelectedItems);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "TwoLists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с несколькими списками ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button SelectedItems;
        private System.Windows.Forms.Button AllItems;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}