using System.Collections.Generic;

namespace advent_of_code_day_13_TSP {
    public class Node {
        /*
         * A fairly standard node class with only one exception.
         * It does not need any edges since the order of the nodes are decided by a permutation calculator in the AttendeePermutationHappiness class. And no graph traversal is needed.
         * It instead keeps a dictionary rulebook of all its different happiness rules to all the other nodes.
         */
        public Node(string id) {
            this.Id = id;
            this.rules = new Dictionary<string, int>();
        }
        public string Id { get; set; }

        public Dictionary<string, int> rules {get; set;}
    }
}