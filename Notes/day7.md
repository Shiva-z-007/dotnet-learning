# DAY 7

# what is LIFO?
LIFO stands for Last In First Out.

The last element added to the stack is the first element removed from the stack.

Stack<T> follows the LIFO principle.

Example:

Push A
Push B
Push C

Pop()

Output: C

Because C was inserted last.

# Difference Between Stack and Queue

Stack follows LIFO (Last In First Out).

Queue follows FIFO (First In First Out).

Stack Example:

Push A
Push B
Push C

Pop()

Output: C

Queue Example:

Enqueue A
Enqueue B
Enqueue C

Dequeue()

Output: A

# When Should i use stack

Use Stack when the most recently added item needs to be processed first.

Common situations:

- Undo functionality
- Browser back navigation
- Valid Parentheses problems
- Expression evaluation
- Backtracking algorithms
- Function call stack

A Stack is useful whenever the latest operation or item is the most important one.

# why does valid parentheses use stack

Valid Parentheses uses a Stack because every closing bracket must match the most recent unmatched opening bracket.

When an opening bracket appears:

Push it into the stack.

When a closing bracket appears:

Compare it with the top element of the stack.

If they match:

Pop the opening bracket.

Otherwise:

The string is invalid.

Stack works perfectly because the latest opening bracket must be matched first.


# Real-world examples of Stack 

Real-world examples of Stack:

- Undo (Ctrl + Z)
- Browser Back button
- Text editor history
- Function call stack
- Expression evaluation
- Compiler parsing
- Backtracking problems

All of these require the most recent action to be processed first.


## What I Learned Today

Today I learned about the Stack data structure and the Stack pattern used in DSA.

The most important concept learned today was:

LIFO (Last In First Out)

Stack processes the most recently added item first.

---

# Stack

A Stack is a collection that follows the LIFO principle.

LIFO means:

Last In First Out

Example:

Push A
Push B
Push C

Pop()

Output:

C

Because C was inserted last.

---

# Stack Operations

## Push()

Adds an item to the top of the stack.

Example:

stack.Push("Naruto");

---

## Pop()

Removes and returns the top element.

Example:

stack.Pop();

---

## Peek()

Returns the top element without removing it.

Example:

stack.Peek();

---

## Count

Returns the total number of elements.

Example:

stack.Count

---

## Contains()

Checks whether an element exists.

Example:

stack.Contains("Naruto")

---

# Difference Between Stack and Queue

Stack:

LIFO

Last In First Out

Example:

Push A
Push B
Push C

Pop()

Output:

C

---

Queue:

FIFO

First In First Out

Example:

Enqueue A
Enqueue B
Enqueue C

Dequeue()

Output:

A

---

# When Should I Use Stack?

Use Stack when the most recently added item needs to be processed first.

Common situations:

- Undo functionality
- Browser Back button
- Valid Parentheses
- Expression evaluation
- Function call stack
- Backtracking algorithms

---

# Undo System

Implemented a simple Undo system using Stack.

Example:

Type A
Type B
Type C

Undo()

Output:

C

Undo()

Output:

B

Undo()

Output:

A

Reason:

The latest action should be undone first.

---

# DSA

## Valid Parentheses

Problem:

LeetCode 20

Pattern:

Stack

Approach:

When opening bracket appears:

Push into stack.

When closing bracket appears:

Compare with top of stack.

If matched:

Pop.

Otherwise:

Invalid.

Learned:

The latest opening bracket must be matched first.

This is why Stack is the ideal data structure.

Complexity:

Time: O(n)

Space: O(n)

---

## Baseball Game

Problem:

LeetCode 682

Pattern:

Stack

Approach:

Maintain previous scores using Stack.

Operations depend on recent history.

Examples:

+
D
C

Learned:

Whenever a problem depends on previous operations, Stack is often useful.

Complexity:

Time: O(n)

Space: O(n)

---

# Pattern Recognition Summary

## HashSet

Use when:

- Uniqueness
- Duplicate detection

Examples:

- Contains Duplicate
- Intersection of Arrays

---

## Dictionary

Use when:

- Frequency counting
- Mapping
- Fast lookup

Examples:

- Ransom Note
- Top K Frequent Elements
- Find The Difference

---

## Two Pointers

Use when:

- Opposite ends
- Sorted arrays
- Palindromes

Examples:

- Valid Palindrome
- Merge Sorted Array

---

## Stack

Use when:

- History
- Undo
- Backtracking
- Nested structures
- Matching brackets

Examples:

- Valid Parentheses
- Baseball Game

---

# Reflection

Strongest Pattern:

Dictionary

Reason:

I can quickly identify frequency problems and solve them using Dictionary.

---

Pattern Needing More Practice:

Stack

I understand the concept but need more exposure to different Stack-based problems.

---

# Confidence Levels

Git : 8/10

C# : 8/10

DSA : 7/10

Collections : 9/10

LINQ : 9.5/10

---

# Biggest Realization Today

A Stack is not just a collection.

It represents a way of thinking:

The most recent action should be processed first.

Whenever I see:

- Undo
- History
- Matching brackets
- Backtracking

I should immediately think:

STACK

---

# Day 7 Conclusion

Today I learned:

- Stack fundamentals
- LIFO principle
- Undo systems
- Valid Parentheses pattern
- Baseball Game pattern
- When to use Stack in real-world applications

DAY 7 STATUS: COMPLETED ✅🔥🚀