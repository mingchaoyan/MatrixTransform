using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MatrixTransform
{
    class Triangle
    {
        PointF A, B, C;
        public Triangle(PointF A, PointF B, PointF C) {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public void Draw(Graphics g) {
            Pen pen = new Pen(Color.Red, 2);
            g.DrawLine(pen, A, B);
            g.DrawLine(pen, B, C);
            g.DrawLine(pen, C, A);
        }

        public void Rotate(int degree) {
            A = MatrixMul(A, degree);
            B = MatrixMul(B, degree);
            C = MatrixMul(C, degree);
        }

        private PointF MatrixMul(PointF A, int degree) { 
            float angle = (float)(degree / 360.0f * Math.PI);
            float newX = (float)(A.X * Math.Cos(angle) - A.Y * Math.Sin(angle));
            float newY = (float) (A.X * Math.Sin(angle) + A.Y * Math.Cos(angle));
            return new PointF(newX, newY);
        }
    }
}
