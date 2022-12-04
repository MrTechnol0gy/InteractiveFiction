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
                x = Convert.ToInt32(Story.story[4]);
                Program.page = x;
                return;
            }
            else if (Program.choiceB == true)
            {
                x = Convert.ToInt32(Story.story[5]);
                Program.page = x;
                return;
            } 
        }
    }
}
