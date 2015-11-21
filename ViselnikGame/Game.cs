using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViselnikGame
    {
    /// <summary>
    /// This class contains logic of game.
    /// </summary>
    public class Game
        {
        /// <summary>
        /// Create files of words.
        /// </summary>
        public static string[] Food = { "SOUP", "APPLE", "PORIGE", "BANAN", "CHICKEN" };

        /// <summary>
        /// Create files of words.
        /// </summary>
        public static string[] Transport = { "TRAM", "BUS", "MOTOBIKE", "CAR", "BIKE" };

        /// <summary>
        /// Create files of words.
        /// </summary>
        public static string[] Animals = { "DOG", "CAT", "RABBIT", "GIRAFE", "MOUSE" };
        
        /// <summary>
        /// Create a letter.
        /// </summary>
        public char Letter;
        
        /// <summary>
        /// create counters.
        /// </summary>
        public static int RightWordsCounter = 0;
        public static int CorrectLettersCounter = 0;
        public int WrongLettersCounter = 0;
        public int WinCounter = 0;
        public int LastNumberCounter = 0;
        // Создаем масив в который будет записываться массив выбраной категории.
        public static string[] words={""};
        // Создаем массив символов в который будет записываться слово.
        static char[] word; 
        // Создаем массив который будем выводить после проверки буквы.
        public char[] conclusion = "--".ToCharArray();
        // Функция записывающая слово в массив символов.


        /// <summary>
        /// Функция присваиваюшая длине выводимого массива длину слова и  заполняющего выводимый массив знаком "-".
        /// </summary>
        public void Filiing_word() 
            {
            word = words[RightWordsCounter].ToCharArray();
            }
      
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
            LastNumberCounter = WinCounter;
                 // Проводит проверку, есть ли заданная буква в слове.
            int q=0;
            int count_word = 0;
            foreach (char elem in word) 
                {
                // Если буква есть то в строку вывода добавляем в нужном месте эту букву, и счетчик правильных букв увеличиваем на количество повторений буквы в слове. 
                if (word[count_word] == Letter)
                    {
                    conclusion[count_word] = Letter;
                    CorrectLettersCounter++;
                    }
                else
                    {
                    q = q + 1; ;
                    }
                count_word++;
                }
                 // Если буква не была обнаружена в слове увеличиваем счетчик неверных букв на единицу.
            if (q == word.Length) 
                {
                WrongLettersCounter = WrongLettersCounter + 1; ;
                }
                 // Если счетчик правильных букв равен длине слова то увеличиваем счетчики правильных слов на единицу переходим на след слово и обнуляем счетчки правильных и неправильных букв.
            if (CorrectLettersCounter == word.Length) 
                {
                WinCounter++;
                RightWordsCounter++;
                WrongLettersCounter = 0;
                CorrectLettersCounter = 0;

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
