using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.从前序与中序遍历构造二叉树
{
      public class TreeNode
      {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
      }
      public class Demo
      {
            public TreeNode BuildTree(int[] preorder, int[] inorder)
            {
                  if (preorder.Length == 0 || inorder.Length == 0)
                  {
                        return null;
                  }
                  TreeNode root = new TreeNode(preorder[0]);
                  for (int i = 0; i < preorder.Length; i++)
                  {
                        if (preorder[0] == inorder[i])
                        {
                              root.left = BuildTree(CopyOfRange(preorder, 1, i + 1), CopyOfRange(inorder, 0, i));
                              root.right = BuildTree(CopyOfRange(preorder, i + 1, preorder.Length), CopyOfRange(inorder, i + 1, inorder.Length));
                              break;
                        }
                  }
                  return root;
            }

            public int[] CopyOfRange(int[] arr, int s, int e)
            {
                  var res = new int[e - s];
                  var index = 0;
                  for (int i = s; i < e; i++)
                  {
                        res[index] = arr[i];
                        index++;
                  }
                  return res;
            }
      }
}
