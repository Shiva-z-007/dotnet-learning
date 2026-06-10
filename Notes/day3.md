worked on List<T>
and practiced Add , Remove , Containes 

Worked on Dictionary<T,T>
and practiced Add , Remove , ContainsKey , dic.keys

worked on HashSet<T>
and practice Add , Remove , Intersect , Union , Except 


 
Why is Dictionary search usually faster than List search?
//My Answer
because dictionary searches using keys which takes O(1)TC , where as List searches linearly , or using index which takes O(n)TC in worst case

//GPT Answer 
Dictionary search is usually faster because it uses a hash table internally. Given a key, it can locate the value in O(1) average time. In contrast, searching for an element in a List typically requires scanning elements one by one, resulting in O(n) time complexity.

Why does HashSet prevent duplicates?
//My Answer
It has the property of set , which usually accepts only unique numbers

//GPT Answer 
HashSet is designed to store only unique elements. Internally, it uses hashing to determine whether an element already exists. If the element is already present, the duplicate insertion is ignored.

Why did Contains Duplicate become easier with HashSet?
//My Answer
Hashset contains only unique elements , which makes contains duplicate makes easy 

//GPT Answer
HashSet provides O(1) average-time lookup using Contains(). As we iterate through the array, we can quickly check whether an element has already been seen. If it exists in the HashSet, we found a duplicate immediately. This reduces the complexity from O(n²) using nested loops to O(n).

HashSet Pattern:

1. Need unique elements?
→ Think HashSet.

2. Need fast Contains?
→ Think HashSet.

Dictionary Pattern:

1. Need frequencies/counts?
→ Think Dictionary.

List/Array Pattern:

1. Need ordering/index?
→ Think List/Array.