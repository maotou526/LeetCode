using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.找到数组中消失的数字
{
      //      给定一个范围在  1 ≤ a[i] ≤ n(n = 数组大小) 的 整型数组，数组中的元素一些出现了两次，另一些只出现一次。 
      //找到所有在[1, n] 范围之间没有出现在数组中的数字。 
      //您能在不使用额外空间且时间复杂度为O(n)的情况下完成这个任务吗? 你可以假定返回的数组不算在额外空间内。 
      class Demo
      {
            public IList<int> FindDisappearedNumbers(int[] nums)
            {
                  var list = new List<int>();
                  var length = nums.Length;
                  var dir = new Dictionary<int, int>();
                  for (int i = 0; i < nums.Length; i++)
                  {
                        dir.Add(i + 1, 0);
                  }
                  foreach (var item in nums)
                  {
                        if (dir.ContainsKey(item))
                              dir[item]++;
                  }
                  foreach (var item in dir)
                  {
                        if (item.Value == 0)
                              list.Add(item.Key);
                  }
                  return list;
            }
      }
}
