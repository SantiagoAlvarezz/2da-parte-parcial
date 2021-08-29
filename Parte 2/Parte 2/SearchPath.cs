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
        private static Node startingPoint = new Node(0, 0);
        private static Node endingPoint = new Node(2, -2);
        private static Node searchingPoint;
        private static bool isExploring = true;                       // If we are end then it is set to false

        private static List<Node> path = new List<Node>();            // For storing the path traversed

        private static Dictionary<Vector, Node> block = new Dictionary<Vector, Node>();
        private static Queue<Node> queue = new Queue<Node>();

        static int[,] maze = { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 }, { 0, 0, 1 }};
        static int[][] directions = new int[4][];

        public static void CreateMaze()
        {
            block.Add(new Vector(0, 0), startingPoint);
            block.Add(new Vector(1,0), new Node(1, 0)); 
          //block.Add(new Vector(2, 0), new Node(2, 0));
            block.Add(new Vector(0, -1), new Node(0, -1));
            //block.Add(new Vector(1, -1), new Node(1, -1));
            block.Add(new Vector(2, -1), new Node(2, -1));
            block.Add(new Vector(0, -2), new Node(0, -2));
            block.Add(new Vector(1, -2), new Node(1, -2));
            block.Add(new Vector(2, -2), new Node(2, -2));
            //block.Add(new Vector(0, -3), new Node(0, -3));
            block.Add(new Vector(1, -3), endingPoint);
            //block.Add(new Vector(2, -3), new Node(2, -3));

        }

        public static void BFS()
        {
            queue.Enqueue(startingPoint);
            while (queue.Count > 0 && isExploring)
            {
                searchingPoint = queue.Dequeue();
               // OnReachingEnd();
                //ExploreNeighbourNodes();

            }
        }


    }
}
