﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class Rectagle : Figure
    {
        public Rectagle(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }
        
        public Rectagle()
        {
            this.x = 0;
            this.y = 0;
            this.w = 0;
            this.h = 0;
        }
        public override void Draw()
        {
            using (Graphics g = Graphics.FromImage(Init.bitmap1))
            {
                /// Рисование на белом фоне. Делаем заливку белым цветом
                //g.Clear(Color.White);
                g.DrawRectangle(Init.pen1, this.x, this.y, this.w, this.h);
            }
            /// Назначаем наш Bitmap свойству Image
            Init.pictureBox1.Image = Init.bitmap1;
        }
        public void Draw(Pen pen)
        {
            using (Graphics g = Graphics.FromImage(Init.bitmap1))
            {
                /// Рисование на белом фоне. Делаем заливку белым цветом
                //g.Clear(Color.White);
                g.DrawRectangle(pen, this.x, this.y, this.w, this.h);
            }
            /// Назначаем наш Bitmap свойству Image
            Init.pictureBox1.Image = Init.bitmap1;
        }

        public override void MoveTo(int x, int y)
        {
            this.x += x;
            this.y += y;

            this.Draw();
        }
    }
}
