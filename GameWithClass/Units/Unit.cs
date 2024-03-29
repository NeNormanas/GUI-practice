﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClass.Game
{
    class Unit
    {
        protected int X;
        protected int Y;
        protected string Name; 

        public Unit(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, X = {X}, Y = {Y}");

        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }


        public virtual void Render()
        {
            Console.SetCursorPosition(0, 0);

        }
    }

    
}
