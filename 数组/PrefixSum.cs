using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    /// <summary>
    /// 前缀和问题
    /// </summary>
    public class PrefixSum
    {
        // 预设查询表
        public static int MethodOne(int l,int r)
        {
            if(l > r) return 0;

            int[] arr = { 2,5,4,7,9,3,6};
            int[,] cache = new int[arr.Length,arr.Length];
            int preSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                preSum = 0;
                for (int j = 0;j < arr.Length;j++)
                {
                    if(i > j)
                    {
                        cache[i,j] = 0;
                    }
                    else
                    {
                        cache[i,j] = preSum + arr[j];
                        preSum = cache[i,j];
                    }
                }
            }
            return cache[l,r];
        }

        // 前缀和
        public static int MethodTwo(int l,int r)
        {
            if (l > r) return 0;
            int[] arr = { 2, 5, 4, 7, 9, 3, 6 };
            int[] preSum = new int[arr.Length];
            int sum = 0;
            for (int i = 0;i < arr.Length;i++)
            {
                preSum[i] = sum + arr[i];
                sum = preSum[i];
            }

            if (l == r)
                return preSum[l];

            return preSum[r]-preSum[l-1];
        }
    }
}
