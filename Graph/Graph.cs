using System;
namespace Graph
{
    public class Graph
    {
        
        public int[,] matrix;
        public int size;

        public Graph(int size)
        {
            this.size = size;
            matrix = new int[size, size];
        }
        public void addEdge(int i, int j)
        {
            matrix[i, j] = 1;
            matrix[j, i] = 1;
        }
        public void removeEdge(int i, int j)
        {
            matrix[i, j] = 0;
            matrix[j, i] = 0;
        }
        public void print()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void printAdjacencyList()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(i + ": ");
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        Console.Write(j + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void printAdjacencyMatrix()
        {
            Console.Write("   ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(i + " ");
                if (i == size - 1)
                {
                    Console.WriteLine();
                }
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write(i + ": ");
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void printTraversing(int i, bool[] visited)
        {
            visited[i] = true;
            Console.Write(i + " ");
            for (int j = 0; j < size; j++)
            {
                if (matrix[i, j] == 1 && !visited[j])
                {
                    printTraversing(j, visited);
                }
            }
        }
    }
}

