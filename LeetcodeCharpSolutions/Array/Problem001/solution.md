# Problem001 - Two Sum

This class provides two algorithms to solve the Two Sum problem, where given an array of integers `nums` and an integer `target`, return indices of the two numbers such that they add up to `target`.

## TwoSum

### Algorithm

- Initialize a dictionary `hashMap` to store the index of each element.
- Iterate through the array `nums`.
- For each element `nums[i]`, check if `target - nums[i]` exists in `hashMap`.
- If it does, return the indices `[hashMap[target - nums[i]], i]`.
- If it doesn't, add the element to `hashMap`.
- If no such pair is found, return `[0, 0]`.

### Time Complexity

- The time complexity of this algorithm is O(n), where n is the number of elements in the array `nums`.

## TwoSumTwoPointerTech

### Algorithm

- Create a list of tuples `copyNums`, where each tuple contains the index and value of an element in `nums`.
- Sort the `copyNums` list based on the value of the tuples.
- Use two pointers, `i` and `j`, initialized to the start and end of the `copyNums` list, respectively.
- While `i` is less than `j`, check if the sum of `copyNums[i].value` and `copyNums[j].value` is equal to `target`.
  - If it is, return `[copyNums[i].index, copyNums[j].index]`.
  - If it's greater than `target`, decrement `j`.
  - If it's less than `target`, increment `i`.
- If no such pair is found, return `[0, 0]`.

### Time Complexity

- The time complexity of this algorithm is O(n log n) due to the sorting step, where n is the number of elements in the array `nums`.
