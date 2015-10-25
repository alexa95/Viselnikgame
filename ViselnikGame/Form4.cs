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
namespace ViselnikGame
    {
    public   partial class Form4 : Form
        {


 Game   g = new Game();

        public Form4()
            {

            // Получаем название категории от кнопки из Form3.
            CallBackMy.callbackEventHandler = new CallBackMy.callbackEvent(this.Reload);
            // Указываем сколько букв в слове.
            g.filling_conclusion();
            InitializeComponent();
            int count = 0;
            foreach (char el in g.conclusion)
                {
                this.Controls["label"+(count+1).ToString()].Text = g.conclusion[count].ToString();
                count++;
                }
           }
       
        void Reload(string param)
            {
            label12.Text = param;
            }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


       string z;

      


 char[] Conc = new char[10];
        private void button_clic(object sender, EventArgs e)
        { 
            // При нажатии на кнопку меняем её цвет.
       ActiveControl.BackColor = Color.Red;
            z= ActiveControl.Text;
           
            int count = 0;
           // Предаем букву в сласс Game.
             g.letter = Convert.ToChar(z);
           // Запускаем проверку буквы.
            g.start_game();
            Conc = g.conclusion;
            // Выводим букву ели была нажата правильная.
             foreach (char el in Conc)
                {
                this.Controls["label" + (count+1).ToString()].Text = Conc[count].ToString();
                count++;
                }
            // Выводим кнопку перехода на следуюшее слово.
            if (g.win> g.last_number) 
                {  
                button_color();
                button28.Visible = true;
                }
            //Выводим каринку висельницы если была нажта неверная буква.
            pictureBox1.Image = Image.FromFile(@"C:\Users\uzer33\Documents\GitHub\Viselnikgame\ViselnikGame\Resources\" + g.wrong_letters + ".jpg");
            // Если все слова были угаданы то выводим форму для победы.
            if (g.win == Game.words.Length) 
                {
                Form8 f8 = new Form8();
                this.Hide();
                f8.Show();
                g.win = 0;
                g.wrong_letters = 0;
                Game.right_words = 0;
                }
            // Если угадано больше половины слов то вывдим форму для победы.
            if (g.wrong_letters == 7 && g.win >= 3) 
                {
                Form8 f8 = new Form8();
                this.Hide();
                f8.Show();
                g.win = 0;
                g.wrong_letters = 0;
                Game.right_words = 0;
                }
            // Если угадано меньше половины слов то выводим форму для проигрыша.

            if (g.wrong_letters == 7 && g.win < 3)
                {
                Form6 f6 = new Form6();
                this.Hide();
                f6.Show();
                g.win = 0;
                g.wrong_letters = 0;
                Game.right_words = 0;
                }
        

        }

       
             
            
            
       
    
        public void button_color() 
            {
            //Изменение цвета кнопок на начальный.
            for (int d = 2; d < 28; d++)
                {
                this.Controls["button" + (d).ToString()].BackColor = Color.Silver;
                }
            }
    
  
       
        private void button28_Click(object sender, EventArgs e)
            {
            button28.Visible = false;
            g.filiing_word();
            g.filling_conclusion();
            int count = 0;
            // Указываем сколько букв в следующем слове
            foreach (char el in g.conclusion)
                {
                this.Controls["label" +(count+1).ToString()].Text = g.conclusion[count].ToString();
                count++;
                }
            for (int i = g.conclusion.Length + 1; i < 11; i++) 
                {
                this.Controls["label" + i.ToString()].Text = "";
                }
            //Возвращаем картинку в начальное положение
            pictureBox1.Image = Image.FromFile(@"C:\Users\uzer33\Documents\GitHub\Viselnikgame\ViselnikGame\Resources\0.jpg");
            
            }

        private void button1_Click(object sender, EventArgs e)
            {
            // Переход на форму назад.
            Form3 f3 = new Form3();
            this.Close();
            f3.Show();
            }


        
        }
    }
        
    
