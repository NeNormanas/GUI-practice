using GameWithClass.GUI;
using GameWithClass.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClass.GUI_Controller
{
     class gui_render_controller
    {

       private CreditWindow _creditWindow;
       private GameWindow _gameWindow;

        public gui_render_controller(CreditWindow creditWindow, GameWindow gameWindow)
        {
            _creditWindow = creditWindow;
            _gameWindow = gameWindow;
        }

        public void ShowCreditWindow()
        {
            _creditWindow.Render();
        }

        public void ShowGameWindow()
        {
            _gameWindow.Render();
        }

    }
}
