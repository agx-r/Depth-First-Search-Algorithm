using System;
using System.Collections.Generic;

class Graph
{
    private int V; // Number of vertices
    private List<int>[] adj; // Adjacency list

    public Graph(int vertices)
    {
        V = vertices;
        adj = new List<int>[V];
        for (int i = 0; i < V; ++i)
            adj[i] = new List<int>();
    }

    // Function to add an edge to the graph
    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    // DFS traversal of the vertices reachable from v
    private void DFSUtil(int v, bool[] visited, List<int> path, int target, ref bool foundPath)
    {
        visited[v] = true;
        path.Add(v);

        if (v == target)
        {
            foundPath = true;
            return;
        }

        foreach (int i in adj[v])
        {
            if (!visited[i])
                DFSUtil(i, visited, path, target, ref foundPath);
            
            if (foundPath)
                return;
        }

        path.Remove(v);
        visited[v] = false;
    }

    // DFS traversal from a given source vertex to a target vertex
    public List<int> DFS(int source, int target)
    {
        bool[] visited = new bool[V];
        List<int> path = new List<int>();
        bool foundPath = false;

        DFSUtil(source, visited, path, target, ref foundPath);

        return path;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Graph graph = new Graph(5);

        // Add edges to the graph
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 2);
        graph.AddEdge(2, 0);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 3);

        int source = 2;
        int target = 3;

        List<int> path = graph.DFS(source, target);

        Console.WriteLine("Path from {0} to {1}: ", source, target);
        foreach (int vertex in path)
        {
            Console.Write(vertex + " ");
        }
        Console.WriteLine();
    }
}
