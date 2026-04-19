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
    public List<int> InorderTraversal(TreeNode root) {
        List<int> res = new List<int>();
        void run(TreeNode node) {
            if (node == null) return;
            run(node.left);
            res.Add(node.val);
            run(node.right);
        }

        run(root);
        return res;
    }
}