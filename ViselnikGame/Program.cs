using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViselnikGame
{
    
    public static class CallBackMy
            {
            public delegate void callbackEvent(string what);
            public static callbackEvent callbackEventHandler;
            }


    public static class CallBackMy2
        {
        public delegate void callbackEvent2(int what);
        public static callbackEvent2 callbackEventHandler2;
        }
    

    static class Program
    { 
       
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread] 
       
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
           
                   }

       
               }
        }
    