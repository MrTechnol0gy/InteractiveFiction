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
        public static bool titleScreen = false;
                
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
            int cursorTopPrint = origx + 34; //sets cursor position for printing player input outside of the main game area/player choice area
            int cursorLeftPrint = origy;
            gameOver = false;
            page = 0;  
            int y = 1;
            choiceA = false;
            choiceB = false;

            while (gameOver == false)
            {   
                UI.PrintUI(width, height);
                SetCursor(cursorTopMain, cursorLeftMain);                          
                if (titleScreen == false) //checks to see if the title page has been displayed and, if not, displays it.
                {
                    titleScreen = true;
                    string titlePage = Story.story[page];
                    string[] titleStrings = titlePage.Split('%');
                    foreach (string s in titleStrings)
                    {
                        Console.WriteLine(s);
                        SetCursor(cursorLeftMain, cursorTopMain + y);
                        y++;
                    }
                    page++;
                    y = 1;
                }
                string currPage = Story.story[page]; //gets the string at the 'page' index
                string[] strings = currPage.Split('%'); //prepares the split for the current page information                                                                   
                foreach (string s in strings)
                {   
                    SetCursor(cursorLeftChoice, cursorTopChoice + y);
                    Console.WriteLine(s);                        
                    y++;
                }
                if (strings.GetLength(0) < 5) //checks if the current page is an 'end page' (denoted as a page with less than five elements)
                {
                    //code go here
                }
                else
                {
                    SetCursor(cursorLeftPrint, cursorTopPrint);
                    PlayerChoice.Choice(); //takes the player choice and flips the appropriate bool
                    Pages.Page(); //changes the page index based on player input
                    choiceA = false;
                    choiceB = false;
                    y = 1;
                    Console.Clear();
                }
            }            
        }        
        
        static void SetCursor(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }
    }
}
