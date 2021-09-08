using System;
using System.Collections.Generic;

namespace advent_of_code_day_13_TSP {
    class Program {
        /*
         * This class is the driver of the program. It also takes care of the input handling.
         */
        static void Main(string[] args) {

            Dictionary<string, Node> nodes = new Dictionary<string, Node>();
            AttendeePermutationHappiness p = new AttendeePermutationHappiness();

            System.IO.StreamReader file = new System.IO.StreamReader("input.txt");
            string input = "";

            while ((input = file.ReadLine()) != null) {
                RuleDictator ruleDictator = new RuleDictator();
                ruleDictator.dictateRule(input, nodes);
            }

            string[] a = p.nodesIdToStringArray(nodes);

            p.heapPermutation(a, a.Length, a.Length, nodes);

            Console.WriteLine("Best Permutation: ");
            p.printArray(p.bestPermutation);
            Console.WriteLine("Happiness level: " + p.highestHappiness);
        }
    }
}