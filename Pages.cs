using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveFiction
{
    internal class Pages
    {
        public static void Page(int x)
        {
            switch (x)
            {
                case 0:
                    if (Program.choiceA == true)
                    {
                        Program.page = 1;
                        return;
                    }
                    else if (Program.choiceB == true)
                    {
                        Program.page = 2;
                        return;
                    }
                    break;
                case 1:
                    if (Program.choiceA == true)
                    {

                    }
                    else if (Program.choiceB == true)
                    {

                    }
                    break;
                case 2:
                    if (Program.choiceA == true)
                    {
                        Program.page = 3;
                        return;
                    }
                    else if (Program.choiceB == true)
                    {
                        Program.page = 1;
                        return;
                    }
                    break;
                case 3:
                    if (Program.choiceA == true)
                    {
                        Program.page = 0;
                        return;
                    }
                    else if (Program.choiceB == true)
                    {
                        Program.gameOver = true;
                        return;
                    }
                    break;
                case 4:
                    if (Program.choiceA == true)
                    {

                    }
                    else if (Program.choiceB == true)
                    {

                    }
                    break;
                case 5:
                    if (Program.choiceA == true)
                    {

                    }
                    else if (Program.choiceB == true)
                    {

                    }
                    break;
                case 6:
                    if (Program.choiceA == true)
                    {

                    }
                    else if (Program.choiceB == true)
                    {

                    }
                    break;
                case 7:
                    if (Program.choiceA == true)
                    {

                    }
                    else if (Program.choiceB == true)
                    {

                    }
                    break;
                case 8:
                    if (Program.choiceA == true)
                    {

                    }
                    else if (Program.choiceB == true)
                    {

                    }
                    break;
                default:
                    break;
            }
        }
    }
}
