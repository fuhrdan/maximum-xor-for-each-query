//*****************************************************************************
//** 1829. Maximum XOR for Each Query    leetcode                            **
//*****************************************************************************

/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* getMaximumXor(int* nums, int numsSize, int maximumBit, int* returnSize) {
    *returnSize = numsSize;
    int* ans = (int*)malloc(numsSize * sizeof(int));

    int xs = 0;
    for (int i = 0; i < numsSize; ++i) {
        xs ^= nums[i];
    }

    int mask = (1 << maximumBit) - 1;

    for (int i = 0; i < numsSize; ++i) {
        int x = nums[numsSize - i - 1];
        ans[i] = xs ^ mask;
        xs ^= x;
    }

    return ans;
}