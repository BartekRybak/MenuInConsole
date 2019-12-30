using System;
using System.Collections.Generic;
using System.Text;

namespace G_Shade.Gui.Controls
{
    partial class Menu
    {
        public string Title;
        public string Info;
        public List<Option> Options;
        public int Selected = 0;

        public Menu()
        {
            Title = string.Empty;
            Info = string.Empty;
            Options = new List<Option>();
        }

        public Menu(string title, string info, List<Option> options)
        {
            Title = title;
            Info = info;
            Options = options;
        }

        private void ResetColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public Option GetResponse()
        {
            Console.Title = Title;
            Console.CursorVisible = false;

            while(true)
            {
                Console.Clear();

                if(Info.Length > 0)
                {
                    ResetColor();

                    Console.WriteLine(Info);

                    for (int i = 0; i < Console.BufferWidth; i++)
                    {
                        Console.Write('=');
                    }
                }

                for(int i =0;i<Options.Count;i++)
                {
                    if(Selected == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        ResetColor();

                    }
                    Console.WriteLine("|" + Options[i].Text + " ");

                    ResetColor();
                }
                
                switch(Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        if(Selected > 0)
                        {
                            Selected--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (Selected < Options.Count - 1)
                        {
                            Selected++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        return Options[Selected];
                    default:
                        break;
                }
            }
        }
    }
}
