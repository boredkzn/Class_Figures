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
        int flag = 0;
        Bitmap bitmap;
        Pen pen;
        Circle circle;
        Rectagle rectagle;
        Car car;
        ShapeContainer shapeContainer;
        public Form1()
        {
            InitializeComponent();

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            this.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            this.pen = new Pen(Color.Black, 5);

            Init.bitmap1 = this.bitmap;
            Init.pictureBox1 = pictureBox1;
            Init.pen1 = this.pen;

            this.shapeContainer = new ShapeContainer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(flag == 1)
            {
                try
                {
                    this.circle.Clear();
                    this.circle.MoveTo(int.Parse(textBoxshiftX.Text), int.Parse(textBoxshiftY.Text));
                }
                catch
                {
                    MessageBox.Show("Не все поля заполнены.");
                }
            }
            if (flag == 2)
            {
                try
                {
                    this.rectagle.Clear();
                    this.rectagle.MoveTo(int.Parse(textBoxshiftX.Text), int.Parse(textBoxshiftY.Text));
                }
                catch
                {
                    MessageBox.Show("Не все поля заполнены.");
                }
            }
            if(flag == 3)
            {
                try
                {
                    this.car.Clear();
                    this.car.MoveTo(int.Parse(textBoxshiftX.Text), int.Parse(textBoxshiftY.Text));
                }
                catch
                {
                    MessageBox.Show("Не все поля заполнены.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                try
                {
                    this.circle = new Circle(int.Parse(textBoxX.Text), int.Parse(textBoxY.Text), int.Parse(textBoxR.Text));
                    ShapeContainer.AddFigure(this.circle);
                    this.circle.Draw();
                }
                catch
                {
                    MessageBox.Show("Не все поля заполнены.");
                }
            }
            if(flag == 2)
            {
                try
                {
                    this.rectagle = new Rectagle(int.Parse(textBoxRectX.Text), int.Parse(textBoxRectY.Text), int.Parse(textBoxW.Text), int.Parse(textBoxH.Text));
                    ShapeContainer.AddFigure(this.rectagle);
                    this.rectagle.Draw();
                }
                catch
                {
                    MessageBox.Show("Не все поля заполнены.");
                }
            }
            if(flag == 3)
            {
                try
                {
                    this.car = new Car(int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox2.Text), int.Parse(textBox1.Text), textBoxNameCar.Text);
                    ShapeContainer.AddFigure(this.car);
                    this.car.Draw();
                }
                catch
                {
                    MessageBox.Show("Не все поля заполнены.");
                }
            }
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
            this.flag = 1;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
            this.flag = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (Figure figure in ShapeContainer.arrayList)
            {
                comboBox1.Items.Add(figure);
            }       
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.GetType() == (new Circle()).GetType())
            {
                this.circle = (Circle)comboBox1.SelectedItem;
                this.circle.DeleteF(this.circle);
            }
            else if (comboBox1.SelectedItem.GetType() == (new Rectagle()).GetType())
            {
                this.rectagle = (Rectagle)comboBox1.SelectedItem;
                this.rectagle.DeleteF(this.rectagle);
            }
            else if (comboBox1.SelectedItem.GetType() == (new Car()).GetType())
            {
                this.car = (Car)comboBox1.SelectedItem;
                this.car.DeleteF(this.car);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            groupBox1.Visible = true;
            groupBox4.Visible = true;
            groupBox5.Visible = true;
            this.flag = 3;
        }

        private void игровойРежимToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }
    }
}
