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
        public static string firstPage, secondPage;
                
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
            string storyline;
            string firstChoice, secondChoice;

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
                                                        //
                if (strings.GetLength(0) < 5)
                {
                    storyline = strings[0];                    

                    SetCursor(cursorLeftChoice, cursorTopChoice + y);
                    Console.WriteLine(storyline);
                    y++;
                    SetCursor(cursorLeftChoice, cursorTopChoice + y);
                    Console.WriteLine("Press any key to return to the main menu.");
                    SetCursor(cursorLeftPrint, cursorTopPrint);
                    Console.ReadKey();
                    y = 1;
                    Console.Clear();
                    page = 1; //this should send them back to the main menu once it's built
                }
                else
                {
                    storyline = strings[0];
                    firstChoice = strings[1];
                    secondChoice = strings[2];
                    firstPage = strings[3];
                    secondPage = strings[4];

                    SetCursor(cursorLeftChoice, cursorTopChoice + y);
                    Console.WriteLine(storyline);
                    y++;
                    SetCursor(cursorLeftChoice, cursorTopChoice + y);
                    Console.Write("A: "); //if you change what key to press, also change it in PlayerChoice.cs
                    Console.WriteLine(firstChoice);
                    y++;
                    SetCursor(cursorLeftChoice, cursorTopChoice + y);
                    Console.Write("D: "); //if you change what key to press, also change it in PlayerChoice.cs
                    Console.WriteLine(secondChoice);
                
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
