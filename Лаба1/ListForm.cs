using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_1_По_Тп
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (SearchNumberTextBox.Text.Length > 0)
            {
                //Если индекс искомого элемента в списке меньше нуля, то…	
                if (StringListBox.Items.IndexOf(SearchNumberTextBox.Text) < 0)
                    SearchSuccessTextBox.Text = "Нет"; //выводим строку "Нет"
                else //В противном случае

                    SearchSuccessTextBox.Text = "Да"; //выводим строку "Да"
            }
        }

        private void StringListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Текстовой строке присваиваем индекс выделенной строки, увеличенный на единицу
            NumElemTextBox.Text = (StringListBox.SelectedIndex + 1).ToString();
            //Изменяем содержимое поля "Активный элемент"
            ActiveElemTextBox.Text = StringListBox.SelectedItem.ToString();
            //Изменяем содержимое поля "Индекс"
            IndexTextBox.Text = StringListBox.SelectedIndex.ToString();
            //Изменяем содержимое поля "Количество элементов"
            elemNumberTextBox.Text = StringListBox.Items.Count.ToString();
            //Изменяем содержимое поля "Количество элементов"
            if (StringListBox.Items.Count == 0) EmptyPrTextBox.Text = "Список пустой";
            else EmptyPrTextBox.Text = "Список не пуст!";
         
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Если в поле для формирования строки ничего нет, то ничего не делаем
            if (NewElemTextBox.Text.Length <= 0) return;
            //Добавляем в список содержимое поля текстовой строки
            StringListBox.Items.Add(NewElemTextBox.Text);
            //Очищаем содержимое поля текстовой строки
            NewElemTextBox.Clear();
        }

        private void SearchNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            StringListBox.Items.Clear();
        }
    }
}
