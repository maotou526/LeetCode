using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.和可被_K_整除的子数组
{
      //给定一个整数数组 A，返回其中元素之和可被 K 整除的（连续、非空）子数组的数目。
      //输入：A = [4,5,0,-2,-3,1], K = 5
      //输出：7
      //解释：
      //有 7 个子数组满足其元素之和可被 K = 5 整除：
      //[4, 5, 0, -2, -3, 1], [5], [5, 0], [5, 0, -2, -3], [0], [0, -2, -3], [-2, -3]

      public class Demo
      {
            public int SubarraysDivByK(int[] A, int K)
            {
                  int count = 0;
                  if (A.Length > 0)
                  {
                        for (int i = 0; i < A.Length; i++)
                        {
                              count += Validate(A, K, i);
                        }
                  }
                  return count;
            }

            public int Validate(int[] A, int K, int Index)
            {
                  var count = 0;
                  var len = A.Length;
                  decimal sum = 0;
                  for (int i = len - 1; i >= Index; i--)
                  {
                        sum += A[i];
                  }
                  while (len > Index)
                  { 
                        if (sum % K == 0)
                              count++;
                        len--;
                        sum -= A[len];
                  }
                  return count;
            }
      }
}
