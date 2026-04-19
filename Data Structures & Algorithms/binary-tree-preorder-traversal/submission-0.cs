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
    public List<int> PreorderTraversal(TreeNode root) {
        List<int> res = new List<int>();
        Preorder(root, res);
        return res;
    }

    private void Preorder(TreeNode node, List<int> res) {
        if (node == null) return;

        res.Add(node.val);
        Preorder(node.left, res);
        Preorder(node.right, res);
    }
}