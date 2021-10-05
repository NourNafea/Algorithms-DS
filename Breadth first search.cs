using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

        private static bool Search(string name)
        {
            var searchQueue = new Queue<string>(_graph[name]);
            var Searched = new List<string>();
            while (searchQueue.Any())
            {
                var Person = searchQueue.Dequeue();
                if (!Searched.Contains(Person))
                {
                    if (PersonIsSeller(Person))
                    {
                        Console.WriteLine($"{Person} is a mango seller");
                        return true;
                    }
                    else
                    {
                        searchQueue = new Queue<string>(searchQueue.Concat(_graph[Person]));
                        Searched.Add(Person);
                    }
                }
            }
            return false;
        }

        private static bool PersonIsSeller(string name)
        {
            return name.EndsWith("e");
        }

    }

}
