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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        Stack<TreeNode> st = new Stack<TreeNode>();
		List<int> l1 = new List<int>();
		List<int> l2 = new List<int>();
		st.Push(root1);
		while(st.Count() > 0){
			TreeNode t= st.Pop();
			if(t.left == null && t.right == null) l1.Add(t.val);
			if(t.left!=null) st.Push(t.left);
			if(t.right!=null) st.Push(t.right);
			//st.Pop();
		}
		st.Clear();
		st.Push(root2);
		while(st.Count > 0){
			TreeNode t= st.Pop();
			if(t.left == null && t.right == null) l2.Add(t.val);
			if(t.left!=null) st.Push(t.left);
			if(t.right!=null) st.Push(t.right);
			//st.Pop();
		}
		return l1.SequenceEqual(l2) ;
		
    }
}