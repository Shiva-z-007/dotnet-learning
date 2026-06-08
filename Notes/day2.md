# DAY 2

## What I Built

### Student Management System Improvements

* Added Update Student feature
* Added Total Students feature
* Improved Search Student output
* Improved View Student functionality

---

## Code Review Learnings

### Student Count

Before:

```csharp
students.Count()
```

After:

```csharp
students.Count
```

Reason:

* Count is a property, not a method.

### Update Student

Removed unnecessary:

```csharp
s.Id = id;
```

Reason:

* Student ID already exists and is not changing.

### Empty List Handling

Learned to handle scenarios where no students exist.

Example:

```csharp
if(students.Count == 0)
{
    Console.WriteLine("No students available.");
}
```

---

## Git Learnings

### Git

Git is a version control system that tracks project changes through commits.

### GitHub

GitHub stores Git repositories and enables collaboration.

### Repository

A folder tracked by Git.

### Commit

A snapshot of the project at a specific point in time.

### Remote

Another Git repository, usually hosted on GitHub.

### Origin

Default alias for the remote repository.

### Push

Uploads local commits to remote repository.

### Pull

Downloads remote changes and merges them locally.

---

## Concepts I Understood Today

### Local Repository vs GitHub

Local Repository:

* Exists on my machine
* Stores commits even when offline

GitHub:

* Stores commits after push
* Used for backup and collaboration

### git add vs git commit

git add:

* Moves changes to staging area

git commit:

* Creates a snapshot inside local repository

### Why git push works without -u now

Because local main branch is already tracking remote origin/main branch.

---

## Problems Faced

* Initially confused about:

  * origin
  * remote
  * branch
  * local repository

### Biggest Realization

Git has four stages:

Working Directory
↓
Staging Area
↓
Local Repository
↓
GitHub Repository

Understanding this made Git easier.

---

## Confidence Level

Git:
7.5/10

C#:
6.5/10

Overall:
7/10

---

## Tomorrow's Goal

* Learn Collections deeply
* Practice Dictionary
* Practice HashSet
* Solve Valid Anagram
* Solve Majority Element
* Improve C# programming fluency
