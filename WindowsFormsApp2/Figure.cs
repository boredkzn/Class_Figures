using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    abstract public class Figure
    {
        public int x;
        public int y;
        public int w;
        public int h;

        abstract public void Draw();
        abstract public void MoveTo(int x, int y);
        public void Clear()
        {
            Graphics g = Graphics.FromImage(Init.bitmap1);
            g.Clear(Color.White);
        }

        public void DeleteF(Figure figure)
        {
            using (Graphics g = Graphics.FromImage(Init.bitmap1))
            {
                ShapeContainer.arrayList.Remove(figure);
                this.Clear();
                Init.pictureBox1.Image = Init.bitmap1;

                foreach (Figure f in ShapeContainer.arrayList)
                {
                    f.Draw();
                }
            }
        }
    }
}
