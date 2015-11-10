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
      public  string d;



      private void categories(object sender, EventArgs e)
            {
            d = ActiveControl.Text; 
          
            if (d == "ANIMALS") 
                {
                Game.words = Game.animals;
                }
            if (d == "FOOD") 
                {
                Game.words = Game.food;
                }
            if (d == "TRANSPORT") 
                {
                Game.words = Game.transport;
                }
          
           
         
          
          Form9 frm9 = new Form9();
          frm9.categories = d;
            this.Hide();
            frm9.Show();

            }
       
       
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

      public string button_text
      { 
      get{return  d;}  
      }
        

       
    }
}
