# Binary Search Tree
A simple C# solution to demonstrate the process of inserting into and searching from a Binary Search Tree.

## Mechanism
This program accepts data for a node in the tree as an `object` data-type. It then uses C#'s `.GetHashCode()` method to calculate the hashcode of the data.
If the computed hash code of a child node is less than or equal to the hash code of the parent's data, the tree will traverse left; otherwise the tree will traverse to the right.