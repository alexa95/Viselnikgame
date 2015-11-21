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
    using System.Threading;

    /// <summary>
    /// Copy of a class of the form.
    /// </summary>
    public partial class Form4 : Form
        {
        /// <summary>
        /// Copy of class Game.
        /// </summary>
        Game g = new Game();

        /// <summary>
        ///  Form start.
        /// </summary>
        public Form4()
            {
            //receive the name of a category from the button from Form3.
            CallBackMy.CallBackEventHandler = new CallBackMy.CallBackEvent(this.Reload);

            //receive value of complexity from Form9.
            CallBackMy2.CallBackEventHandler2 = new CallBackMy2.CallBackEvent2(this.Relod2);

            //specify how many letters in a word.
            g.Filling_conclusion();
            InitializeComponent();
            int count = 0;
            foreach (char el in g.conclusion)
                {
                this.Controls["label" + (count + 1).ToString()].Text = g.conclusion[count].ToString();
                count++;
                }
            }

        /// <summary>
        /// Variable containing complexity.
        /// </summary>
        int complexity;

        /// <summary>
        /// Conclusion of the name of a category.
        /// </summary>
        /// <param name="param"></param>
        void Reload(string param)
            {
            label12.Text = param;
            }

        /// <summary>
        /// Record of value of complexity.
        /// </summary>
        /// <param name="param2"></param>
        void Relod2(int param2)
            {
            complexity = param2;
            }

        /// <summary>
        /// create error counter.
        /// </summary>
        int ErrorCount = 0;

        /// <summary>
        /// Line receiving value of a letter.
        /// </summary>
        string z;

        /// <summary>
        /// Line showing what letters are guessed and how many all letters in a word.
        /// </summary>
        char[] Conc = new char[10];

        /// <summary>
        /// Function starting letter check on correctness.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_clic(object sender, EventArgs e)
            {
            // By pressing the button its colour is changed.
            ActiveControl.BackColor = Color.Red;

            //Receive value of a letter
            z = ActiveControl.Text;
            int count = 0;

            // We betray a letter in сласс Game.
            g.Letter = Convert.ToChar(z);

            // We start letter check.
            g.Start();
            Conc = g.conclusion;

            // We remove a fur-tree letter the correct has been pressed.
            foreach (char el in Conc)
                {
                this.Controls["label" + (count + 1).ToString()].Text = Conc[count].ToString();
                count++;
                }

            // We remove the transition button on следуюшее a word.
            if (g.WinCounter > g.LastNumberCounter)
                {
                button28.Visible = true;
                }

            //We remove a gallows picture if there was нажта an incorrect letter.
            pictureBox1.Image = Image.FromFile(@"Resources\" + g.WrongLettersCounter + ".jpg");

            // If all words have been guessed that we remove the form for a victory.
            if (g.WinCounter == Game.words.Length)
                {
                Form8 f8 = new Form8();
                this.Hide();
                f8.Show();
                g.WinCounter = 0;
                g.WrongLettersCounter = 0;
                Game.RightWordsCounter = 0;
                }

            if (g.WrongLettersCounter == 7)
                {
                count = 0;
                ErrorCount++;
                g.WrongLettersCounter = 0;
                if (Convert.ToInt32(complexity) == 1 && ErrorCount <= 4)
                    {
                    g.conclusion = Game.words[Game.RightWordsCounter].ToCharArray();
                    Conc = g.conclusion;

                    // We remove a fur-tree letter the correct has been pressed.
                    foreach (char el in Conc)
                        {
                        this.Controls["label" + (count + 1).ToString()].Text = Conc[count].ToString();
                        count++;
                        }

                    Game.RightWordsCounter++;
                    g.WinCounter++;
                    for (int i = 2; i < 28; i++)
                        {
                        this.Controls["button" + (i).ToString()].Enabled = false;
                        }

                    button28.Visible = true;
                    }

                if (Convert.ToInt32(complexity) == 2 && ErrorCount <= 2)
                    {
                    g.conclusion = Game.words[Game.RightWordsCounter].ToCharArray();
                    Conc = g.conclusion;

                    // We remove a fur-tree letter the correct has been pressed.
                    foreach (char el in Conc)
                        {
                        this.Controls["label" + (count + 1).ToString()].Text = Conc[count].ToString();
                        count++;
                        }

                    Game.RightWordsCounter++;
                    g.WinCounter++;
                    for (int i = 2; i < 28; i++)
                        {
                        this.Controls["button" + (i).ToString()].Enabled = false;
                        }

                    button28.Visible = true;
                    }

                if (Convert.ToInt32(complexity) == 2 && ErrorCount > 2 || Convert.ToInt32(complexity) == 1 && ErrorCount > 4 || Convert.ToInt32(complexity) == 3)
                    {
                    Form6 f6 = new Form6();
                    this.Hide();
                    f6.Show();
                    g.WinCounter = 0;
                    g.WrongLettersCounter = 0;
                    Game.RightWordsCounter = 0;
                    for (int i = 2; i < 28; i++)
                        {
                        this.Controls["button" + (i).ToString()].Enabled = false;
                        }
                    }
                }

            ActiveControl.Enabled = false;
            button1.Enabled = true;
            }

        /// <summary>
        /// Change of color of buttons on the initial.
        /// </summary>
        public void ButtonColor()
            {
            for (int d = 2; d < 28; d++)
                {
                this.Controls["button" + (d).ToString()].BackColor = Color.Transparent;
                this.Controls["button" + (d).ToString()].Enabled = true;
                }
            }

        /// <summary>
        /// Transition to a following word.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button28_Click(object sender, EventArgs e)
            {
            button28.Visible = false;
            g.Filiing_word();
            g.Filling_conclusion();
            int count = 0;

            // We specify how many letters in a following word.
            foreach (char el in g.conclusion)
                {
                this.Controls["label" + (count + 1).ToString()].Text = g.conclusion[count].ToString();
                count++;
                }

            for (int i = g.conclusion.Length + 1; i < 11; i++)
                {
                this.Controls["label" + i.ToString()].Text = "";
                }

            //We return a picture in initial position.
            pictureBox1.Image = Image.FromFile(@"Resources\0.jpg");
            ButtonColor();
            }

        /// <summary>
        /// Return on the form with a category choice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
            {
            Game.RightWordsCounter = 0;
            g.LastNumberCounter = 0;
            g.WrongLettersCounter = 0;
            Game.CorrectLettersCounter = 0;

            // Transition to the form back.
            Form3 f3 = new Form3();
            this.Close();
            f3.Show();
            }
        }
    }


