// Given a binary tree t and an integer s, determine whether there is a root to leaf path in t such that the sum of vertex values equals s.

// Example

// For

// t = {
//     "value": 4,
//     "left": {
//         "value": 1,
//         "left": {
//             "value": -2,
//             "left": null,
//             "right": {
//                 "value": 3,
//                 "left": null,
//                 "right": null
//             }
//         },
//         "right": null
//     },
//     "right": {
//         "value": 3,
//         "left": {
//             "value": 1,
//             "left": null,
//             "right": null
//         },
//         "right": {
//             "value": 2,
//             "left": {
//                 "value": -2,
//                 "left": null,
//                 "right": null
//             },
//             "right": {
//                 "value": -3,
//                 "left": null,
//                 "right": null
//             }
//         }
//     }
// }
// and
// s = 7,
// the output should be hasPathWithGivenSum(t, s) = true.

// This is what this tree looks like:

//       4
//      / \
//     1   3
//    /   / \
//   -2  1   2
//     \    / \
//      3  -2 -3
// Path 4 -> 3 -> 2 -> -2 gives us 7, the required sum.

// For

// t = {
//     "value": 4,
//     "left": {
//         "value": 1,
//         "left": {
//             "value": -2,
//             "left": null,
//             "right": {
//                 "value": 3,
//                 "left": null,
//                 "right": null
//             }
//         },
//         "right": null
//     },
//     "right": {
//         "value": 3,
//         "left": {
//             "value": 1,
//             "left": null,
//             "right": null
//         },
//         "right": {
//             "value": 2,
//             "left": {
//                 "value": -4,
//                 "left": null,
//                 "right": null
//             },
//             "right": {
//                 "value": -3,
//                 "left": null,
//                 "right": null
//             }
//         }
//     }
// }
// and
// s = 7,
// the output should be hasPathWithGivenSum(t, s) = false.

// This is what this tree looks like:

//       4
//      / \
//     1   3
//    /   / \
//   -2  1   2
//     \    / \
//      3  -4 -3
// There is no path from root to leaf with the given sum 7.

// Input/Output

// [execution time limit] 3 seconds (cs)

// [input] tree.integer t

// A binary tree of integers.

// Guaranteed constraints:
// 0 ≤ tree size ≤ 5 · 104,
// -1000 ≤ node value ≤ 1000.

// [input] integer s

// An integer.

// Guaranteed constraints:
// -4000 ≤ s ≤ 4000.

// [output] boolean

// Return true if there is a path from root to leaf in t such that the sum of node values in it is equal to s, otherwise return false.

//
// Definition for binary tree:
// class Tree<T> {
//   public T value { get; set; }
//   public Tree<T> left { get; set; }
//   public Tree<T> right { get; set; }
// }
bool hasPathWithGivenSum(Tree<int> t, int s) {
    if (t == null) {
        if (s == 0) { return true; } else { return false; }
    }
    
    return hasPathThatEqualsValue(t, s, 0);
}

bool hasPathThatEqualsValue(Tree<int> t, int s, int current) {
    if (t.left == null && t.right == null && s == current + t.value) {
        return true;
    } else if(t.left != null && hasPathThatEqualsValue(t.left, s, current + t.value)) {
        return true;
    } else if (t.right != null && hasPathThatEqualsValue(t.right, s, current + t.value)) {
        return true;
    }
    return false;
}
