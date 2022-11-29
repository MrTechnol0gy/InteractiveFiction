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
                case 1:
                    if (Program.choiceA == true)
                    {
                        Program.page = 2;
                        return;
                    }
                    else if (Program.choiceB == true)
                    {
                        Program.page = 3;
                        return;
                    }
                    break;
                case 2:
                    if (Program.choiceA == true)
                    {
                        Program.page = 5;
                        return;
                    }
                    else if (Program.choiceB == true)
                    {
                        Program.page = 6;
                        return;
                    }
                    break;
                case 3:
                    if (Program.choiceA == true)
                    {
                        Program.page = 4;
                        return;
                    }
                    else if (Program.choiceB == true)
                    {
                        Program.page = 2;
                        return;
                    }
                    break;
                case 4:
                    if (Program.choiceA == true)
                    {
                        Program.titleScreen = false;
                        Program.page = 0;
                        return;
                    }
                    else if (Program.choiceB == true)
                    {
                        Program.gameOver = true;
                        return;
                    }
                    break;
                case 5:
                    if (Program.choiceA == true)
                    {
                        Program.page = 4;
                        return;
                    }
                    else if (Program.choiceB == true)
                    {
                        Program.page = 8;
                        return;
                    }
                    break;
                case 6:
                    if (Program.choiceA == true)
                    {
                        Program.page = 4;
                        return;
                    }
                    else if (Program.choiceB == true)
                    {
                        Program.page = 7;
                        return;
                    }
                    break;
                case 7:
                    if (Program.choiceA == true)
                    {
                        Program.page = 9;
                        return;
                    }
                    else if (Program.choiceB == true)
                    {
                        Program.page = 10;
                        return;
                    }
                    break;
                case 8:
                    if (Program.choiceA == true)
                    {
                        Program.page = 11;
                        return;
                    }
                    else if (Program.choiceB == true)
                    {
                        Program.page = 12;
                        return;
                    }
                    break;
                case 9:
                    if (Program.choiceA == true)
                    {
                        Program.page = 11;
                        return;
                    }
                    else if (Program.choiceB == true)
                    {
                        Program.page = 13;
                        return;
                    }
                    break;
                case 10:
                    if (Program.choiceA == true)
                    {
                        Program.page = 13;
                        return;
                    }
                    else if (Program.choiceB == true)
                    {
                        Program.page = 11;
                        return;
                    }
                    break;
                case 11:
                    if (Program.choiceA == true)
                    {
                        Program.titleScreen = false;
                        Program.page = 0;
                        return;
                    }
                    else if (Program.choiceB == true)
                    {
                        Program.gameOver = true;
                        return;
                    }
                    break;
                case 12:
                    if (Program.choiceA == true)
                    {
                        Program.titleScreen = false;
                        Program.page = 0;
                        return;
                    }
                    else if (Program.choiceB == true)
                    {
                        Program.gameOver = true;
                        return;
                    }
                    break;
                case 13:
                    if (Program.choiceA == true)
                    {
                        Program.page = 14;
                        return;
                    }
                    else if (Program.choiceB == true)
                    {
                        Program.page = 14;
                        return;
                    }
                    break;
                case 14:
                    if (Program.choiceA == true)
                    {
                        Program.titleScreen = false;
                        Program.page = 0;
                        return;
                    }
                    else if (Program.choiceB == true)
                    {
                        Program.gameOver = true;
                        return;
                    }
                    break;
                default:                    
                    break;
            }
        }
    }
}
