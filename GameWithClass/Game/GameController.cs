using GameWithClass.GUI_Controller;

using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClass.Game
{
    class GameController
    {
        private GameScreen myGame;
        

        public void StartGame()
        {
            InitGame();
            StartGameLoop();
        }

        public void InitGame()
        {
            myGame = new GameScreen(100, 50);
            myGame.SetHero(new Hero(50, 50, "Normanas"));
           
           
            

            Random rnd = new Random();
            int enemycount = 0;

            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(rnd.Next(0,100), rnd.Next(10,50), "enemy" + enemycount, i));
                enemycount++;

            }
        }

        public void StartGameLoop()
        {
            bool needToRender = true;
            

            do
            {
                Console.Clear();

                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    int hashCode = pressedChar.Key.GetHashCode();

                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Escape:
                            needToRender = false;

                            break;
                        case ConsoleKey.RightArrow:
                            myGame.MoveHeroRight();
                            break;
                        case ConsoleKey.LeftArrow:
                            myGame.MoveHeroLeft();
                            break;
                        
                    }

                    myGame.MoveAllEnemiesDown();

                     myGame.Render();
                    

                    if (pressedChar.Key != ConsoleKey.Escape)
                    {
                        System.Threading.Thread.Sleep(250);
                    }

                    


                }

            } while (needToRender);


        }


        
    }



}

