namespace LeetcodeCharpSolutions.Array.Problem001
{
    public class Problem001
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> hashMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (hashMap.ContainsKey(target - nums[i]))
                {
                    return new int[] { hashMap[target - nums[i]], i };
                }
                hashMap[nums[i]] = i;
            }

            return new int[] { 0, 0 };
        }

        public int[] TwoSumTwoPointerTech(int[] nums, int target)
        {
            List<(int index, int value)> copyNums = new List<(int index, int value)>();
            for (int i = 0; i < nums.Length; i++)
            {
                copyNums.Add((i, nums[i]));
            }
            copyNums.Sort((x, y) => x.value.CompareTo(y.value));
            for (int i = 0, j = copyNums.Count - 1; i < j;)
            {
                if (copyNums[i].value + copyNums[j].value == target)
                    return new int[] { copyNums[i].index, copyNums[j].index };
                else if (copyNums[i].value + copyNums[j].value > target)
                    j--;
                else
                    i++;

            }

            return new int[] { 0, 0 };
        }
    }
}
