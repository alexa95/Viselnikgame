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
    public partial class Form3 : Form
        {
        /// <summary>
        ///  Form start.
        /// </summary>
        public Form3()
            {
            InitializeComponent();
            }

        /// <summary>
        ///  Line in which we place the category name.
        /// </summary>
        public string d;

        /// <summary>
        /// Function of a choice of a category and transition to the form with a complexity choice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categories(object sender, EventArgs e)
            {
            d = ActiveControl.Text;
            if (d == "ANIMALS")
                {
                Game.words = Game.Animals;
                }

            if (d == "FOOD")
                {
                Game.words = Game.Food;
                }

            if (d == "TRANSPORT")
                {
                Game.words = Game.Transport;
                }

            Form9 frm9 = new Form9();
            frm9.categories = d;
            this.Hide();
            frm9.Show();
            }

        /// <summary>
        /// Transition to the previous form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
            {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
            }
        }
    }
