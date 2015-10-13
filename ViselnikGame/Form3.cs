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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
        }

        private void food(object sender, EventArgs e)
            {
            Form4 f4 = new Form4();
            this.Hide();

            f4.Show();
            }

        private void animals(object sender, EventArgs e) 
            {
            Form10 f10 = new Form10();
            this.Hide();
            f10.Show();
            }
        private void transport(object sender, EventArgs e) 
            {
            Form9 f9 = new Form9();
            this.Hide();
            f9.Show();
            }
       
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void form4()
            {

            }

        private void transport()
            {

            }

        private void animals()
            {

            }

       
    }
}
