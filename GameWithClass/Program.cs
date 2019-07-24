using GameWithClass.GUI;
using System;

namespace GameWithClass.Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.CursorVisible = false;

            GameWindow gameWindow = new GameWindow();

            CreditWindow creditWindow = new CreditWindow();

            GuiController guiController = new GuiController(gameWindow, creditWindow);

            guiController.ShowMenu();
            guiController.UserActivity();


            Console.WriteLine("PROGRAMA BAIGTA");


        }
    }
}
