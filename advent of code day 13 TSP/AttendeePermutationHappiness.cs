using System;
using System.Collections.Generic;

namespace advent_of_code_day_13_TSP {
    /*
     * This class is responsible for calculating the different permutations of the attendees.
     */ 
    public class AttendeePermutationHappiness {
        public AttendeePermutationHappiness() {
            this.happinessTracker = new HappinessTracker();
        }

        // Creates an array with all the nodeIds (attendee names).
        public string[] nodesIdToStringArray(Dictionary<string, Node> nodes) {
            string[] ids = new string[nodes.Count];
            int index = 0;
            foreach (KeyValuePair<string, Node> entry in nodes) {
                ids[index] = entry.Key;
                index++;
            }
            return ids;
        }

        /* 
         * Calculates all the different permutations of the elements and does this recursivly. Finally when all permutations has been calculated the
         * permutation with the highest calculated happiness level is stored and then returned.
         */
        public string[] heapPermutation(string[] elements, int size, int n, Dictionary<string, Node> nodes) {
            // When the input size only is one the permutation is calculated
            if (size == 1) {
                int tempHappiness = happinessTracker.happinessOfNodes(elements, nodes);
                if (tempHappiness > highestHappiness) {
                    bestPermutation = elements;
                    highestHappiness = tempHappiness;
                }
            }

            for (int i = 0; i < size; i++) {
                heapPermutation(elements, size-1, n, nodes);

                if (size % 2 == 1) {
                    string temp = elements[0];
                    elements[0] = elements[size - 1];
                    elements[size - 1] = temp;
                }
                else {
                    string temp = elements[i];
                    elements[i] = elements[size - 1];
                    elements[size - 1] = temp;
                }
            }
            return bestPermutation;
        }

        public void printArray(string[] elements) {
            foreach (string s in elements) {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }

        public string[] bestPermutation { get; set; }
        public int highestHappiness { get; set; }
        private HappinessTracker happinessTracker;
    }
}