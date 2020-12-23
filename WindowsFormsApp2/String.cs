using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class String : Figure
    {
        public static Bitmap bitmap1;
        public static PictureBox pictureBox1;
        public static Pen pen1;

        public string str;

        public String(int x, int y, string str)
        {
            this.x = x;
            this.y = y;
            this.str = str;
        }

        public override void Draw()
        {
            using (Graphics g = Graphics.FromImage(bitmap1))
            {
                /// Рисование на белом фоне. Делаем заливку белым цветом
                //g.Clear(Color.White);
                g.DrawString(str, new Font("Courier New", 14), new SolidBrush(Color.Black), new PointF(this.x, this.y));
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
