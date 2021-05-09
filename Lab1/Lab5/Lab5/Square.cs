using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Square
    {
        [Test, TestCaseSource("Dataset")]
        public void TestArea(double x)
        {
            var area = GeometricFigures.Square.GetArea(x);
            Assert.AreEqual(x * x, area, $"Ожидаем {x * x}, а в итоге получаем {area}");
        }

        [Test, TestCaseSource("Dataset")]
        public void TestPerimeter(double y)
        {
            var perimeter = GeometricFigures.Square.GetLength(y);
            Assert.AreEqual(y * 4, perimeter, $"Ожидаем {y * 4}, а в итоге получаем {perimeter}");
        }

        static object[] Dataset =
        {
            new object[] {0},
            new object[] {1},
            new object[] {2},
            new object[] {3},
            new object[] {4},
            new object[] {5},
            new object[] {6},
            new object[] {7},
            new object[] {8},
            new object[] {9},
            new object[] {10},
            new object[] {11},
            new object[] {12},
            new object[] {13},
            new object[] {14},
            new object[] {15},
            new object[] {16},
            new object[] {17},
            new object[] {18},
            new object[] {19},
            new object[] {20},
        };
    }
}
