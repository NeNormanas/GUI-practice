using System;
using System.Collections.Generic;
using System.Text;

namespace GameWithClass.GUI
{
    class Button : GuiObject
    {
        private Frame activeFrame;
        private Frame notActiveFrame;

        public bool isActive { get; set; } =  false;
       
        public string Label
        {
            get { return textLine.Label; }
            set { textLine.Label = value; }
        }
        private TextLine textLine;


        public Button(int x, int y, int width, int height, string buttonText) : base(x,y,width,height)
        {
            notActiveFrame = new Frame(x, y, width, height,'+');
            activeFrame = new Frame(x, y, width, height,'#');

            textLine = new TextLine(x + 1, y + 1 + ((height - 2) / 2), width - 2, buttonText);
            
        }

        

        public override void Render()
        {
            if (isActive)
            {
                activeFrame.Render();
            }
            else
            {
                notActiveFrame.Render();
            }
            textLine.Render();
        }

        public void SetActive()
        {
            isActive = true;
        }

        public void Disable()
        {
            isActive = false;
        }

       
    }
}
