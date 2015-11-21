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
    /// Copy of a class of the form.
    /// </summary>
    public partial class Form2 : Form
        {
        /// <summary>
        /// Form start.
        /// </summary>
        public Form2()
            {
            InitializeComponent();
            }

        /// <summary>
        ///  Exit from the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
            {
            Close();
            }

        /// <summary>
        ///  Transition to the form of a choice of a category for game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
            {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
            }

        /// <summary>
        /// Transition to the form with the inquiry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
            {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
            }
        }
    }
