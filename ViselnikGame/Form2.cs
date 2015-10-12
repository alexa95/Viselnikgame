using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViselnikGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Выход из программы.
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Переход на форму  выбора категории для игры. 
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //переход на форму со справкой.
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();

        }

        
    }
}
