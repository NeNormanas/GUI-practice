using GameWithClass.GUI;
using GameWithClass.GUI_Controller;
using System;

namespace GameWithClass.Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.CursorVisible = false;

            GUi_controller guiController = new GUi_controller();
            guiController.StartGuiController();

            Console.WriteLine("PROGRAM IS TURNED OFF");


        }
    }
}
