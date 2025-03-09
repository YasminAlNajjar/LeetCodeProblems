using System;
public class PlusOneProblem
{
    public static int[] plusOne(int[] nums)
    {
        int lastNum=nums.Length-1;
        if(nums[lastNum]==9)
        {
            int count=0;
            for(int i=lastNum;i>=0;i--)
            {
                if(nums[i]==9)
                {
                    nums[i]=0;
                    count++;
                }
                else
                {
                    nums[i]+=1;
                    break;
                }                
            }

            if(count==nums.Length)
            {
                int[] newNums={1};
                newNums=newNums.Concat(nums).ToArray();
                return newNums;
            }
        }

        else 
        nums[lastNum]+=1;

        return nums;
    }

    // public static void Main(string[] args)
    // {
    //     int[] arr={1,2,3};
        
    //     foreach(int n in plusOne(arr))
    //     Console.WriteLine(n);

    // }

}
