using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ViselnikGame
    {
    
    public class Game
        {
        // Создаем массивы слов.
        public static string[] food = { "SOUP", "APPLE", "PORIGE", "BANAN", "CHICKEN" };
        public static string[] transport = { "TRAM", "BUS", "MOTOBIKE", "CAR", "BIKE" };
        public static string[] animals = { "DOG", "CAT", "RABBIT", "GIRAFE", "MOUSE" };
        // Создаем букву.
        public char letter;
        //Создаем счетчики.
        public static int right_words = 0, correct_letters = 0;
        public int wrong_letters = 0, win = 0, last_number = 0;
        // Создаем масив в который будет записываться массив выбраной категории.
        public static string[] words;
        // Создаем массив символов в который будет записываться слово.
        static char[] word; 
        // Создаем массив который будем выводить после проверки буквы.
        public char[] conclusion = "--".ToCharArray();
        // Функция записывающая слово в массив символов.
        public void Filiing_word() 
            {
            word = words[right_words].ToCharArray();
            }
      // Функция присваиваюшая длине выводимого массива длину слова и  заполняющего выводимый массив знаком "-".
        int count = 0;
        public void Filling_conclusion()
            {
            Filiing_word();
            conclusion = new char[word.Length];
            foreach (char el in conclusion)
                {
                conclusion[count] = '-';
                count++;
                }
            count = 0;
            }
       
        // Функция описывающая игровой процесс.
             void Logic()
            {
              // Прошлое количество угаданных слов приравнивает к текущему количеству угаданных слов. 
            last_number = win;
                 // Проводит проверку, есть ли заданная буква в слове.
            int q=0;
            int count_word = 0;
            foreach (char elem in word) 
                {
                // Если буква есть то в строку вывода добавляем в нужном месте эту букву, и счетчик правильных букв увеличиваем на количество повторений буквы в слове. 
                if (word[count_word] == letter)
                    {
                    conclusion[count_word] = letter;
                    correct_letters++;
                    }
                else
                    {
                    
                    q++;
                    }
                count_word++;
                }
                 // Если буква не была обнаружена в слове увеличиваем счетчик неверных букв на единицу.
            if (q == word.Length) 
                {
                wrong_letters++;
                }
                 // Если счетчик правильных букв равен длине слова то увеличиваем счетчики правильных слов на единицу переходим на след слово и обнуляем счетчки правильных и неправильных букв.
            if (correct_letters == word.Length) 
                {
                win++;
                right_words++;
                wrong_letters = 0;
                correct_letters = 0;
                }
            
            } 
        // Публичная функция  программы используется в формах.
        public void Start()
            {
            Filiing_word();
            Logic();

            }
        }
    }
