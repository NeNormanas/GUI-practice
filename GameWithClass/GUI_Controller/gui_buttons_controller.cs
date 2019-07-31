using GameWithClass.GUI;
using GameWithClass.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClass.GUI_Controller
{
    class gui_buttons_controller 
    {

        public List<Button> ButtonsInGameWindows { get; private set; }
        public List<Button> ButtonsInCreditWindows { get; private set; }

        
        public gui_buttons_controller(CreditWindow creditWindow, GameWindow gameWindow)
        {
            CreditWindow _CreditWindow = creditWindow;
            GameWindow _GameWindow = gameWindow;

            ButtonsInGameWindows = CreateButtonsList(_GameWindow.startButton, _GameWindow.creditsButton, _GameWindow.quitButton); // suarasai kokius nori mygtukus itraukti
            ButtonsInCreditWindows = CreateButtonsList(_CreditWindow.backButton);


        }


        private List<Button> CreateButtonsList(params Button[] butons) // neribotas skaicius mygtuku galimas prideti
        {
            List<Button> _buttonsInWindow = new List<Button>();

            for (int i = 0; i < butons.Length; i++)
            {
                _buttonsInWindow.Add(butons[i]);
            }

            return _buttonsInWindow;

        }

        public Button WhichButtonIsActive(List<Button> ButtonsList)
        {
            Button button = null;

            if (ButtonsList.Count != 0)
            {
                for (int i = 0; i < ButtonsList.Count; i++)
                {
                    if (ButtonsList[i].isActive == true)
                    {
                        button = ButtonsList[i];
                    }
                    else
                    {

                    }
                }
            }
            else
            {
                Console.WriteLine("Buttons list is empty");
            }
            return button;

        }

        public void ActiveNextRightButton(List<Button> buttomsList)
        {
            const int listZeroIndex = 0;

            for (int i = 0; i < buttomsList.Count; i++)
            {
                if (buttomsList[i].isActive == true)
                {
                    if (i != buttomsList.Count - 1)
                    {
                        buttomsList[i].Disable();
                        buttomsList[i + 1].SetActive();
                        break;
                    }
                    else
                    {
                        buttomsList[i].Disable();
                        buttomsList[listZeroIndex].SetActive();
                        break;
                    }
                }
            }
        }

        public void ActiveNextLeftButton(List<Button> buttomsList)
        {
            for (int i = 0; i < buttomsList.Count; i++)
            {
                if (buttomsList[i].isActive == true)
                {
                    if (i != 0)
                    {
                        buttomsList[i].Disable();
                        buttomsList[i - 1].SetActive();
                        break;
                    }
                    else
                    {
                        buttomsList[i].Disable();
                        buttomsList[buttomsList.Count - 1].SetActive();
                        break;
                    }
                }
            }
        }


    }
}
