# Tower of Hanoi Report

Problem explanation: https://en.wikipedia.org/wiki/Tower_of_Hanoi

## Recursive Solution
The recursive approach follows a divide-and-conquer strategy by breaking the problem into smaller subproblems:

### Algorithm
1. Move `n-1` disks from the source rod to an auxiliary rod.

2. Move the largest disk directly to the target rod.

3. Move the `n-1` disks from the auxiliary rod to the target rod.

### Implementation
- The `HanoiUsingRecursion` function recursively moves `n-1` disks to the auxiliary rod before moving the nth disk to the target rod.

- It then moves the `n-1` disks from the auxiliary rod to the target rod.

- The recursion halts when `n == 0`.

## Iterative Solution
The iterative approach follows a predefined set of moves that ensure proper order of disk movements using the stack data structure.

### Algorithm
1. Determine the auxiliary and target rods based on whether `n` is even or odd, so that disks end up on the 3rd rod in the end.

2. Use a stack-based approach to store the rods and their disks.

3. Follow a cyclic movement pattern, while ensuring legal moves:

    - Move between source and target.

    - Move between source and auxiliary.

    - Move between auxiliary and target.

4. Repeat until all disks are moved to the target rod.

### Implementation
- A stack-based approach is used to represent the three rods.

- The algorithm follows a sequence of legal moves until all disks reach the target rod.

- The auxiliary rod and end rod for calculations is chosen based on whether n is even or odd, so that at the end, all disks end up on the 3rd rod, independent of the number of disks.

- The loop ensures that disks are moved in the correct order without violating the rules and without moving disks back and forth.