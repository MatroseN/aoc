# Day 13: Knights of the Dinner Table

## Problem Description
You start by writing up a list of everyone invited and the amount their happiness would increase or decrease if they were to find themselves sitting next to each other person. You have a circular table that will be just big enough to fit everyone comfortably, and so each person will have exactly two neighbors.

## Idéas
### Brute Force*
Check all possible combinations and pick the one with the highest total happiness score.

**Pros:** Ensures that the optimal happiness levels are reached. Pretty simple and straightforward to implement.

**Cons:** The algorithm will grow slower incredibly fast and if the list of attendees grows large it could quickly become too slow. The algorithm would be difficult to repurpose for other similar tasks unless the attendee list is very small.

#### Takeaways
**1.** As long as the attendee list is kept very short the algorithm will work well and will produce a more accurate result than none brute force methods would.

**2.** Can not be used for large amounts of input since it would grow slow really fast and the computing power would have to be extremely greate in order to run the algorithm in a reasonable amount of time (aka it doesn't scale well with the problem it is trying to solve).

**3.** Can be difficult to repurpose for similar problems since it scales so badly.

### Estimation method*
The estimation method does not ensure that the most optimal combination is found. But it will run faster meaning that if it gives a sufficient enough result it could be worth using where the brute force method is inapplicable.

**Pros:** It can run much faster on big inputs than what a brute force method could. Less computing power is needed.

**Cons:** The algorithm will be less accurate than a brute force method meaning that if there is a need for 100% accuracy this is not the solution.

#### Takeaways
**1.** Could be a useful option to use if inputs grow so large that a more accurate brute force method cannot reach a result in a reasonable amount of time.

**2.** Can not be used for large amounts of input since it would grow slow really fast and the computing power would have to be extremely greate in order to run the algorithm in a reasonable amount of time (aka it doesn't scale well with the problem it is trying to solve).

## Method of choice
Since the program must output a 100% accurate result an estimation method cannot be implemented to solve the problem. **Therefore the method of choice is Brute Force**. However the estimation method could be interesting in cases where the brute force method is not applicable, then a decent result from the estimation method would be better than no result from the bruteforce method. This means that there is room for using the brute force method for smaller inputs and the estimation method for larger input sizes if a problem were to arise.
