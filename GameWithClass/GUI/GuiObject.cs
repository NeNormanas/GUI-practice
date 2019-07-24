using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClass.GUI
{
    abstract class GuiObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }


        public GuiObject(int x, int y, int width, int height)
        {
            this.X = x;
            this.Y = y;
            this.Height = height;
            this.Width = width;

        }

        abstract public void Render();


    }
}
