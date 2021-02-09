/*
 * Copyright (c) Huawei Technologies Co., Ltd. 2018-2019. All rights reserved.
 * Description:    leetcode_002_addTwoNumbers
 */
#include "leetcode_002_addTwoNumbers.h"
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "securec.h"

struct ListNode* addTwoNumbers(struct ListNode* l1, struct ListNode* l2){
    if (l1 == NULL) {
        return l2;
    }
    if (l2 == NULL) {
        return l1;
    }

    struct ListNode preResult;
    struct ListNode *resultMov = &preResult;
    int carry = 0;
    int val = 0;

    while (l1 != NULL || l2 != NULL) {
        if (l1 == NULL) {
            val = (l2->val + carry) % 10;
            carry = (l2->val + carry) >= 10 ? 1 : 0;
            l2->val = val;
            resultMov->next = l2;
            l2 = l2->next;
        } else if (l2 == NULL) {
            val = (l1->val + carry) % 10;
            carry = (l1->val + carry) >= 10 ? 1 : 0;
            l1->val = val;
            resultMov->next = l1;
            l1 = l1->next;
        } else {
            val = (l1->val + l2->val + carry) % 10;
            carry = (l1->val + l2->val + carry) >= 10 ? 1 : 0;
            l1->val = val;
            resultMov->next = l1;
            l1 = l1->next;
            l2 = l2->next;
        }
        resultMov = resultMov->next;
    }
    if (carry) {
        resultMov->next = (struct ListNode *)malloc(sizeof(struct ListNode));
        resultMov->next->val = carry;
        resultMov->next->next = NULL;
    }
    return preResult.next;
}
