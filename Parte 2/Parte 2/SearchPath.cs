using System;
using System.Collections.Generic;
using System.Text;

namespace Parte_2
{

    class Node
    {
        public bool isExplored = false;
        public Node isExploredFrom;

        public int X { get; set; }
        public int Y { get; set; }

        public Node(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    struct Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    class SearchPath
    {
        private static Dictionary<Vector, Node> block = new Dictionary<Vector, Node>();
    }
}
