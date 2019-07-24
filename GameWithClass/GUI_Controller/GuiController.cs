using GameWithClass.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClass.GUI
{
    class GuiController
    {
        // FIELDS IR PROPERTIES

        public GameWindow GameWindow { get; set; }
        public CreditWindow CreditWindow { get; set; }
        private List<Button> ButtonsList = new List<Button>();
        private bool _closeTheProgram = false;

        GameController myGame = new GameController();


        // KONSTRUKTORIUS 

        public GuiController(GameWindow gameWindow, CreditWindow creditWindow)
        {
            this.GameWindow = gameWindow;
            this.CreditWindow = creditWindow;
            ButtonsList = gameWindow.Mygtukai;


        }

        // FUNKCIJOS


        public void ShowMenu()
        {
            GameWindow.Render();
        }

        public void ShowCreditWindow()
        {
            CreditWindow.Render();
        }


        public void QuitButtonActive()
        {
            ButtonsList[2].SetActive();
            ButtonsList[2].Render();
        }

        public void AllButtomsDisable()
        {
            for (int i = 0; i < ButtonsList.Count; i++)
            {
                ButtonsList[i].Disable();
                ButtonsList[i].Render();
            }
        }

        public void EnteredCreditButton()
        {
            ShowCreditWindow();
            ConsoleKeyInfo pressedChar = Console.ReadKey(true);
            pressedChar.Key.GetHashCode();

            if (pressedChar.Key == ConsoleKey.Enter || pressedChar.Key == ConsoleKey.Escape)
            {
                ShowMenu();
            }

        }

        public void EnteredQuitButton()
        {
            _closeTheProgram = true;
        }

        public void EnteredStartButton()
        {
            Console.Clear();
            myGame.StartGame();
        }


        public void ButtonOpen()
        {
            for (int i = 0; i < ButtonsList.Count; i++)
            {
                if (ButtonsList[i].isActive == true)
                {
                    if (ButtonsList[i] == ButtonsList[0])
                    {
                        EnteredStartButton();
                    }
                    else if (ButtonsList[i] == ButtonsList[1])
                    {
                        EnteredCreditButton();
                    }
                    else if (ButtonsList[i] == ButtonsList[2])
                    {
                        EnteredQuitButton();
                        break;
                    }
                }
            }
        }

        public void MoveButtonRight()
        {
            for (int i = 0; i < ButtonsList.Count; i++)
            {
                if (ButtonsList[i].isActive == true)
                {
                    if (i != 2)
                    {
                        AllButtomsDisable();
                        ButtonsList[i + 1].SetActive();
                        ButtonsList[i + 1].Render();
                        break;
                    }
                    else
                    {
                        AllButtomsDisable();
                        ButtonsList[0].SetActive();
                        ButtonsList[0].Render();
                        break;
                    }
                }
            }
        }

        public void CloseEnteredWindow()
        {
            ConsoleKeyInfo pressedChar = Console.ReadKey(true);
            pressedChar.Key.GetHashCode();

            if (pressedChar.Key == ConsoleKey.Enter)
            {
                ShowMenu();
            }
        }

        public void MoveButtonLeft()
        {
            for (int i = 0; i < ButtonsList.Count; i++)
            {
                if (ButtonsList[i].isActive == true)
                {
                    if (i != 0)
                    {
                        AllButtomsDisable();
                        ButtonsList[i - 1].SetActive();
                        ButtonsList[i - 1].Render();
                        break;
                    }
                    else
                    {
                        AllButtomsDisable();
                        ButtonsList[2].SetActive();
                        ButtonsList[2].Render();
                        break;
                    }
                }
            }
        }

        public void UserActivity()
        {
            int escapeHashCode;
            do
            {
                ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                int hashCode = pressedChar.Key.GetHashCode();
                escapeHashCode = hashCode;
                switch (pressedChar.Key)
                {
                    case ConsoleKey.Escape:
                        AllButtomsDisable();
                        QuitButtonActive();
                        Console.Clear();
                        break;
                    case ConsoleKey.RightArrow:
                        MoveButtonRight();
                        break;
                    case ConsoleKey.LeftArrow:
                        MoveButtonLeft();
                        break;
                    case ConsoleKey.Enter:
                        ButtonOpen();
                        break;
                }

                if (_closeTheProgram == true)
                {
                    Console.Clear();
                }

            } while (escapeHashCode != 27 && _closeTheProgram != true);
        }
    }
}
