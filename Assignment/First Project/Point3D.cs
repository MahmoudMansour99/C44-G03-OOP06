using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.First_Project
{
    internal class Point3D:IComparable<Point3D>, ICloneable
    {
        #region Properties
        public int X { get; }
        public int Y { get; }
        public int Z { get; }
        #endregion

        #region Constructors
        public Point3D() { }
        public Point3D(int x, int y, int z)
        {
            X= x;
            Y= y;
            Z= z;
        }
        public Point3D(Point3D other) : this(other.X, other.Y, other.Z) { }
        #endregion

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
        public static bool operator ==(Point3D left, Point3D right)
        {
            if (left is null && right is null)
                return true;

            if (left is null || right is null )
                return false ;

            return left.X == right.X && left.Y == right.Y && left.Z == right.Z ;
        }
        public static bool operator !=(Point3D left, Point3D right)
        {
            return !(left == right);
        }
        public int CompareTo(Point3D? other)
        {
            if (other is null)
                return 1;

            int result = X.CompareTo(other.X);
            if(result != 0 )
                return result;

            result = Y.CompareTo(other.Y);
            if(result != 0 ) 
                return result;

            return Z.CompareTo(other.Z);
        }

        public object Clone()
        {
            return new Point3D(this);
        }
    }
}
