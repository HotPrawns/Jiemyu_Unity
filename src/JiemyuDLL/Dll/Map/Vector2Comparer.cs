﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JiemyuDll.Map
{
    public class Vector2Comparer : IComparer<Vector2>
    {
        public int Compare(Vector2 v1, Vector2 v2)
        {
            return Vector2Comparer.CompareVectors(v1, v2);
        }

        public static int CompareVectors(Vector2 v1, Vector2 v2)
        {
            if (v1.Y == v2.Y)
            {
                return (int)(v1.X - v2.X);
            }

            return (int)(v1.Y - v2.Y);
        }
    }
}
