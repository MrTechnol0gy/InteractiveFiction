using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveFiction
{
    internal class Program
    {
        public static bool gameOver;
        public static bool choiceA, choiceB;
        public static int page;
                
        static void Main(string[] args)
        {            
            int width = 96;
            int height = 32;
            int origx = Console.CursorLeft; 
            int origy = Console.CursorTop;
            int cursorTopMain = origy + 1; //cursor position for printing to the main game area
            int cursorLeftMain = origx + 1; 
            int cursorTopChoice = origx + 20; //cursor position for printing to the player choice area
            int cursorLeftChoice = origy + 1;
            int cursorTopPrint = origx + 34; //sets cursor position for printing player output outside of the main game area/player choice area
            int cursorLeftPrint = origy;
            gameOver = false;
            page = 0;
            string currPage = Story.story[page]; //gets the string at the 'page' index
            string[] strings = currPage.Split('%'); //prepares the split for the current page information
            //int stringLength = strings.Length; //gets the length of the split string            
            int y = 1;
            choiceA = false;
            choiceB = false;
            

            UI.PrintUI(width, height);
            SetCursor(cursorTopMain, cursorLeftMain);
            Title.MainTitle();                

            while (gameOver == false)
            {   
                //for (int i = 0; i < ArtMain.Art.GetLength(0); i++)
                //{
                //    SetCursor(cursorTopMain, cursorLeftMain);
                //    for (int j = 0; j < ArtMain.Art.GetLength(1); j++)
                //    {
                //        Console.Write(ArtMain.Art[i, j]);
                //    }
                //}
                SetCursor(cursorLeftChoice, cursorTopChoice);                                                   
                foreach (string s in strings)
                {   
                    Console.WriteLine(s);                        
                    SetCursor(cursorLeftChoice, cursorTopChoice + y);
                    y++;
                }                                
                SetCursor(cursorLeftPrint, cursorTopPrint);
                PlayerChoice.Choice();
                Pages.Page(page);
                choiceA = false;
                choiceB = false;
            }            
        }        
        
        static void SetCursor(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }
    }
}
