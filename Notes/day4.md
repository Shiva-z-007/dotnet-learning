# DAY 4

## What I Built

### Dictionary Practice

Implemented and practiced:

* Add()
* TryGetValue()
* Remove()
* Count
* Dictionary iteration

Used Anime Characters example:

* 101 → Naruto
* 102 → Luffy
* 103 → Ichigo

Learned to:

* Print initial state
* Perform operations
* Verify results
* Print final state

---

## Student Management System

Added / Improved:

### Search By Name

Features:

* Case-insensitive search
* Supports multiple students with same name
* Displays matching student details
* Handles "no student found" scenario

Used:

```csharp
Where(...)
ToList()
StringComparison.OrdinalIgnoreCase
```

---

## DSA Problems Solved

### 1. Ransom Note

Pattern:

Frequency Counting

Used:

```text
Dictionary<char, int>
```

Intuition:

Magazine acts like inventory.

Ransom note consumes inventory.

If a required character is unavailable:

```csharp
return false;
```

Complexity:

Time: O(m + n)

Space: O(m)

---

### 2. Isomorphic Strings

First Attempt:

Used:

```text
Dictionary<char, char>
ContainsValue()
```

Result:

Correct

But:

ContainsValue() = O(n)

Overall Complexity:

O(n²)

---

Optimized Solution:

Used:

```text
Dictionary<char, char> sToT
Dictionary<char, char> tToS
```

Reason:

Enforce one-to-one mapping in both directions.

Complexity:

Time: O(n)

Space: O(n)

---

## Major Learnings

### Dictionary Pattern

Use Dictionary when:

* Counting frequencies
* Mapping relationships
* Fast lookup using keys

Examples:

Frequency:

```text
Character → Count
Product → Quantity
Word → Occurrences
```

Mapping:

```text
EmployeeId → Employee
StudentId → Student
Character → Character
```

---

## Why TryGetValue Instead of dict[key]?

dict[key]:

* Throws exception if key does not exist.

TryGetValue():

* Safer
* Returns boolean
* Prevents KeyNotFoundException

Preferred approach:

```csharp
if(dict.TryGetValue(key, out value))
{
    ...
}
```

---

## Dictionary vs HashSet

Dictionary:

Used when:

* Key → Value relationship exists.
* Frequencies are needed.

Examples:

* Ransom Note
* Valid Anagram
* Isomorphic Strings

HashSet:

Used when:

* Only uniqueness matters.
* Fast Contains() is required.

Examples:

* Contains Duplicate
* Intersection of Arrays
* Find Difference of Arrays

---

## DSA Pattern Recognition

Need uniqueness?

→ HashSet

Need counts/frequencies?

→ Dictionary<T, int>

Need mappings?

→ Dictionary<T1, T2>

Need ordering/index?

→ List / Array

---

## Biggest Realization Today

Don't ask:

"What algorithm should I use?"

Ask:

"What operation am I repeating?"

Examples:

Repeated Contains()

→ HashSet

Repeated Counting

→ Dictionary

Repeated Mapping

→ Dictionary

---

## Reflection

Confidence Levels:

Git: 6/10

C#: 7/10

DSA: 5/10

---

## Improvements From Today

I learned that:

Correct solutions are not always optimal solutions.

Optimization matters.

Example:

Isomorphic Strings

From:

O(n²)

To:

O(n)

using reverse mappings.

---

## What I Need To Improve

* More DSA exposure
* Faster pattern recognition
* Better complexity analysis
* Advanced Git concepts later

---

## Day 4 Conclusion

Today was the day I stopped seeing Dictionary as "just another collection."

I now understand that Dictionary solves two major categories of problems:

1. Frequency Problems
2. Mapping Problems

I also learned to identify inefficiencies and optimize my own solutions.

This is the beginning of thinking like an engineer rather than just writing code.
