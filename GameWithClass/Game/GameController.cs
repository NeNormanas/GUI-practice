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
            myGame = new GameScreen(60, 30);
            myGame.SetHero(new Hero(30, 15, "Normanas"));

            Random rnd = new Random();
            int enemycount = 0;

            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(rnd.Next(0, 60), rnd.Next(0, 30), "enemy" + enemycount, i));
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
                    myGame.Render();

                    System.Threading.Thread.Sleep(800);


                }

            } while (needToRender);


        }


        //myGame.Render();

        //myGame.MoveHeroLeft();


        //myGame.Render();

        //Enemy secondEnemy = myGame.GetEnemyById(1);
        //Enemy forthEnemy = myGame.GetEnemyById(3);

        //if (secondEnemy != null && forthEnemy != null) // visada daryti tikrinimus, kad nebutu null, nes su null reiksme nulus programa.
        //{
        //    forthEnemy.MoveDown();
        //    secondEnemy.MoveDown();
        //}

        //myGame.Render();

        //myGame.MoveAllEnemiesDown();

        //myGame.Render();


        // TASK 4.




    }



}

