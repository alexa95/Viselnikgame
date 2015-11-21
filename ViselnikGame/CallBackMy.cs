namespace ViselnikGame
    {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This class returns a line with the name of a category from the form with a choice of categories.
    /// </summary>
    public static class CallBackMy
        {
        /// <summary>
        ///  Returns a line with the name of a category from the form with a choice of categories.
        /// </summary>
        /// <param name="what"></param>
        public delegate void CallBackEvent(string what);

        /// <summary>
        /// Contains returned value
        /// </summary>
        public static CallBackEvent CallBackEventHandler;
        }

    /// <summary>
    /// This class returns value of complexity from the form with a complexity choice.
    /// </summary>
    public static class CallBackMy2
        {
        /// <summary>
        /// Returns value of complexity.
        /// </summary>
        /// <param name="what"></param>
        public delegate void CallBackEvent2(int what);

        /// <summary>
        ///  Contains returned value
        /// </summary>
        public static CallBackEvent2 CallBackEventHandler2;
        }
    }
