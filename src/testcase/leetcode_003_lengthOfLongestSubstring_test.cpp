/*
 * Copyright (c) Huawei Technologies Co., Ltd. 2018-2019. All rights reserved.
 * Description:    leetcode_003_lengthOfLongestSubstring
 */
#include "gtest/gtest.h"
#include <stdio.h>
#include "leetcode_003_lengthOfLongestSubstring.h"

TEST(TEST_LEETCODE_003_LENGTHOFLONGESTSUBSTRING, TEST_01)
{
    int result = lengthOfLongestSubstring((char *)"abcabcbb");
    EXPECT_EQ(result, 3);
    // EXPECT_STREQ(r, "5");
}

TEST(TEST_LEETCODE_003_LENGTHOFLONGESTSUBSTRING, TEST_02)
{
    int result = lengthOfLongestSubstring((char *)"bbbbb");
    EXPECT_EQ(result, 1);
    // EXPECT_STREQ(r, "5");
}

TEST(TEST_LEETCODE_003_LENGTHOFLONGESTSUBSTRING, TEST_03)
{
    int result = lengthOfLongestSubstring((char *)"pwwkew");
    EXPECT_EQ(result, 3);
    // EXPECT_STREQ(r, "5");
}

TEST(TEST_LEETCODE_003_LENGTHOFLONGESTSUBSTRING, TEST_04)
{
    int result = lengthOfLongestSubstring((char *)"");
    EXPECT_EQ(result, 0);
    // EXPECT_STREQ(r, "5");
}
