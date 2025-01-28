using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06OOP
{

    internal class Point3D : ICloneable, IComparable<Point3D>
    {
        public int Point1 { get; set; }
        public int Point2 { get; set; }
        public int Point3 {  get; set; }
        #region Constrauctots
        //1.Define 3D Point Class and the basic Constructors (use chaining in constructors).
        public Point3D(int point1, int point2, int point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
        }

        public Point3D(int point1) : this(point1, 0, 0)
        {
        }

        public Point3D() : this(0, 0, 0)
        { }
        #endregion

        #region 2.Override the ToString 
        public override string ToString()
        {
            return $"Point Coordinates: ({Point1}, {Point2}, {Point3})";
        }
        #endregion

        #region 4.Try to use  ==
        public static bool operator ==(Point3D p1, Point3D p2)
        {
            return p1.Point1 == p2.Point1 && p1.Point2 == p2.Point2 && p1.Point3 == p2.Point3;
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return p1.Point1 != p2.Point1 && p1.Point2 != p2.Point2 && p1.Point3 != p2.Point3;

        }
        #endregion

        #region 5.Sort Array Using CompareTo
        public int CompareTo(Point3D other)
        {
            int p1Compare = Point1.CompareTo(other.Point1);
            if (p1Compare != 0)
                return p1Compare;
            else
                return Point2.CompareTo(other.Point2);
        }
        #endregion


        #region 6.Clone
        public object Clone()
        {
            return new Point3D()
            {
                Point1 = this.Point1,
                Point2 = this.Point2,
                Point3 = this.Point3
            };
        }
        #endregion

    }
}
