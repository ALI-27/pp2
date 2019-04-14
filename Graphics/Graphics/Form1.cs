using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics
{
    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.White);
        Pen pen1 = new Pen(Color.Red, 3);
        Pen pen2 = new Pen(Color.Yellow, 3);
        Pen pen3 = new Pen(Color.Green, 3);
        Pen pen4 = new Pen(Color.Red, 3);



        Point[] points = new Point[]
         {
              new Point(200, 150),
              new Point(175, 185),
              new Point(225, 185)
          };
        Point[] points1 = new Point[]
         {
              new Point(200, 200),
              new Point(175, 165),
              new Point(225, 165)
          };
        Point[] points2 = new Point[]
         {
              new Point(275, 275),
              new Point(250, 310),
              new Point(300, 310)
          };
        Point[] points3 = new Point[]
         {
              new Point(275, 325),
              new Point(250, 290),
              new Point(300, 290)
          };
        Point[] points4 = new Point[]
         {
              new Point(650, 75),
              new Point(625, 110),
              new Point(675, 110)
          };
        Point[] points5 = new Point[]
         {
              new Point(650, 125),
              new Point(625, 90),
              new Point(675, 90)
          };
        Point[] points6 = new Point[]
         {
              new Point(400, 170),
              new Point(360, 195),
              new Point(440, 195),
          };
        Point[] points7 = new Point[]
         {
          //   new Point(360 , 215),
           //  new Point(440 ,215),
            // new Point(400, 230),
            new Point(400 , 260),
            new Point(360 , 235),
            new Point(440 , 235)
         };
        Point[] points8 = new Point[]
         {
             new Point(400 , 190),
             new Point(385 ,210),
             new Point(415, 210)
         };
        Point[] points9 = new Point[]
         {
             new Point(520 , 350),
             new Point(495 ,385),
             new Point(545, 385)
         };
        Point[] points10 = new Point[]
         {
             new Point(520, 400),
             new Point(495 ,365),
             new Point(545, 365)
         };
        Point[] points11 = new Point[]
        {
            new Point(450, 120),
           //  new Point(450, 140),
             new Point(445 ,145),
             new Point(455, 145)
        };
        Point[] points12 = new Point[]
       {
            new Point(420, 150),
             new Point(445 ,145),
             new Point(445, 155)
       };
        Point[] points13 = new Point[]
      {
            new Point(480, 150),
             new Point(455 ,145),
             new Point(455, 155)
      };
        Point[] points14 = new Point[]
     {
            new Point(450, 175),
             new Point(445 ,155),
             new Point(455, 155)
     };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.Blue;     //Окрашивает фон в синий цвет

            e.Graphics.FillEllipse(pen.Brush, 30, 60, 25, 25);     //Белые Звезды у каждого свои координаты
            e.Graphics.FillEllipse(pen.Brush, 300, 30, 25, 25);
            e.Graphics.FillEllipse(pen.Brush, 500, 90, 25, 25);
            e.Graphics.FillEllipse(pen.Brush, 700, 150, 25, 25);
            e.Graphics.FillEllipse(pen.Brush, 700, 400, 25, 25);
            e.Graphics.FillEllipse(pen.Brush, 650, 320, 25, 25);
            e.Graphics.FillEllipse(pen.Brush, 50, 290, 25, 25);
            e.Graphics.FillEllipse(pen.Brush, 300, 390, 25, 25);

            //  GraphicsPath graphicsPath = new GraphicsPath(FillMode.Winding);
            //  graphicsPath.AddPolygon(points);
            // graphicsPath.AddPolygon(points1);
            // e.Graphics.FillPath(pen1.Brush , graphicsPath);

            //Красная звезда обьединение двух треульгоников
            e.Graphics.FillPolygon(pen1.Brush, points);    //Красная звезда  2 треугольника связанные между собой 
            e.Graphics.FillPolygon(pen1.Brush, points1);           //т.е. друг на друга накдываются

            e.Graphics.FillPolygon(pen1.Brush, points2);   //Красная звезда  2 треугольница связанные между собой 
            e.Graphics.FillPolygon(pen1.Brush, points3);           //т.е. друг на друга накдываются

            e.Graphics.FillPolygon(pen1.Brush, points4);   //Красная звезда  2 треугольница связанные между собой
            e.Graphics.FillPolygon(pen1.Brush, points5);          //т.е. друг на друга накдываются

            e.Graphics.FillPolygon(pen1.Brush, points9);   //Красная звезда  2 треугольница связанные между собой
            e.Graphics.FillPolygon(pen1.Brush, points10);          //т.е. друг на друга накдываются

            //Карабль желтый 6угольник
            e.Graphics.FillPolygon(pen2.Brush, points6);        //часть центрального желтого коробля верхний треугольник
            e.Graphics.FillRectangle(pen2.Brush, 360, 195, 80, 40);  //часть коробля квадрат в центре
            e.Graphics.FillPolygon(pen2.Brush, points7);        //часть коробля нижний треугольник

            //стрелка внутри нее
            e.Graphics.FillPolygon(pen3.Brush, points8);           //Стрелка внутри коробля с зеленым цветом
            e.Graphics.FillRectangle(pen3.Brush, 392, 210, 17, 20);    //окончание ее ввиде квадрата 


            //Цель коробля зеленая звезда 
            e.Graphics.FillPolygon(pen3.Brush, points11);    //Зеленая маленькая звезда (цель коробля)
                                                             //4 маленьких тругольника
            e.Graphics.FillPolygon(pen3.Brush, points12);         //в центре маленький квадрат

            e.Graphics.FillPolygon(pen3.Brush, points13);

            e.Graphics.FillPolygon(pen3.Brush, points14);
            e.Graphics.FillRectangle(pen3.Brush, 445, 145, 10, 10);

            // РАМКА
            e.Graphics.FillRectangle(pen4.Brush,0, 0, 750, 5);
            e.Graphics.FillRectangle(pen4.Brush, 750, 0, 5, 505);
            e.Graphics.FillRectangle(pen4.Brush, 0, 0, 5, 500);
            e.Graphics.FillRectangle(pen4.Brush, 0, 500, 750, 5);




        }
    }
}