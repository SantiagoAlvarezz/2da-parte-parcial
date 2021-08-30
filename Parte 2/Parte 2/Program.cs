using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            SearchPath.CreateMaze();
            SearchPath.BFS();
            SearchPath.CreatePath();
            SearchPath.Imprimir();
            s.Stop();
            Console.WriteLine("Breadth-first search took " + s.ElapsedMilliseconds + " ms");
            Console.WriteLine();
        }
    }
}
