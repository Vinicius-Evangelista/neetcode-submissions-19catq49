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
    public int MaxDepth(TreeNode root) {
        if (root == null)
            return 0;

        return CountMaxDepth(root, 0);
    }

    public int CountMaxDepth(TreeNode root, int counter) {
        if (root == null)
        {
            return counter;
        }

        counter++;

        return Math.Max(CountMaxDepth(root.right, counter), CountMaxDepth(root.left, counter)); 
    }
}
