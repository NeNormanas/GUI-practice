﻿using GameWithClass.GUI;
using GameWithClass.GUI_Controller;
using System;

namespace GameWithClass.Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.CursorVisible = false;

            Main_GUI_Controller guiController = new Main_GUI_Controller();
            guiController.StartGuiController();

            Console.WriteLine("PROGRAM IS TURNED OFF");


        }
    }
}
