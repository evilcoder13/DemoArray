using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedMath1
{
    public class Class1
    {
        internal static int Add(int a, int b)
        {
            //return a + b;
            return Add(a, b, 0);
        }
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
