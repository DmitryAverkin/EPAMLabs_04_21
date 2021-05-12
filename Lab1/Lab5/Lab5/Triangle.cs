using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Triangle
    {
        [Test, TestCaseSource("Dataset")]
        public void TestArea(double x, double y, double z)
        {
            var area = GeometricFigures.Triangle.GetArea(x, y, z);
            var halfMeter = ((x + y + z) / 2);
            var area1 = Math.Sqrt(halfMeter * (halfMeter - x) * (halfMeter - y) * (halfMeter - z));
            Assert.AreEqual(area1, area, $"Ожидаем {area1}, а в итоге получаем {area}");
        }

        [Test, TestCaseSource("Dataset")]
        public void TestPerimeter(double x, double y, double z)
        {
            var perimeter = GeometricFigures.Triangle.GetLength(x,y,z);
            Assert.AreEqual(x+y+z, perimeter, $"Ожидаем {x + y + z}, а в итоге получаем {perimeter}");
        }

        static object[] Dataset =
        {
            new object[] {1,2,3},
            new object[] {4,5,6},
            new object[] {7,8,9},
            new object[] {10,11,12},
            new object[] {13,14,15},
            new object[] {16,17,18},
            new object[] {4,7,2},
            new object[] {6,2,17},
            new object[] {5,5,5},
            new object[] {8,5,3},
            new object[] {18,4,9},
            new object[] {4,7,8},
            new object[] {7,2,12},
            new object[] {15,11,5},
            new object[] {7,5,9},
            new object[] {13,10,10},
            new object[] {13,13,13},
            new object[] {17,18,17},
            new object[] {19,15,14},
            new object[] {9,11,15},
            new object[] {13,15,19},
        };
    }
}
