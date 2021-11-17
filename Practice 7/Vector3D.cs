using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7
{
    class Vector3D : Triad
    {
        public Vector3D(int first, int second, int third) : base(first, second, third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public static Vector3D operator +(Vector3D firstvector, Vector3D secondvector)
        {
            return new Vector3D(
                firstvector.First + secondvector.First,
                firstvector.Second + secondvector.Second,
                firstvector.Third + secondvector.Third);
        }

        public static int ScalarProduction(Vector3D firstvector, Vector3D secondvector)
        {
            return firstvector.First * secondvector.First + firstvector.Second * secondvector.Second + firstvector.Third * secondvector.Third;
        }

    }
}
