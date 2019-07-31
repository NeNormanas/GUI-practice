using GameWithClass.Game;
using GameWithClass.GUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClass.GUI_Controller
{
    class Main_GUI_Controller
    {
        // KINTAMIEJI IR PROPERTIES

        private readonly  GameController _myGame;
        private readonly Render_GUI_Controller _Render_Controller;
        private  User_GUI_Controller _Gui_User_Controller;
        private readonly Buttons_GUI_Controller _Gui_Buttons_Controller;
        private readonly List<Button> _ButtonsInGameWindow;


        public CreditWindow CreditWindow { get; private set; }
        public GameWindow GameWindow { get; private set; }


        // KONSTRUKTORIUS

        public Main_GUI_Controller()
        {
            CreditWindow = new CreditWindow();
            GameWindow = new GameWindow();
            _myGame = new GameController();


            _Render_Controller = new Render_GUI_Controller(CreditWindow, GameWindow);
            _Gui_Buttons_Controller = new Buttons_GUI_Controller(CreditWindow, GameWindow);

            _ButtonsInGameWindow = _Gui_Buttons_Controller.ButtonsInGameWindows;

            _Gui_User_Controller = new User_GUI_Controller(_ButtonsInGameWindow, _myGame, _Render_Controller, GameWindow, _Gui_Buttons_Controller);
        }

        // FUNKCIJOS IR METODAI

        public void StartGuiController()
        {
            GameWindow.Render();
            _Gui_User_Controller.UserButtonsActivitiesInWindow(_ButtonsInGameWindow);

        }

    }

}
