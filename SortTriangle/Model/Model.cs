using System;

namespace SortTriangle
{
    class Model : IComparable<Model>
    {
        private string name;

        public Model WithName(string name)
        {
            this.name = name;
            return this;
        }

        private double side1;

        public Model WithSide1(double side1)
        {
            this.side1 = side1;
            return this;
        }

        private double side2;

        public Model WithSide2(double side2)
        {
            this.side2 = side2;
            return this;
        }

        private double side3;

        public Model WithSide3(double side3)
        {
            this.side3 = side3;
            return this;
        }

        public double TriangleArea()
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }
        public override string ToString()
        {
            return $"[Triangle {name}]: {Math.Round(TriangleArea(), 2)} cm";
        }

        public int CompareTo(Model triangle)
        {
            if (this.TriangleArea() > triangle.TriangleArea())
            {
                return -1;
            }

            if (this.TriangleArea() < triangle.TriangleArea())
            {
                return 1;
            }

            else
            {
                return 0;
            }

        }
    }
}
