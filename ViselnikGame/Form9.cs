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
    public partial class Form9 : Form
        {
        public Form9()
            {
            InitializeComponent();
            }


        public int complexity = 0;
        public string categories;

        
        Form4 frm4= new Form4();
        private void button1_Click(object sender, EventArgs e)
            {
            complexity = 1;
            this.Hide();
            frm4.Show();
            CallBackMy2.callbackEventHandler2(complexity);
            CallBackMy.callbackEventHandler(categories);
            }

        private void button2_Click(object sender, EventArgs e)
            {
            complexity = 2;
            CallBackMy2.callbackEventHandler2(complexity);
            CallBackMy.callbackEventHandler(categories);
            this.Hide();
            frm4.Show();
         
            }

        private void button3_Click(object sender, EventArgs e)
            {
            complexity = 3;
            CallBackMy2.callbackEventHandler2(complexity);
            CallBackMy.callbackEventHandler(categories);
            this.Hide();
            frm4.Show();

            }

        }
    }
