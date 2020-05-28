using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.判断它是否是_2_的幂次方
{
     public class Demo
      {
            public bool IsPowerOfTwo(int n)
            {
                  if (n < 0)
                        return false;
                  var s = Convert.ToString(n, 2); 
                  return s.Replace("0", "").Length == 1; 
            }
      }
}

