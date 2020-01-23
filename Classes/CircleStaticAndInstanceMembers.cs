using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductionToCSharp.Classes
{
    class CircleStaticAndInstanceMembers
    {
        static float _PI;
        public int _Radius;

        static CircleStaticAndInstanceMembers()
        {
            Console.WriteLine("Initializing a static member field");
            // Initialize the static PI field.
            CircleStaticAndInstanceMembers._PI = 3.142F;
        }

        public CircleStaticAndInstanceMembers(int Radius)
        {
            Console.WriteLine("Initializing an instance member field");
            this._Radius = Radius;
        }

        /// <summary>
        /// Behaviour of the circle includes calculatingArea
        /// </summary>

        public float CalculateCircleArea()
        {
            return CircleStaticAndInstanceMembers._PI * this._Radius * this._Radius;
        }
    }
}
