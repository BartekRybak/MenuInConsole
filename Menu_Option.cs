using System;
using System.Collections.Generic;
using System.Text;

namespace G_Shade.Gui.Controls
{
    partial class Menu
    {
        public class Option
        {
            public string Text;
            public int Id;

            public Option(string text,int id)
            {
                Text = text;
                Id = id;
            }
        }
    }
}
