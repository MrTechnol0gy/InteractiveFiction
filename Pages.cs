using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveFiction
{
    internal class Pages
    {
        public static void Page()
        {
            int x;
            
            if (Program.choiceA == true)
            {
                x = Int32.Parse(Program.firstPage);
                Program.page = x;
                return;
            }
            else if (Program.choiceB == true)
            {
                x = Int32.Parse(Program.secondPage);
                Program.page = x;
                return;
            } 
        }
    }
}
