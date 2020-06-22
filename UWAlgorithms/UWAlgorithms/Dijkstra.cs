using System;
using System.Collections.Generic;

namespace UWAlgorithms
{
    public class Edge : IComparable<Edge>
    {
        private readonly int _v1;
        private readonly int _v2;
        private readonly double _weight;

        public Edge(int v1, int v2, int weight)
        {
            _v1 = v1;
            _v2 = v2;
            _weight = weight;
        }

        public double Weight()
        {
            return _weight;
        }

        public int CompareTo(Edge e)
        {
            if (this.Weight() < e.Weight())
            {
                return -1;
            }
            else if (this.Weight() > e.Weight())
            {                
                return +1;
            }
            else
            {
                return 0;
            }
        }

        public int Source()
        {
            return _v1;
        }

        public int Target(int vertex)
        {
            if (vertex == _v1)
            {
                return _v2;
            }
            else if (vertex == _v2)
            {
                 return _v1;
            }
            else
            {
                throw new Exception("bad target");
            }
        }
        public String toString()
        {
            return  $"{_v1},--{_v2}, {_weight}";
        }
    }

    public class EdgeWeightedGraph
    {
        private readonly int _v;
        private int _e;
        private LinkedList<Edge>[] _adj;

        public EdgeWeightedGraph(int V)
        {
            if (V < 0) 
            { 
                throw new Exception("Vertices must be > 0");
            }

            this._v = V;

            this._e = 0;

            _adj = new LinkedList<Edge>[V];

            for (int v = 0; v < V; v++)
            {
                _adj[v] = new LinkedList<Edge>();
            }
        }

        public int V()
        {
            return _v;
        }

        public int E()
        {
            return _e;
        }

        public void AddEdge(Edge e)
        {
            int v = e.Source();
            int w = e.Target(v);
            _adj[v].AddFirst(e);
            _adj[w].AddFirst(e);
            _e++;
        }

        public IEnumerable<Edge> Adj(int v)
        {
            return _adj[v];
        }

        public IEnumerable<Edge> Edges()
        {
            LinkedList<Edge> list = new LinkedList<Edge>();

            for (int v = 0; v < _v; v++)
            {
                int iterations = 0;

                foreach (Edge e in Adj(v))
                {
                    if (e.Target(v) > v)
                    {
                        list.AddFirst(e);
                    }

                    else if (e.Target(v) == v)
                    {
                        if (iterations % 2 == 0)
                            list.AddFirst(e);
                        iterations++;
                    }
                }
            }

            return list;
        }
    }
}
