using System;
public class RotateArray{
    public void Rotate(int[] nums, int k)
     {
        if(k==nums.Length)
            return;
        
        k%=nums.Length;
        
        int last=nums.Length-1;
        
        for(int i=0;i<last;i++)
        {
            var temp = nums[i];
            nums[i] = nums[last];
            nums[last] = temp;
            last--;
        }

        last=k-1;

        for(int i=0;i<last;i++)
        {
            var temp = nums[i];
            nums[i] = nums[last];
            nums[last] = temp;
            last--;
        }

        last=nums.Length-1;

        for(int i=k;i<last;i++)
        {
            var temp = nums[i];
            nums[i] = nums[last];
            nums[last] = temp;
            last--;
        }

        
    }
}