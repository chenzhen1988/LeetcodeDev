/*
 * Copyright (c) Huawei Technologies Co., Ltd. 2018-2019. All rights reserved.
 * Description:    leetcode_1576_modify_string
 */
#include "gtest/gtest.h"
#include <stdio.h>
#include "leetcode_1576_modify_string.h"

TEST(TEST_LEETCODE_1576_MODIFY_STRING, TEST_01)
{
    char str[] = "?zs";
    char *rst = modifyString(str);
    EXPECT_STREQ(rst, "azs");
}

TEST(TEST_LEETCODE_1576_MODIFY_STRING, TEST_02)
{
    char str[] = "ubv?w";
    char *rst = modifyString(str);
    EXPECT_STREQ(rst, "ubvaw");
}

TEST(TEST_LEETCODE_1576_MODIFY_STRING, TEST_03)
{
    char str[] = "j?qg??b";
    char *rst = modifyString(str);
    EXPECT_STREQ(rst, "jaqgacb");
}

TEST(TEST_LEETCODE_1576_MODIFY_STRING, TEST_04)
{
    char str[] = "??yw?ipkj?";
    char *rst = modifyString(str);
    EXPECT_STREQ(rst, "abywaipkja");
}

TEST(TEST_LEETCODE_1576_MODIFY_STRING, TEST_05)
{
    char str[] = "?";
    char *rst = modifyString(str);
    EXPECT_STREQ(rst, "a");
}

TEST(TEST_LEETCODE_1576_MODIFY_STRING, TEST_06)
{
    char str[] = "abcd?";
    char *rst = modifyString(str);
    EXPECT_STREQ(rst, "abcda");
}
