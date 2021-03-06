﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Lab
{
    class Rectangle : IDrawable
    {
        int width;
        int height;
        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        
        public void Draw() 
        {
            DrawLine(this.Width, '*', '*');
            for (int i = 1; i < this.Height - 1; i++) 
            {
                DrawLine(this.Width, ' ', '*');
            }
            DrawLine(this.Width, '*', '*');
        
        }     
        
        private void DrawLine(int width, char end, char mid) 
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; i++) 
            {
                Console.Write(mid);
            }
            Console.Write(end);
        }




        private int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        private int Height 
        {
            get { return this.height; }
            set { this.height = value; }
        }


    }
}
