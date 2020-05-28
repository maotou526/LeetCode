using System;

namespace Demo
{
      class Program
      {
            static void Main(string[] args)
            {
                  Console.WriteLine(new Problems.判断它是否是_2_的幂次方.Demo().IsPowerOfTwo(-16));
                  //new Problems.和可被_K_整除的子数组.Demo().SubarraysDivByK(new int[] { 4, 5, 0, -2, -3, 1 }, 5);
                  //Console.WriteLine(new Program().LongestPalindrome("babad"));
            }

            //public string LongestPalindrome(string s)
            //{
            //      var res = "";
            //      var tempStr = "";
            //      var index = 0;
            //      var len = s.Length;
            //      if (len > 0)
            //      {
            //            for (int i = 0; i < len; i++)
            //            {
            //                  for (int j = 1; j < len - i + 1; j++)
            //                  {
            //                        tempStr = s.Substring(i, j);
            //                        var flag = Validate(tempStr);
            //                        if (flag && tempStr.Length > res.Length)
            //                        {
            //                              res = tempStr;
            //                        }
            //                  }
            //            }
            //      }
            //      return res;
            //}
            //bool Validate(string s)
            //{
            //      var len = s.Length / 2;
            //      var flag = false;
            //      for (int i = 0; i < len; i++)
            //      {
            //            if (s[i] == s[s.Length - i - 1])
            //            {
            //                  flag = true;
            //            }
            //            else
            //            {
            //                  flag = false;
            //                  break;
            //            }
            //      }
            //      return flag;
            //} 
      }
}
