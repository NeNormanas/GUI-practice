using GameWithClass.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClass.Units
{
    class Bullet : Hero
    {
        
        private int xCordinate;
        private int yCordinate;




        public Bullet(int x, int y, string name) : base(x, y, name)
        {
            xCordinate = x;
            yCordinate = y;

            


        }

        public void BulletRender( int y)
        {
                Console.SetCursorPosition(xCordinate, yCordinate - y);
                Console.WriteLine("*");
          
             
        }


    }
}
