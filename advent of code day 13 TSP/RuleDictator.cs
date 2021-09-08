using System;
using System.Collections.Generic;

namespace advent_of_code_day_13_TSP {
    public class RuleDictator {
        /*
         * This class is responsible for the creation and application of rules.
         * The rules are taken as input and are then deducted from the input and added to the relevant nodes.
         */
        public void dictateRule(string rule, Dictionary<string, Node> nodes) {
            string targetId = "";
            string oposingTargetId = "";
            int number = 0;
            string[] words = rule.Split(" ");

            targetId = words[0];
            nodes.TryAdd(targetId, new Node(targetId));
            oposingTargetId = words[words.Length - 1];
            oposingTargetId = oposingTargetId.Remove(oposingTargetId.Length - 1, 1);
            number = Int32.Parse(words[3]);

            // When the rule says that the target should lose hapiness points convert the number to negative.
            if (words[2].Equals("lose")) {
                number *= -1;
            }

            Node targetNode = nodes[targetId];
            // Adds the rule to the relevant nodes rule dictionary
            targetNode.rules.Add(oposingTargetId, number);
        }
    }
}