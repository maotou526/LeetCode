using System;

namespace Demo
{
      class Program
      {
            static void Main(string[] args)
            {
                  Console.WriteLine(new Program().LongestPalindrome("babad"));
            }

            public string LongestPalindrome(string s)
            {
                  var res = "";
                  var tempStr = "";
                  var index = 0;
                  var len = s.Length;
                  if (len > 0)
                  {
                        for (int i = 0; i < len; i++)
                        {
                              for (int j = 1; j < len - i + 1; j++)
                              {
                                    tempStr = s.Substring(i, j);
                                    var flag = Validate(tempStr);
                                    if (flag && tempStr.Length > res.Length)
                                    {
                                          res = tempStr;
                                    }
                              }
                        }
                  }
                  return res;
            }
            bool Validate(string s)
            {
                  var len = s.Length / 2;
                  var flag = false;
                  for (int i = 0; i < len; i++)
                  {
                        if (s[i] == s[s.Length - i - 1])
                        {
                              flag = true;
                        }
                        else
                        {
                              flag = false;
                              break;
                        }
                  }
                  return flag;
            }


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
