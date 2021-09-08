using System.Collections.Generic;

namespace advent_of_code_day_13_TSP {
    public class HappinessTracker {

        /* 
         * Calculates the happiness level of the active permutation.
         * First it checks the center elements happiness rules and adds the happiness points to the total hapiness score.
         * Then since the table is round it checks the first element in the permutation array against the last element to get their happiness score.
         */
        public int happinessOfNodes(string[] permutation, Dictionary<string, Node> nodes) {
            int happiness = 0;
            for (int i = 1; i < permutation.Length -1; i++) {
                Node node = nodes[permutation[i]];
                string leftId = permutation[i - 1];
                string rightId = permutation[i + 1];

                happiness += node.rules[leftId];
                happiness += node.rules[rightId];
            }

            Node FirstNode = nodes[permutation[0]];
            Node LastNode = nodes[permutation[permutation.Length - 1]];

            string firstLeft = permutation[permutation.Length - 1];
            string firstRight = permutation[0 + 1];

            happiness += FirstNode.rules[firstLeft];
            happiness += FirstNode.rules[firstRight];


            string lastLeft = permutation[permutation.Length - 2];
            string lastRight = permutation[0];

            happiness += LastNode.rules[lastLeft];
            happiness += LastNode.rules[lastRight];

            return happiness;
        }
    }
}
