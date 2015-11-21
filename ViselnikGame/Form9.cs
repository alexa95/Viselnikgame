namespace ViselnikGame
    {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    ///  Copy of a class of the form.
    /// </summary>
    public partial class Form9 : Form
        {
        /// <summary>
        /// Form start.
        /// </summary>
        public Form9()
            {
            InitializeComponent();
            }

        /// <summary>
        /// Variable containing value of complexity.
        /// </summary>
        public int complexity = 0;

        /// <summary>
        /// Line containing the category name.
        /// </summary>
        public string categories;

        /// <summary>
        /// Copy of class Form4.
        /// </summary>
        Form4 frm4 = new Form4();

        /// <summary>
        /// Transition to the form with game, with easy complexity.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
            {
            complexity = 1;
            CallBackMy2.CallBackEventHandler2(complexity);
            CallBackMy.CallBackEventHandler(categories);
            this.Hide();
            frm4.Show();
            }

        /// <summary>
        /// Transition to the form with game, with average complexity.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
            {
            complexity = 2;
            CallBackMy2.CallBackEventHandler2(complexity);
            CallBackMy.CallBackEventHandler(categories);
            this.Hide();
            frm4.Show();
            }

        /// <summary>
        /// Transition to the form with game, with heavy complexity.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
            {
            complexity = 3;
            CallBackMy2.CallBackEventHandler2(complexity);
            CallBackMy.CallBackEventHandler(categories);
            this.Hide();
            frm4.Show();
            }
        }
    }
