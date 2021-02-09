/*
 * Copyright (c) Huawei Technologies Co., Ltd. 2018-2019. All rights reserved.
 * Description:    leetcode_001_twoSum
 */
#include "gtest/gtest.h"
#include <stdio.h>
#include "leetcode_001_twoSum.h"

TEST(TEST_LEETCODE_001_TWOSUM, TEST_01)
{
    int nums[] = {2, 7, 11, 15};
    int target = 9;
    int returnSize = 0;
    int *result = twoSum(nums, sizeof(nums) / sizeof(int), target, &returnSize);
    EXPECT_EQ(returnSize, 2);
    EXPECT_EQ(result[0], 0);
    EXPECT_EQ(result[1], 1);
    // EXPECT_STREQ(r, "5");
}

