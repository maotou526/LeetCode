using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.字符串解码
{
      public class Demo
      {
            /// <summary>
            /// 解法链接：https://leetcode-cn.com/problems/decode-string/solution/decode-string-fu-zhu-zhan-fa-di-gui-fa-by-jyd/
            /// </summary>
            /// <param name="s"></param>
            /// <returns></returns>
            public string DecodeString(string s)
            {
                  StringBuilder res = new StringBuilder();
                  int multi = 0;
                  LinkedList<int> stack_multi = new LinkedList<int>();
                  LinkedList<string> stack_res = new LinkedList<string>();
                  foreach (char c in s)
                  {
                        if (c == '[')
                        {
                              stack_multi.AddLast(multi);
                              stack_res.AddLast(res.ToString());
                              multi = 0;
                              res = new StringBuilder();
                        }
                        else if (c == ']')
                        {
                              StringBuilder tmp = new StringBuilder(); 
                              int cur_multi = stack_multi.Last.Value;
                              stack_multi.RemoveLast();
                              for (int i = 0; i < cur_multi; i++) tmp.Append(res);
                              res = new StringBuilder(stack_res.Last.Value + tmp);
                              stack_res.RemoveLast();
                        }
                        else if (c >= '0' && c <= '9')
                              multi = multi * 10 + int.Parse(c + "");
                        else res.Append(c);
                  }
                  return res.ToString();
            }
      }
}
