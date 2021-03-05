/*
 * Copyright (c) Huawei Technologies Co., Ltd. 2018-2019. All rights reserved.
 * Description:    leetcode_459_repeated_substring_pattern
 */
#include "gtest/gtest.h"
#include <stdio.h>
#include "leetcode_459_repeated_substring_pattern.h"

TEST(TEST_LEETCODE_459_REPEATED_SUBSTRING_PATTERN, TEST_01)
{
    char *str = (char *)"abab";
    EXPECT_TRUE(repeatedSubstringPattern(str));
    // EXPECT_STREQ(r, "5");
}

TEST(TEST_LEETCODE_459_REPEATED_SUBSTRING_PATTERN, TEST_02)
{
    char *str = (char *)"aba";
    EXPECT_FALSE(repeatedSubstringPattern(str));
    // EXPECT_STREQ(r, "5");
}

TEST(TEST_LEETCODE_459_REPEATED_SUBSTRING_PATTERN, TEST_03)
{
    char *str = (char *)"abcabcabcabc";
    EXPECT_TRUE(repeatedSubstringPattern(str));
    // EXPECT_STREQ(r, "5");
}
