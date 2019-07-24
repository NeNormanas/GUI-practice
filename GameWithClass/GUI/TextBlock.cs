using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClass.GUI
{
    sealed class TextBlock : GuiObject
    {
        private List<TextLine> textBlocks = new List<TextLine>();

        public TextBlock(int x, int y, int width, List<string> text) : base(x,y,width,0)
        {
            for (int i = 0; i < text.Count; i++)
            {
                textBlocks.Add(new TextLine(x, y + i, width, text[i]));
            }

        }

        public override void Render()
        {
            for (int i = 0; i < textBlocks.Count; i++)
            {
                textBlocks[i].Render();
            }
        }



    }
}
