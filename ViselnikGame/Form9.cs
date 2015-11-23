//<copyright file="Form9.cs" company="OmGTU"> 
//Copyright (c) OmGTU. All rights reserved.
//</copyright> 
//<author>
//Kalita Aleksandr, Valyn Ivan, Loshchinina Tatyana
//</author> 
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
        public int Complexity = 0;

        /// <summary>
        /// Line containing the category name.
        /// </summary>
        public string Categories;

        /// <summary>
        /// Copy of class Form4.
        /// </summary>
        Form4 frm4 = new Form4();

        /// <summary>
        /// Transition to the form with game, with easy complexity.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1Click(object sender, EventArgs e)
            {
            Complexity = 1;
            CallBack.CallBackEventHandler2(Complexity);
            CallBack.CallBackEventHandler(Categories);
            this.Hide();
            frm4.Show();
            }

        /// <summary>
        /// Transition to the form with game, with average complexity.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2Click(object sender, EventArgs e)
            {
            Complexity = 2;
            CallBack.CallBackEventHandler2(Complexity);
            CallBack.CallBackEventHandler(Categories);
            this.Hide();
            frm4.Show();
            }

        /// <summary>
        /// Transition to the form with game, with heavy complexity.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3Click(object sender, EventArgs e)
            {
            Complexity = 3;
            CallBack.CallBackEventHandler2(Complexity);
            CallBack.CallBackEventHandler(Categories);
            this.Hide();
            frm4.Show();
            }
        }
    }
