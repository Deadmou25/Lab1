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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            ListForm lf = new ListForm();
            lf.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TwoLists_Click(object sender, EventArgs e)
        {
            TwoLists tl = new TwoLists();
            tl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Вы хотите уйти из жизни?",
        "Сообщение");
        
        
        }

        private void DialogWindow_Click(object sender, EventArgs e)
        {
            DialogForm df = new DialogForm();
            df.ShowDialog();
        }
    }
}
