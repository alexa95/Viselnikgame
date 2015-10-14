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
    public partial class Form9 : Form
        {
        public Form9()
            {
            InitializeComponent();
            }

        

        string[] transport = { "TRAM", "BUS", "MOTOBIKE", "CAR", "BIKE" };
        int i = 0, n = 0, k = 0;
        private void button_clic(object sender, EventArgs e)
        {
            // При нажатии на кнопку меняем её цвет.
       ActiveControl.BackColor = Color.Red;
        game();
        
        }

        void button_color() 
            {
            //Изменение цвета кнопок на начальный.
            for (int d = 2; d < 28; d++)
                {
                this.Controls["button" + (d).ToString()].BackColor = Color.Silver;
                }
            }
    
    char[] word;
        void game()
            {

            // Выбор слова. 
            for (; i < transport.Length; )
                {
               
                //  Запись  слова в виде массива символов.
                word = transport[i].ToCharArray();
                int q = 0;
                // Проверка правильности выбранной буквы.
                for (int j = 0; j < word.Length; j++)
                    {
                
                    //Считывание буквы с нажатой кнопки и сравнение е с буквами слова.
                    if (ActiveControl.Text.Equals( word[j].ToString()))
                        {
                        // Если бува в слове есть выодим ее в нужном месте.
                        this.Controls["label" + (j + 1).ToString()].Text = word[j].ToString();
                        n++;   
                      
                        }
                    else 
                        {
                       q++ ;
                         
                        }

                    }
                // Изменяем картику виселицы если буква не была угадана и увеличиваем счетчик неугаданных букв на 1.
                if (q== word.Length) 
                    {
                    k++;
                    pictureBox1.Image = Image.FromFile(@"C:\Users\uzer33\Documents\GitHub\Viselnikgame\ViselnikGame\Resources\" + k + ".jpg");
                    }
                // Если количество неугаданных букв равно количеству букв в слове выводим форму для проигрыша.
                if (k == 7)
                    {
                    Thread.Sleep(100);
                    Form6 f6 = new Form6();
                    this.Hide();
                    f6.Show();
                    }
                if (n == word.Length)
                {
                    button28.Visible=true;
                    
                }
           
                    break;
                    
              
                }
            }

        void transition()
            {
            // Если количество угаданных букв равно количеству букв в слове переходим к следующему слову.
           
               
                i++;

                // если слова закончились выводим форму для победы.
                if (i == transport.Length)
                    {
                    Form8 f8 = new Form8();
                    this.Hide();
                    f8.Show();
                    }

                // Возвращаем картинку виселицы в начальное состояние.

                pictureBox1.Image = Image.FromFile(@"C:\Users\uzer33\Documents\GitHub\Viselnikgame\ViselnikGame\Resources\0.bmp");
                k = 0;
                for (int y = 1; y <= transport[i].Length; y++)
                    {
                    // Выводим пустые строки равные количеству букв в следующем слове.
                    this.Controls["label" + (y).ToString()].Text = "_";
                    }
                for (int y = transport[i].Length + 1; y <= 10; y++)
                    {
                    this.Controls["label" + (y).ToString()].Text = " ";
                    }

                button_color();
                n = 0;
                
            }
        private void button1_Click(object sender, EventArgs e)
            {
            // Переход на форму назад.
            Form3 f3 = new Form3();
            this.Close();
            f3.Show();
            }

        private void button28_Click(object sender, EventArgs e)
            {
            transition();
            button28.Visible = false;
          
            }
        }
    }
        
    
