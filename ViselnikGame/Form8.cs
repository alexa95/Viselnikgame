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
    public partial class Form8 : Form
        {
        /// <summary>
        /// Form start.
        /// </summary>
        public Form8()
            {
            InitializeComponent();
            }

        /// <summary>
        /// Transition to the form of a choice of categories.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
            {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
            }
        }
    }
