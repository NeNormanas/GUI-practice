using GameWithClass.GUI;
using GameWithClass.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClass.GUI_Controller
{
     class Render_GUI_Controller
    {

       private CreditWindow _creditWindow;
       private GameWindow _gameWindow;

        public Render_GUI_Controller(CreditWindow creditWindow, GameWindow gameWindow)
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
