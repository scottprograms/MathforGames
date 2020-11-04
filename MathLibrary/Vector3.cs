using System;
using System.Collections.Generic;
using System.Text;
using MathLibrary;

namespace MathLibrary
{
    class Vector3
    {

        private float _x;
        private float _y;
        private float _z;

        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        public float Z
        {
            get
            {
                return _z;
            }
            set
            {
                _z = value;
            }
        }
        public Vector3()
        {
            _x = 0;
            _y = 0;
            _z = 0;

        }

        public Vector3(float x, float y, float z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public static Vector2 operator +(Vector3 lhs, Vector3 rhs)
        {
            float x = lhs.X + rhs.X;
            float y = lhs.Y + rhs.Y;
            float z = lhs.Z + rhs.Z;

            return new Vector2(x, y, z);
        }


        public static Vector3 operator *(Vector3 lhs, float scalar)
        {
            return new Vector3(lhs.X *= scalar, lhs.Y *= scalar, lhs.Z*=scalar);
        }
        public double GetMagnitude()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }
}
