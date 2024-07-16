public class Solution {
    public string GetDirections(TreeNode root, int startValue, int destValue) {
        string start = null, dest = null;
        List<char> path = new();
        DFS(root);

        void DFS(TreeNode node) {
            if (start != null && dest != null) return;
            if (node.val == startValue) start = string.Join("", path);
            if (node.val == destValue) dest = string.Join("", path);
            if (node.left != null) {
                path.Add('L');
                DFS(node.left);
                path.RemoveAt(path.Count - 1);
            }
            if (node.right != null) {
                path.Add('R');
                DFS(node.right);
                path.RemoveAt(path.Count - 1);
            }
        }

        // drop common prefix
        int commonPrefixLength = 0;
        while (start.Length > commonPrefixLength &&
               dest.Length > commonPrefixLength &&
               start[commonPrefixLength] == dest[commonPrefixLength])
            commonPrefixLength++;

        // transform start path to Up path and append dest path
        return new string('U', start.Length - commonPrefixLength) + dest[commonPrefixLength..];
    }
}