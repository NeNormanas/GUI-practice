using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClass.GUI
{
    class Window : GuiObject
    {
        private Frame border;

        public Window(int x, int y, int width, int height, char symbol) : base(x,y,width,height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;

            border = new Frame(x, y, width, height, symbol);

            
        }

        public override void Render()
        {
            border.Render();
        }



    }
}
