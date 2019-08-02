using GameWithClass.GUI_Controller;
using GameWithClass.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClass.Game
{
    class GameController
    {
        private GameScreen myGame;
        public Hero Hero { get; private set; }
        private Bullet bullet;
        int bullerYcordinate = 0;

        public void StartGame()
        {
            InitGame();
            StartGameLoop();
        }

        public void InitGame()
        {
            myGame = new GameScreen(100, 50);
            Hero = new Hero(50, 50, "Normanas");
            myGame.SetHero(Hero);
            bullet = new Bullet(Hero.GetX(), Hero.GetY(), "");



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
                        case ConsoleKey.Spacebar:

                            if (bullerYcordinate >= Hero.GetY())
                            {
                                bullerYcordinate = 0;

                            }
                            else
                            {
                                bullerYcordinate += 1; // kontoliavimas per kiek langeliu pakyla i virsu

                            }

                            bullet.BulletRender(bullerYcordinate);

                            break;
                        

                    }

                     myGame.MoveAllEnemiesDown();

                     myGame.Render();


                    

                    if (pressedChar.Key != ConsoleKey.Escape)
                    {
                        System.Threading.Thread.Sleep(200);

                    }




                }

               

            } while (needToRender);


        }


        
    }



}

