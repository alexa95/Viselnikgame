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
    public partial class Form4 : Form
        {



        public Form4()
            {
            InitializeComponent();


            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
            {
            //
            Form3 f3 = new Form3();
            this.Close();
            f3.Show();
            }
        int s;
        public void button2_Click(object sender, EventArgs e)
            {
            button2.BackColor = Color.Red;

            s = 2;
            game();
            }

       

        private void button21_Click(object sender, EventArgs e)
            {
            button21.BackColor = Color.Red;

            s = 21;
            game();
            }

        private void button20_Click(object sender, EventArgs e)
            {
            button20.BackColor = Color.Red;

            s = 20;
            game();
            }

        private void button15_Click(object sender, EventArgs e)
            {
            button15.BackColor = Color.Red;

            s = 15;
            game();
            }

        private void button19_Click(object sender, EventArgs e)
            {
            button19.BackColor = Color.Red;

            s = 19;
            game();
            }

        private void button18_Click(object sender, EventArgs e)
            {
            button18.BackColor = Color.Red;

            s = 18;
            game();
            }

        private void button17_Click(object sender, EventArgs e)
            {
            button17.BackColor = Color.Red;

            s = 17;
            game();
            }

        private void button16_Click(object sender, EventArgs e)
            {
            button16.BackColor = Color.Red;

            s = 16;
            game();
            }

        private void button14_Click(object sender, EventArgs e)
            {
            button14.BackColor = Color.Red;

            s = 14;
            game();
            }

        private void button13_Click(object sender, EventArgs e)
            {
            button13.BackColor = Color.Red;

            s = 13;
            game();
            }

        private void button12_Click(object sender, EventArgs e)
            {
            button12.BackColor = Color.Red;

            s = 12;
            game();
            }

        private void button11_Click(object sender, EventArgs e)
            {
            button11.BackColor = Color.Red;

            s = 11;
            game();
            }

        private void button10_Click(object sender, EventArgs e)
            {
            button10.BackColor = Color.Red;

            s = 10;
            game();
            }

        private void button9_Click(object sender, EventArgs e)
            {
            button9.BackColor = Color.Red;

            s = 9;
            game();
            }

        private void button8_Click(object sender, EventArgs e)
            {
            button8.BackColor = Color.Red;

            s = 8;
            game();
            }

        private void button7_Click(object sender, EventArgs e)
            {
            button7.BackColor = Color.Red;

            s = 7;
            game();
            }

        private void button6_Click(object sender, EventArgs e)
            {
            button6.BackColor = Color.Red;

            s = 6;
            game();
            }

        private void button5_Click(object sender, EventArgs e)
            {
            button5.BackColor = Color.Red;

            s = 5;
            game();
            }

        private void button4_Click(object sender, EventArgs e)
            {
            button4.BackColor = Color.Red;

            s = 4;
            game();
            }

        private void button3_Click(object sender, EventArgs e)
            {
            button3.BackColor = Color.Red;

            s = 3;
            game();
            }

        private void button23_Click(object sender, EventArgs e)
            {
            button23.BackColor = Color.Red;

            s = 23;
            game();
            }

        private void button25_Click(object sender, EventArgs e)
            {
            button25.BackColor = Color.Red;

            s = 25;
            game();
            }

        private void button24_Click(object sender, EventArgs e)
            {
            button24.BackColor = Color.Red;

            s = 24;
            game();
            }

        private void button26_Click(object sender, EventArgs e)
            {
            button26.BackColor = Color.Red;

            s = 26;
            game();
            }

        private void button27_Click(object sender, EventArgs e)
            {
            button27.BackColor = Color.Red;

            s = 27;
            game();
            }

        private void button22_Click(object sender, EventArgs e)
            {
            button22.BackColor = Color.Red;
            s = 22;
           
            game();
            } 
        string[] food = { "SOUS", "PIPE", "SOUP", "POTATO" };
        int i = 0, n=0;
        void game()
            {
           
            for (; i < food.Length; )
                {

                char[] word = food[i].ToCharArray();
              
                for (int j = 0; j < word.Length; j++)
                    {
                    if (this.Controls["button" +  s.ToString()].Text.Equals (word[j].ToString()))
                        {
                        this.Controls["label" + (j + 1).ToString()].Text = word[j].ToString();
                        n++;
                        }
                    
                    }

                if (n == word.Length)
                    {
                    i++;
                    for (int y = 1; y < 11; y++)
                        {
                        this.Controls["label" + (y).ToString()].Text = "_";
                        }
                    for (int d = 2; d < 28; d++) 
                        {
                        this.Controls["button" + (d).ToString()].BackColor = Color.Silver;
                        }
                    n = 0;
                    break;
                    }
                else {
                break;
                    }







                }
            }

        

      





       
        }
    }
        
    
