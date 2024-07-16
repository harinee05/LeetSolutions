/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode CreateBinaryTree(int[][] descriptions) {
        var nodes = new Dictionary<int, TreeNode>();
        var children = new HashSet<int>();

        foreach (var description in descriptions) {
            int parentVal = description[0];
            int childVal = description[1];
            bool isLeft = description[2] == 1;

            if (!nodes.TryGetValue(parentVal, out var parent)) {
                parent = new TreeNode(parentVal);
                nodes[parentVal] = parent;
            }

            if (!nodes.TryGetValue(childVal, out var child)) {
                child = new TreeNode(childVal);
                nodes[childVal] = child;
            }

            if (isLeft) {
                parent.left = child;
            } else {
                parent.right = child;
            }

            children.Add(childVal);
        }

        // Find the root: it's the one node that isn't a child
        TreeNode root = null;
        foreach (var node in nodes.Values) {
            if (!children.Contains(node.val)) {
                root = node;
                break;
            }
        }

        return root;
    }
}