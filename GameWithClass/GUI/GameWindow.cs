using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClass.GUI
{
    sealed class GameWindow : Window
    {
       
        private TextBlock titleTextBlock;
        public Button startButton { get; }
        public Button creditsButton { get;}
        public Button quitButton { get;}
       

        public GameWindow() : base(0,0,120,30,'%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<string> { "Super duper zaidimas", "Normanas Necionis kuryba", "Made in Vilnius Coding School!" });

            startButton = new Button(20, 13, 18, 5, "Start");
            startButton.SetActive();

            creditsButton = new Button(50, 13, 18, 5, "Credits");

            quitButton = new Button(80, 13, 18, 5, "Quit");

            
        }

        
        



        public override void Render() 
        {
            base.Render();

            titleTextBlock.Render();
            startButton.Render();
            creditsButton.Render();
            quitButton.Render();

            Console.SetCursorPosition(0, 0);

        }

        public void RenderButtons()
        {
            startButton.Render();
            creditsButton.Render();
            quitButton.Render();

        }
    }
}
