using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Point point;
        Pen pen;
        Circle circle;
        Rectagle rectagle;
        Car car;
        public Form1()
        {
            InitializeComponent();
            this.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            this.point = new Point(100, 100);
            Point.bitmap1 = this.bitmap;
            Point.pictureBox1 = pictureBox1;
            this.pen = new Pen(Color.Black, 5);
            Point.pen1 = this.pen;
            this.circle = new Circle(200, 200, 100);

            Ellipse.bitmap1 = this.bitmap;
            Ellipse.pen1 = this.pen;
            Ellipse.pictureBox1 = pictureBox1;

            this.rectagle = new Rectagle(100, 100, 100, 100);
            Rectagle.bitmap1 = this.bitmap;
            Rectagle.pen1 = this.pen;
            Rectagle.pictureBox1 = pictureBox1;

            this.car = new Car(100, 100, 200, 100);
            Car.bitmap1 = this.bitmap;
            Car.pictureBox1 = pictureBox1;
            Car.pen1 = this.pen;

            String.bitmap1 = this.bitmap;
            String.pen1 = this.pen;
            String.pictureBox1 = pictureBox1;

            textBox1.Text = "50";
            textBox2.Text = "50";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.point.Draw();
            //this.circle.Draw();
            //this.rectagle.Draw();
            this.car.Draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.car.MoveTo(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                this.car.Draw();
            }
            if(e.KeyData == Keys.Down)
            {
                this.car.MoveTo(0, 10);
            }
            if (e.KeyData == Keys.Up)
            {
                this.car.MoveTo(0, -10);
            }
            if (e.KeyData == Keys.Right)
            {
                this.car.MoveTo(10, 0);
            }
            if(e.KeyData == Keys.Left)
            {
                this.car.MoveTo(-10, 0);
            }
        }
    }
}
