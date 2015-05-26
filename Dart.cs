using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleDarts
{
    public static class Dart
    {
        public static int Throw(Random dartGenerator)
        {
            int DartValue = dartGenerator.Next(0, 21);
            return DartValue;
        }
    }
}