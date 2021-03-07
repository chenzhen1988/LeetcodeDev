/*
 * Copyright (c) ChenZhen Co., Ltd. 2021-2021. All rights reserved.
 * Description:    leetcode_002_addTwoNumbers
 */
#ifndef _LEETCODE_002_ADDTWONUMBERS_H_
#define _LEETCODE_002_ADDTWONUMBERS_H_

#include "stdbool.h"

/**
  * @addtogroup LEETCODE_DEV_SRC
  * @{
  */

/**
  * @brief  A link list.
  * 
  */
struct ListNode {
    int val;                /*!< Value of the node. */
    struct ListNode *next;  /*!< The next node. */
};

/**
  * @brief  Add the two numbers which are given in list.
  * 
  * @param  l1 The first param.
  * @param  l2 The second param.
  * @return struct ListNode* The result link list.
  */
struct ListNode* addTwoNumbers(struct ListNode* l1, struct ListNode* l2);

/**
  * @}
  */

#endif
