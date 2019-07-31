using GameWithClass.Game;
using GameWithClass.GUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClass.GUI_Controller
{
    class User_GUI_Controller
    {
        private readonly List<Button> _ButtonsInGameWindows;
        private readonly GameController _myGame;
        private readonly Render_GUI_Controller _Render_Controller;
        private readonly GameWindow _gameWindow;
        private readonly Buttons_GUI_Controller _GuiButtonsController;

        private bool _closeProgram = false;
        private bool _creditWindowIsOpen = false;

        public User_GUI_Controller(List<Button> ButtonsInGameWindows, GameController myGame, Render_GUI_Controller Render_Controller, GameWindow gameWindow, Buttons_GUI_Controller GuiButtonsController)

        {
            _ButtonsInGameWindows = ButtonsInGameWindows;
            _myGame = myGame;
            _Render_Controller = Render_Controller;
            _gameWindow = gameWindow;
            _GuiButtonsController = GuiButtonsController;
        }

        public void UserPressEnter(Button button)
        {
            switch (button.Label)
            {
                case "Start": Console.Clear(); _myGame.StartGame(); Console.Clear(); _Render_Controller.ShowGameWindow(); break;
                case "Credits": _Render_Controller.ShowCreditWindow(); _creditWindowIsOpen = true; break;
                case "Quit": Console.Clear(); _closeProgram = true; break;

                default:
                    break;
            }
        }

        public void UserButtonsActivitiesInWindow(List<Button> ButtonsList)
        {
            int pressedCharCode;
            do
            {
                ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                int hashCode = pressedChar.Key.GetHashCode();
                pressedCharCode = hashCode;

                switch (pressedChar.Key)
                {
                    case ConsoleKey.Escape:

                        if (_creditWindowIsOpen == true)
                        {
                            Console.Clear(); _Render_Controller.ShowGameWindow();
                            _creditWindowIsOpen = false;
                        }
                        else
                        {
                            _closeProgram = true;
                            Console.Clear();
                        }
                        break;

                    case ConsoleKey.RightArrow: _GuiButtonsController.ActiveNextRightButton(ButtonsList); _gameWindow.RenderButtons(); break;
                    case ConsoleKey.LeftArrow: _GuiButtonsController.ActiveNextLeftButton(ButtonsList); _gameWindow.RenderButtons(); break;
                    case ConsoleKey.Enter:

                        if (_creditWindowIsOpen == true)
                        {
                            Console.Clear(); _Render_Controller.ShowGameWindow();
                            _creditWindowIsOpen = false;
                        }

                        else
                        {
                            UserPressEnter(_GuiButtonsController.WhichButtonIsActive(_ButtonsInGameWindows));
                        }
                        break;
                }


            } while (_closeProgram != true);
        }

        
        

    }
}
