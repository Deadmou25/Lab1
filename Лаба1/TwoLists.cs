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
    public partial class TwoLists : Form
    {
        public TwoLists()
        {
            InitializeComponent();
        }
       
        private void listBox1_Enter(object sender, EventArgs e)
        {
            SelectedItems.Text = ">"; AllItems.Text = ">>";
        }

        private void listBox2_Enter(object sender, EventArgs e)
        {
            SelectedItems.Text = "<"; AllItems.Text = "<<";
        }

        private void button1_Click(object sender,EventArgs e)
        {
            if (SelectedItems.Text == ">")
            {
                MoveSelectedItems(listBox1, listBox2);
            }
            else
                MoveSelectedItems(listBox2, listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AllItems.Text == ">>")
                MoveAllItems(listBox1, listBox2);
            else
                MoveAllItems(listBox2, listBox1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MoveSelectedItems(ListBox list1, ListBox list2)
        {



            list2.BeginUpdate(); //Начало обновления списка List2
            foreach (object item in list1.SelectedItems)
            {
                //Добавление элемента из списка List1 в состав списка 	List2
                list2.Items.Add(item);
            }
            list2.EndUpdate(); //Окончание обновления списка List2
                               //Запоминание индексов выделенных элементов в списке List1
            ListBox.SelectedIndexCollection indeces = list1.SelectedIndices;
            list1.BeginUpdate();//Начало обновления списка List1
            for (int i = indeces.Count - 1; i >= 0; i--)
            {
                list1.Items.RemoveAt(indeces[i]); //Удаление из списка List1, выделенных 																	 //элементов 
            }
            list1.EndUpdate();//Окончание обновления списка List1
        }
        private void MoveAllItems(ListBox list1, ListBox list2)
        {
            // Все элементы списка list1 переносятся в конец списка list2
      // список list1 очищается 
            list2.Items.AddRange(list1.Items);
            list1.Items.Clear();
        }
    }
}
