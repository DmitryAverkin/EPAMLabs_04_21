using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Rectangle
    {
        [Test, TestCaseSource("Dataset")]
        public void TestArea(double x, double y)
        {
            var area = GeometricFigures.Rectangle.GetArea(x, y);
            Assert.AreEqual(x * y, area, $"Ожидаем {x * y}, а в итоге получаем {area}");
        }

        [Test, TestCaseSource("Dataset")]
        public void TestPerimeter(double x, double y)
        {
            var perimeter = GeometricFigures.Rectangle.GetLength(x, y);
            Assert.AreEqual(2 * (x + y), perimeter, $"Ожидаем {2 * (x + y)}, а в итоге получаем {perimeter}");
        }

        static object[] Dataset =
        {
            new object[] {1,2},
            new object[] {3,7},
            new object[] {4,1},
            new object[] {15,12},
            new object[] {14,14},
            new object[] {10,15},
            new object[] {7,8},
            new object[] {18,19},
            new object[] {4,17},
            new object[] {19,18},
            new object[] {10,10},
            new object[] {12,7},
            new object[] {16,2},
            new object[] {1,18},
            new object[] {9,5},
            new object[] {15,14},
            new object[] {19,2},
            new object[] {5,6},
            new object[] {4,11},
            new object[] {7,1},
            new object[] {19,4},
        };
    } 
}
