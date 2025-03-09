using System;
using System.Collections;
public class Solution {
    public static int MajorityElement(int[] nums) 
    {
        Hashtable hashtable = new Hashtable();
        int majority=0;
        for(int num=0;num<nums.Length;num++)
        {
            if(hashtable.ContainsKey(nums[num]))
            {
               hashtable[nums[num]]=(int)hashtable[nums[num]]+1;
               majority=nums[num]>majority?nums[num]:majority;
            }
            else
               hashtable.Add(nums[num],1);

        }

        return majority;
    }
    public static void Main()
    {
        int[] nums={6,6,6,7,7};
        Console.WriteLine(MajorityElement(nums));

    }
}

