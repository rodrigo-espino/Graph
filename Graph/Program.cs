namespace Graph;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Graph graph = new Graph(4);

        int i = 1;
        int j = 2;
        int k = 3;
        int l = 4;
        graph.addEdge(i, j);
        graph.addEdge(j, k);
        graph.addEdge(k, l);
        graph.addEdge(j, k);
        graph.addEdge(i, l);


        graph.printAdjacencyList();
        graph.printAdjacencyMatrix();


        bool[] visited = new bool[4];
        graph.printTraversing(1, visited);

    }
}