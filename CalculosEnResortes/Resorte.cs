using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculosEnResortes
{
    public partial class Resorte : Form
    {
        Timer timer = new Timer();
        private bool inicio;
        private bool mayor;
        private bool menor;
        private int contador;
        private int contadorinicio;
        private bool dibujado;
        private TextBox L1;
        private TextBox deltax1;
        private int contador1;
        private bool drawn;
        private bool calculado;
        public Resorte()
        {
            InitializeComponent();

            contador = 0;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = 550;
            timer.Enabled = false;
            inicio = true;
            mayor = false;
            dibujado = false;
            menor = false;
            calculado = false;
            drawn = false;
            contadorinicio = 0;
            contador1 = 0;
        }

        private void Resorte_Load(object sender, EventArgs e)
        {

        }

        private List<Point> original()
        {
            List<Point> points = new List<Point>();

           
            for (double i = 24; i < 150; i += 0.01)
            {
                Point point = new Point();
                point.X = (int)(Math.Sin(i) * 50 + i * 2);
                point.Y = (int)(Math.Cos(i) * 50 + 80);
                points.Add(point);

            }
           
            return points;

        }
        private List<Point> MasGrande()
        {
            List<Point> points = new List<Point>();


            for (double i = 11; i < 96; i += 0.01)
            {
                Point point = new Point();
                point.X = (int)(Math.Sin(i) * 50 + i * 4);
                point.Y = (int)(Math.Cos(i) * 50 +250);
                points.Add(point);

            }
            
            return points;

        }
        private List<Point> MasPequeno()
        {
            List<Point> points = new List<Point>();


            for (double i = 24; i < 100; i += 0.01)
            {
                Point point = new Point();
                point.X = (int)(Math.Sin(i) * 50 + i *2);
                point.Y = (int)(Math.Cos(i) * 50 + 250);
                points.Add(point);

            }
           
            return points;

        }

       

        private void Timer_Tick(object sender, EventArgs p)
        {
            Graphics e = pictureBox1.CreateGraphics();

            if (inicio)
            {
                if (contadorinicio == 0)
                {
                    contadorinicio = -1;
                    e.DrawLine(
                        new Pen(Color.Blue, 2f),
                        new Point(0, 140),
                        new Point(140, 140));
                }
                if (contadorinicio == 1)
                {
                    contadorinicio = -2;
                    L1 = new TextBox();
                    L1.Location = new Point(145, 132);
                   
                    L1.Size = new Size(40, 40);
                    pictureBox1.Controls.Add(L1);
                }
                if (contadorinicio == 2)
                {
                    contadorinicio = -3;
                    e.DrawLine(
                        new Pen(Color.Blue, 2f),
                        new Point(190, 140),
                        new Point(342, 140));
                }
                if (contadorinicio == -1)
                    contadorinicio += 2;
                if (contadorinicio == -2)
                    contadorinicio += 4;
                if (contadorinicio == -3)
                    dibujado = true;


            }
            if (menor)
            {
                if (contador1 == 0)
                {
                    contador1 = -1;
                    e.DrawLine(
                        new Pen(Color.Blue, 2f),
                        new Point(0, 310),
                        new Point(103, 310));
                }
                if (contador1 == 1)
                {
                    contador1 = -2;
                    TextBox L = new TextBox();
                    L.Location = new Point(105, 300);
                    L.Size = new Size(40, 40);
                    pictureBox1.Controls.Add(L);
                }
                if (contador1 == 2)
                {
                    contador1 = -3;
                    e.DrawLine(
                        new Pen(Color.Blue, 2f),
                        new Point(146, 310),
                        new Point(243, 310));
                }
                if (contador1 == 5)
                {
                    contador1 = -6;
                    Label deltaL1 = new Label();
                    deltaL1.Text = "∆X=";
                    deltaL1.Location = new Point(245, 315);
                    TextBox deltax1 = new TextBox();
                    deltax1.Text = deltax.Text;
                    deltax1.Location = new Point(280, 315);
                    this.pictureBox1.Controls.Add(deltax1);
                    deltaL1.AutoSize = true;
                    pictureBox1.Controls.Add(deltaL1);
                }
                if (contador1 == 4)
                {
                    contador1 = -5;
                    e.DrawLine(
                        new Pen(Color.Blue, 2f),
                        new Point(243, 0),
                        new Point(243, pictureBox1.Size.Height));
                                   }
                if (contador1 == 3)
                {
                    contador1 = -4;
                    e.DrawLine(
                        new Pen(Color.Blue, 2f),
                        new Point(342, 0),
                        new Point(342, pictureBox1.Size.Height));

                }
                if(contador1==-1)
                   contador1+=2;
                if (contador1 == -2)
                    contador1 += 4;
                if (contador1 == -3)
                    contador1 += 6;
                if (contador1 == -4)
                    contador1 += 8;
                if (contador1 == -5)
                    contador1 += 10;
                if (contador1 == -6)
                    contador1 += 12;
            }
             if (mayor)
            {
                if (contador == 0)
                {
                    contador = -1;
                    e.DrawLine(
                        new Pen(Color.Blue, 2f),
                        new Point(0, 310),
                        new Point(190, 310));
                }
                if (contador == 1)
                {
                    contador = -2;
                    TextBox L2 = new TextBox();
                    L2.Location = new Point(192, 300);
                    L2.Size = new Size(40, 40);
                    if(L1.Text!="" && deltax.Text!="")
                    L2.Text = (int.Parse(L1.Text) + int.Parse(deltax.Text)).ToString();
                    pictureBox1.Controls.Add(L2);
                }
                if (contador == 2)
                {
                    contador = -3;
                    e.DrawLine(
                        new Pen(Color.Blue, 2f),
                        new Point(234, 310),
                        new Point(408, 310));
                }
                if (contador == 4)
                {
                    contador = -5;
                    e.DrawLine(
                        new Pen(Color.Blue, 2f),
                        new Point(408, 0),
                        new Point(408, pictureBox1.Size.Height));
                }
                if (contador == 3)
                {
                    contador = -4;
                    e.DrawLine(
                        new Pen(Color.Blue, 2f),
                        new Point(342, 0),
                        new Point(342, pictureBox1.Size.Height));
                }
                if (contador == 5)
                {
                    contador = -6;
                    Label deltaL = new Label();
                    deltaL.Text = "∆X=";
                    deltaL.Location = new Point(343, 315);
                    deltax1 = new TextBox();
                    deltax1.Text = deltax.Text;
                    deltax1.Location = new Point(368, 312);
                    deltax1.Size = new Size(20,20);
                    this.pictureBox1.Controls.Add(deltax1);
                    deltaL.AutoSize = true;
                    pictureBox1.Controls.Add(deltaL);
                }

                if (contador == -1)
                    contador += 2;
                if (contador == -2)
                    contador += 4;
                if (contador == -3)
                    contador += 6;
                if (contador == -4)
                    contador += 8;
                if (contador == -5)
                    contador += 10;
                if (contador == -6)
                    drawn = true;
            }

          

        }

        void calculos()
        {
            float F = 0;
            float k = 0;
            float dx = 0;
            if (K.Text!= "" && deltax.Text!="" && fuerza.Text=="")

            {
                F = (-1)*(float.Parse(K.Text))*(float.Parse(deltax.Text));
                fuerza.Text = F.ToString();
            }

            if (fuerza.Text != "" && deltax.Text != "" && K.Text=="")

            {
              k= (float.Parse(fuerza.Text))/((-1) * (float.Parse(deltax.Text)));
                K.Text = k.ToString();
            }

            if (fuerza.Text != "" && K.Text != "" && deltax.Text=="")

            {
                dx = (float.Parse(fuerza.Text)) / ((-1) * (float.Parse(K.Text)));
                deltax.Text = dx.ToString();
                if (dx > 0 )
                    mayor = true;
                else if (dx < 0)
                    menor = true;
            }
            if (U.Text == "" && deltax.Text != "" && K.Text!="")
            {
                U.Text = ((double)1/2*double.Parse(K.Text)*Math.Pow(double.Parse(deltax.Text), 2)).ToString();
                calculado = true;
            }

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {


            e.Graphics.DrawLine(
         new Pen(Color.Black, 2f),
         new Point(0, 0),
         new Point(0, pictureBox1.Size.Height));

            if (dibujado)
            {
                contadorinicio = -1;
                e.Graphics.DrawLine(
                    new Pen(Color.Blue, 2f),
                    new Point(0, 140),
                    new Point(140, 140));
          
              
             
            
                contadorinicio = -3;
                e.Graphics.DrawLine(
                    new Pen(Color.Blue, 2f),
                    new Point(190, 140),
                    new Point(342, 140));
            }

            timer.Enabled = true;
            e.Graphics.DrawLines(new Pen(new SolidBrush(Color.Gray), 2f), original().ToArray());
            if (mayor )
            {
                
                e.Graphics.DrawLines(new Pen(new SolidBrush(Color.Gray), 2f), MasGrande().ToArray());
               
                    e.Graphics.DrawLine(
                        new Pen(Color.Blue, 2f),
                        new Point(0, 310),
                        new Point(190, 310));
                if (drawn)
                {
                    TextBox L2 = new TextBox();
                    L2.Location = new Point(192, 300);
                    L2.Size = new Size(40, 40);
                    if (L1.Text != "" && deltax.Text != "")
                        L2.Text = (int.Parse(L1.Text) + int.Parse(deltax.Text)).ToString();
                    pictureBox1.Controls.Add(L2);


                    e.Graphics.DrawLine(
                        new Pen(Color.Blue, 2f),
                        new Point(234, 310),
                        new Point(408, 310));

                    e.Graphics.DrawLine(
                        new Pen(Color.Blue, 2f),
                        new Point(408, 0),
                        new Point(408, pictureBox1.Size.Height));


                    e.Graphics.DrawLine(
                        new Pen(Color.Blue, 2f),
                        new Point(342, 0),
                        new Point(342, pictureBox1.Size.Height));

                    Label deltaL = new Label();
                    deltaL.Text = "∆X=";
                    deltaL.Location = new Point(343, 315);
                    deltax1 = new TextBox();
                    deltax1.Text = deltax.Text;
                    deltax1.Location = new Point(368, 312);
                    deltax1.Size = new Size(20, 20);
                    this.pictureBox1.Controls.Add(deltax1);
                    deltaL.AutoSize = true;
                    pictureBox1.Controls.Add(deltaL);
                }
            }
            else if (menor)
                e.Graphics.DrawLines(new Pen(new SolidBrush(Color.Gray), 2f), MasPequeno().ToArray());







        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            if (deltax.Text != "")
            {
                if (int.Parse(deltax.Text) > 0)
                {
                    mayor = true;
                    
                    calculos();
                }
                else if(int.Parse(deltax.Text) < 0 )
                {
                    menor = true;
                }
            }
             if (textBox1.Text!="")
            {
                if (int.Parse(textBox1.Text) > int.Parse(L1.Text) )
                {
                    mayor = true;
                    deltax.Text = (int.Parse(textBox1.Text) - int.Parse(L1.Text)).ToString();

                    calculos();
                   
                }
                else if (int.Parse(deltax.Text) < int.Parse(L1.Text))
                {
                    menor = true;
                    deltax.Text = (int.Parse(L1.Text) - int.Parse(textBox1.Text)).ToString();

                    calculos();
                }
                
            }
            if (deltax.Text == "" && fuerza.Text != "" && K.Text != "")
            {
                
                calculos();
            }

            if (U.Text!="")
            {
                if(K.Text!="")
                deltax.Text = (Math.Sqrt((2*double.Parse(U.Text))/double.Parse(K.Text))).ToString();
                else if (deltax.Text != "")
                    K.Text = ((2*double.Parse(U.Text))/(Math.Pow(double.Parse(K.Text), 2))).ToString();
                calculos();
            }

            pictureBox1.Refresh();
        }
    }
}
