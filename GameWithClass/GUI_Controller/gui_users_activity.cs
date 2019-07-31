using GameWithClass.Game;
using GameWithClass.GUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClass.GUI_Controller
{
    class gui_users_activity
    {
        private List<Button> _ButtonsInGameWindows;
        private GameController _myGame;
        private gui_render_controller _Render_Controller;
        private GameWindow _gameWindow;
        private gui_buttons_controller _GuiButtonsController;

        private bool _closeProgram = false;
        private bool _creditWindowIsOpen = false;

        public gui_users_activity(List<Button> ButtonsInGameWindows, GameController myGame, gui_render_controller Render_Controller, GameWindow gameWindow, gui_buttons_controller GuiButtonsController)

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
                case "Start": Console.Clear(); _myGame.StartGame(); break;
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
                    case ConsoleKey.Escape: Console.Clear(); Console.WriteLine("PROGRAMA ISJUNGTA"); break;
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


            } while (pressedCharCode != 27 && _closeProgram != true);
        }

    }
}
