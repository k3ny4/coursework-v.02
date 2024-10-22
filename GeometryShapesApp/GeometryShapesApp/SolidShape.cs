using System;
using System.Drawing;

namespace GeometryShapes
{
    public abstract class SolidShape
    {
        public abstract double CalculateVolume();
        public abstract void Draw(Graphics g, Rectangle bounds);
    }

    public class Cube : SolidShape
    {
        public double SideLength { get; set; }

        public Cube(double sideLength)
        {
            SideLength = sideLength;
        }

        public override double CalculateVolume()
        {
            return Math.Pow(SideLength, 3);
        }

        public override void Draw(Graphics g, Rectangle bounds)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, bounds);
        }
    }

    public class Sphere : SolidShape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Radius = radius;
        }

        public override double CalculateVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }

        public override void Draw(Graphics g, Rectangle bounds)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawEllipse(pen, bounds);
        }
    }

    public class Cone : SolidShape
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public Cone(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public override double CalculateVolume()
        {
            return (1.0 / 3.0) * Math.PI * Math.Pow(Radius, 3) * Height;
        }

        public override void Draw(Graphics g, Rectangle bounds)
        {
            Pen pen = new Pen(Color.Black);
            PointF top = new PointF(bounds.Left + bounds.Width / 2, bounds.Top);
            PointF bottomLeft = new PointF(bounds.Left, bounds.Bottom);
            PointF bottomRight = new PointF(bounds.Right, bounds.Bottom);
            g.DrawLine(pen, top, bottomLeft);
            g.DrawLine(pen, top, bottomRight);
            g.DrawLine(pen, bottomLeft, bottomRight);
        }
    }
}
