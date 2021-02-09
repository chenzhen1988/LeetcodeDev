/*
 * Copyright (c) Huawei Technologies Co., Ltd. 2018-2019. All rights reserved.
 * Description:    leetcode_002_addTwoNumbers
 */
#ifndef _LEETCODE_002_ADDTWONUMBERS_H_
#define _LEETCODE_002_ADDTWONUMBERS_H_

#include "stdbool.h"

struct ListNode {
    int val;
    struct ListNode *next;
};

struct ListNode* addTwoNumbers(struct ListNode* l1, struct ListNode* l2);

#endif
