using System;
using System.Collections;
using System.Collections.Generic;

namespace Variables
{
    class Program{
        private static Dictionary<string, string[]> _graph = new Dictionary<string, string[]>();

        static void Main(string[] args)
        {
            _graph.Add("you", new[] { "alice", "bob", "claire" });
            _graph.Add("bob", new[] { "anuj", "peggy" });
            _graph.Add("alice", new[] { "peggy" });
            _graph.Add("claire", new[] { "thom", "jonny" });
            _graph.Add("anuj", Array.Empty<string>());
            _graph.Add("peggy", Array.Empty<string>());
            _graph.Add("thom", Array.Empty<string>());
            _graph.Add("jonny", Array.Empty<string>());
            Search("you");

        }

    }


}
