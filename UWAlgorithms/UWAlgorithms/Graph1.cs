using System;
using System.Collections.Generic;
using System.Threading;

namespace UWAlgorithms
{
    class Vertex
    {
        private String name;
        private LinkedList<Edge> edgeList;

        public Vertex(String name)
        {
            this.name = name;
            edgeList = new LinkedList<Edge>();
        }

        public String getName()
        {
            return name;
        }

        public LinkedList<Edge> getEdges()
        {
            return edgeList;
        }
    }

    class Edge
    {
        private int weight;
        private Vertex destVertex;

        public Edge(Vertex dest, int w)
        {
            this.destVertex = dest;
            this.weight = w;
        }

        /* can use this approach for an unweighted graph
            or better remove variable weight altogether from Edge class */
        public Edge(Vertex dest)
        {
            this.destVertex = dest;
            this.weight = 1;
        }

        public int getWeight()
        {
            return weight;
        }

        public Vertex getDestVertex()
        {
            return destVertex;
        }
    }

    class Graph
    {
        private HashSet<Vertex> nodes;

        public Graph()
        {
            nodes = new HashSet<Vertex>();
        }

        public void AddEdge(Vertex v1, Vertex v2, int weight)
        {
            //since it's a directed graph
           v1.getEdges().AddFirst(new Edge(v2, weight));
            //If you want to implement an undirected graph
            v2.getEdges().AddFirst(new Edge(v1, weight));
        }

        public bool AddVertex(Vertex v)
        {
            return nodes.Add(v);
        }

        public void printGraph()
        {
            //I printed it like this. You can print it however you want though
            foreach (Vertex v in nodes)
            {
                Console.WriteLine("vertex name: " + v.getName() + ": ");
                foreach (Edge e in v.getEdges())
                {
                    Console.WriteLine("destVertex: " + e.getDestVertex().getName() + " weight: " + e.getWeight() + " | ");
                }
                Console.WriteLine("\n");
            }
        }
    }

    public class GraphImplementation
    {
        public static void main(String[] args)
        {
            Graph ourGraph = new Graph();

            //vertices
            Vertex v0 = new Vertex("0");
            Vertex v1 = new Vertex("1");
            Vertex v2 = new Vertex("2");
            Vertex v3 = new Vertex("3");

            ourGraph.AddVertex(v0);
            ourGraph.AddVertex(v1);
            ourGraph.AddVertex(v2);
            ourGraph.AddVertex(v3);

            //edges
            ourGraph.AddEdge(v0, v1, 2);
            ourGraph.AddEdge(v1, v2, 3);
            ourGraph.AddEdge(v2, v0, 1);
            ourGraph.AddEdge(v2, v3, 1);
            ourGraph.AddEdge(v3, v2, 4);

            ourGraph.printGraph();
        }
    }
}
