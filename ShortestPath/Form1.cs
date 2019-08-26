using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortestPath
{
    public partial class Form1 : Form
    {
        Pen redPen = new Pen(Color.Black, 3);
        Graphics g = null;

        public List<Point> points = new List<Point>();
        double[] angle;

        static int start_x, start_y;
        

        //Form Constructor
        public Form1()
        {
            InitializeComponent();
            start_x = canvas.Width / 2;
            start_y = canvas.Height / 2;
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            Point[] points2 = new Point[points.Count];
            points2 = ArrangePoints(points.ToArray());

            Point[] pointsClosed = new Point[points2.Length + 1];

            for (int i = 0; i < points2.Length; i++)
            {
                pointsClosed[i] = points2[i];
            }
            pointsClosed[pointsClosed.Length - 1] = pointsClosed[0];

            g = canvas.CreateGraphics();
            drawLine(redPen, pointsClosed);

            //canvas.Refresh();
            

        }
        public void DrawPoints(Pen pen, Point p)
        {
            g.DrawRectangle(pen, p.X, p.Y, 10, 10);
        }

        int addBtnClicked = 0;
        private void pointBtn_Click(object sender, EventArgs e)
        {
            g = canvas.CreateGraphics();

            int x = Convert.ToInt32(xCoorTxtBox.Text);
            int y = Convert.ToInt32(yCoorTxtBox.Text);
            Point p = new Point(x, y);
            DrawPoints(redPen, p);
            points.Add(p);

            start_x = canvas.Width / 2;
            start_y = canvas.Height / 2;

            listBox1.Items.Add($"P{addBtnClicked}- X: {p.X}, Y: {p.Y}");
            addBtnClicked++;
        }

        public void drawLine(Pen pen, Point[] points)
        {
            g.DrawLines(pen, points);
        }
        public Point[] ArrangePoints(Point[] points)
        {
            int minX = points[0].X;
            int maxX = points[0].X;
            int minY = points[0].Y;
            int maxY = points[0].Y;

            for (int i = 0; i < points.Length; i++)
            {
                if (points[i].X < minX) minX = points[i].X;
                if (points[i].X > maxX) maxX = points[i].X;
                if (points[i].Y < minY) minY = points[i].Y;
                if (points[i].Y > maxY) maxY = points[i].Y;
            }

            //central point
            int xCenter = minX + (maxX - minX) / 2;
            int yCenter = minY + (maxY - minY) / 2;
            Point center = new Point(xCenter, yCenter);

            //angle
            angle = new double[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                double numerator = Convert.ToDouble(points[i].X - center.X);

                double denomenator = LineDistance(points[i], center);

                angle[i] = Math.Acos(numerator / denomenator);
                if (points[i].Y > center.Y)
                {
                    angle[i] = 2 * Math.PI - angle[i];
                }
            }
            SortByAngle(angle, points);

            return points;
            
        }
        public double LineDistance(Point p1, Point p2)
        {
            double xDif = p1.X - p2.X;
            double yDif = p1.Y - p2.Y;

            double lineDist = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
            return lineDist;
        }

        private void xCoorTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void SortByAngle(double[] angle, Point[] points)
        {
            for (int i = 0; i < points.Length - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < points.Length - i - 1; j++)
                {
                    if (angle[j].CompareTo(angle[j+1]) > 0)
                    {
                        double tempAngle = angle[j];
                        angle[j] = angle[j + 1];
                        angle[j + 1] = tempAngle;

                        Point tempPoint = points[j];
                        points[j] = points[j + 1];
                        points[j + 1] = tempPoint;

                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }
        
    }
}
