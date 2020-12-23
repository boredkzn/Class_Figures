using System;
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
        public static Bitmap bitmap1;
        public static PictureBox pictureBox1;
        public static Pen pen1;

        public Rectagle(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }
        public override void Draw()
        {
            using (Graphics g = Graphics.FromImage(bitmap1))
            {
                /// Рисование на белом фоне. Делаем заливку белым цветом
                //g.Clear(Color.White);
                g.DrawRectangle(pen1, this.x, this.y, this.w, this.h);
            }
            /// Назначаем наш Bitmap свойству Image
            pictureBox1.Image = bitmap1;
        }
        public void Draw(Pen pen)
        {
            using (Graphics g = Graphics.FromImage(bitmap1))
            {
                /// Рисование на белом фоне. Делаем заливку белым цветом
                //g.Clear(Color.White);
                g.DrawRectangle(pen, this.x, this.y, this.w, this.h);
            }
            /// Назначаем наш Bitmap свойству Image
            pictureBox1.Image = bitmap1;
        }

        public override void MoveTo(int x, int y)
        {
            this.x += x;
            this.y += y;

            this.Draw();
        }
    }
}
