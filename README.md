# Depth-First Search Algorithm in C#

This repository contains an implementation of a depth-first search (DFS) algorithm in C#. The DFS algorithm is used to find a path between two nodes in a graph.

## How it Works

The algorithm works by traversing the graph in a depth-first manner, starting from a given source vertex and exploring as far as possible along each branch before backtracking. It uses recursion to explore adjacent vertices and keeps track of visited vertices to avoid revisiting them.

The main components of the algorithm are:

- **Graph**: This class represents the graph using an adjacency list to store the edges between vertices. It provides methods to add edges to the graph and perform the DFS traversal.

- **DFSUtil**: This private method is a helper function that performs the actual DFS traversal. It takes the current vertex, a boolean array to track visited vertices, a list to store the path, the target vertex to find, and a flag to indicate if the path has been found. It recursively explores the adjacent vertices and backtracks if the target vertex is not found.

- **DFS**: This public method initiates the DFS traversal from a given source vertex to a target vertex. It initializes the visited array, path list, and foundPath flag. It calls the DFSUtil method and returns the resulting path, if found.

## Usage

To use the algorithm, follow these steps:

1. Clone this repository or download the source code.

2. Open the solution file in your preferred C# development environment.

3. Inside the `Main` method of the `Program` class, you can modify the graph by adding edges using the `AddEdge` method of the `Graph` class.

4. Set the desired source and target vertices for the DFS traversal.

5. Run the program, and the output will display the path from the source to the target vertex.

## Example

Here's an example of creating a graph and finding a path using the DFS algorithm:

```csharp
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
```

In this example, a graph with five vertices is created, and edges are added between them. The DFS method is called with a source vertex of 2 and a target vertex of 3. The resulting path, if found, is printed to the console.

## License

This project is licensed under the [MIT License](LICENSE).
