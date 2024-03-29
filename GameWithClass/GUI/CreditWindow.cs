﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace GameWithClass.GUI
{
   sealed class CreditWindow : Window
    {
        public Button backButton { get; set; }
        private TextBlock creditTextBlock;

        public CreditWindow() : base(28,10,60,18,'@')
        {
            List<string> creditData = new List<string>();

            creditData.Add("");
            creditData.Add("Game design:");
            creditData.Add("Normanas Necionis");
            creditData.Add("");
            creditData.Add("Programuotojas:");
            creditData.Add("Normanas Necionis");
            creditData.Add("");
            creditData.Add("\'Art\':");
            creditData.Add("Normanas Necionis");
            creditData.Add("");
            creditData.Add("Marketingas:");
            creditData.Add("Normanas Necionis");
            creditData.Add("");

            creditTextBlock = new TextBlock(28 + 1, 10 + 1, 60 - 1, creditData);

            backButton = new Button(28 + 20, 10 + 14, 18, 3, "Back");
            backButton.SetActive();

        }

        public override void Render() 
        {
            base.Render();
            creditTextBlock.Render();
            backButton.Render();

            Console.SetCursorPosition(0, 0);
        }

    }
}
