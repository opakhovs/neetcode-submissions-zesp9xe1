public class TreeNode {
    public int Key;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int key) {
        Key = key;
        Left = null;
        Right = null;
    }
}

public class BST {
    public TreeNode Root;

    public TreeNode Insert(TreeNode root, int key) {
        if (root == null) return new TreeNode(key);

        if (key < root.Key) {
            root.Left = Insert(root.Left, key);
        } else if (key > root.Key) {
            root.Right  = Insert(root.Right , key);
        }
        return root;
    }

    public TreeNode Delete(TreeNode root, int key) {
        if (root == null) return null;
        if (key < root.Key) {
            root.Left = Delete(root.Left, key);
        } else if (key > root.Key) {
            root.Right = Delete(root.Right, key);
        } else {
            if (root.Left == null) return root.Right;
            if (root.Right == null) return root.Left;
            TreeNode temp = MinValueNode(root.Right);
            root.Key = temp.Key;
            root.Right = Delete(root.Right, temp.Key);
        }
        return root;
    }

    private TreeNode MinValueNode(TreeNode root) {
        while (root.Left != null)
            root = root.Left;
        return root;
    }

    public bool Search(TreeNode root, int key) {
        if (root == null) return false;
        if (key == root.Key) return true;
        if (key < root.Key) return Search(root.Left, key);
        return Search(root.Right, key);
    }

    public void Add(int key) {
        Root = Insert(Root, key);
    }

    public void Remove(int key) {
        Root = Delete(Root, key);
    }

    public bool Contains(int key) {
        return Search(Root, key);
    }
}

public class MyHashSet {
    private BST bucket;

    public MyHashSet() {
        
    }
    
    public void Add(int key) {
        if (bucket == null) {
            bucket = new BST();
        }
        bucket.Add(key);
    }
    
    public void Remove(int key) {
        if (bucket == null) {
            bucket = new BST();
        }
        bucket.Remove(key);
        
    }
    
    public bool Contains(int key) {
        if (bucket == null) {
            bucket = new BST();
        }
        return bucket.Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */