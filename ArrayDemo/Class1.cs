using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedMath1
{
    public class Class1
    {
        /// <summary>
        /// Cong 2 so
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        internal static int Add(int a, int b)
        {
            //return a + b;
            return Add(a, b, 0);
        }
        /// <summary>
        /// Cong 3 so
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        internal static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        void ViewData(int page, string orderby)
        {
            //return SearchData(page, orderby, "");
        }

        void SearchData(int page, string orderby, string keyword)
        {
            //...
        }

    }
}
