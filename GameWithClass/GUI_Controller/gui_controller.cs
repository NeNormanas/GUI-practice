using GameWithClass.Game;
using GameWithClass.GUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClass.GUI_Controller
{
    class GUi_controller
    {
        // KINTAMIEJI IR PROPERTIES

        private GameController _myGame;
        private gui_render_controller _Render_Controller;
        private gui_users_activity _Gui_User_Controller;
        private gui_buttons_controller _Gui_Buttons_Controller;
        private List<Button> _ButtonsInGameWindow;


        public CreditWindow _CreditWindow { get; private set; }
        public GameWindow _GameWindow { get; private set; }

      


        // KONSTRUKTORIUS

        public GUi_controller()
        {
            _CreditWindow = new CreditWindow();
            _GameWindow = new GameWindow();
            _myGame = new GameController();


            _Render_Controller = new gui_render_controller(_CreditWindow, _GameWindow);
            _Gui_Buttons_Controller = new gui_buttons_controller(_CreditWindow, _GameWindow);

            _ButtonsInGameWindow = _Gui_Buttons_Controller.ButtonsInGameWindows;

            _Gui_User_Controller = new gui_users_activity(_ButtonsInGameWindow, _myGame, _Render_Controller, _GameWindow, _Gui_Buttons_Controller);
        }

        // FUNKCIJOS IR METODAI

        public void StartGuiController()
        {
            _GameWindow.Render();
            _Gui_User_Controller.UserButtonsActivitiesInWindow(_ButtonsInGameWindow);

        }

    }

}
