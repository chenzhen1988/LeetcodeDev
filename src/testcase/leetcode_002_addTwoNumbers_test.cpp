/*
 * Copyright (c) Huawei Technologies Co., Ltd. 2018-2019. All rights reserved.
 * Description:    leetcode_002_addTwoNumbers
 */
#include "gtest/gtest.h"
#include <stdio.h>
#include "leetcode_002_addTwoNumbers.h"

TEST(TEST_LEETCODE_002_ADDTWONUMBERS, TEST_01)
{
    struct ListNode l1_0;
    struct ListNode l1_1;
    struct ListNode l1_2;
    l1_0.val = 2;
    l1_1.val = 4;
    l1_2.val = 3;
    l1_0.next = &l1_1;
    l1_1.next = &l1_2;
    l1_2.next = NULL;

    struct ListNode l2_0;
    struct ListNode l2_1;
    struct ListNode l2_2;
    l2_0.val = 5;
    l2_1.val = 6;
    l2_2.val = 4;
    l2_0.next = &l2_1;
    l2_1.next = &l2_2;
    l2_2.next = NULL;

    struct ListNode *result = addTwoNumbers(&l1_0, &l2_0);
    EXPECT_EQ(result->val, 7);
    EXPECT_EQ(result->next->val, 0);
    EXPECT_EQ(result->next->next->val, 8);
    EXPECT_EQ(result->next->next->next, (void *)NULL);

    // EXPECT_STREQ(r, "5");
}

