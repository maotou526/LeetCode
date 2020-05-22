using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.判断字符是否唯一
{
      public class Demo
      {
            public bool IsUnique(string astr)
            {
                  var temp = string.Empty;
                  foreach (var item in astr)
                  {
                        if (temp.IndexOf(item) > -1)
                              return false;
                        temp += item;
                  }
                  return true;
            }
      }
}
