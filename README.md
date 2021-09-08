# Explanation of implementation

## Input
Since the input consists of many lines of written rules for every attendee against all other attendees it is best to take input from a text file instead of reading console inputs. The input is taken line by line and is then handled by the RuleDictator class.

## RuleDictator
The rule dictator takes the input and deducts rules from the given input. A rule can look like this for example:

`Alice would gain 54 happiness units by sitting next to Bob.`

The rule dictator splits the input string into a string array of words. Since all the input lines have the same structure the only thing interesting from the array is what attendee the rule is about if the happiness should be negative or positive and also who the rule is referring to. This information is grabbed simply from the newly created array of words by choosing the first word, the last word minus the "." and also checking the 3dr word to decide if the happiness should be negative or positive. Then finally the 4th word is grabbed from the array and used as the amount of happiness to ether gain or lose.

If the attendee the rule is about is not present in the attendee dictionary they are added to it. And also the rule deducted is added to the attendee by inserting it into a dictionary where they store all the rules for all other attendees.

## AttendeePermutationHappiness
Next comes the class that takes the attendees and calculates all the permutations. First an array with all the attendees names has to be created so that it is easier to perform the permutation calculation. Then the permutations are calculated.

### Permutations
Since the problem is to find the best seating arrangement all the possible seating arrangements has to be tried. A way of doing this is to calculate all the permutations using heaps permutation algorithm. When a permutation is found the total happiness score is calculated by the HappinessTracker and the permutation with the best happiness score is stored and eventually returned.

## HappinessTracker
The happiness tracker goes through all the attendees of the current permutation and checks their happiness score based on the rules that each attendee is keeping. Then since the table is round the first and last elements of the permutation has to be checked against each other and their happiness scores has to be calculated. Then the happiness score is returned.

## Output
In the end the permutation with the best total happiness is printed and also the happiness score. 
