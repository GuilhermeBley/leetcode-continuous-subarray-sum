
var nums = new int[] { 1, 2, 12 };
var k = 6;

var result = new Solution().CheckSubarraySum(nums, k);

Console.WriteLine(result);

public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {

        if(nums.Length < 2)
            return false;

        // A list of the sum of the rests to analyze.
        HashSet<int> sumRests = new();
        int previousRest = 0;
        int sumRest = 0;

        for (int idx = 0; idx < nums.Length; idx++) 
        {
            sumRest += nums[idx];
            var rest = sumRest % k;

            //
            // If the rest was already storaged, it means that a consequent sum was found.
            //
            if (sumRests.Contains(rest))
            {
                return true;
            }

            //
            // Doing the sum of the previous, it's necessary to storage the first element in case of the result being all the list.
            //
            sumRests.Add(previousRest);
            previousRest = rest;
        }

        return false;
    }
}