/*
 * Copyright (c) Huawei Technologies Co., Ltd. 2018-2019. All rights reserved.
 * Description:    leetcode_459_repeated_substring_pattern
 */
#include "leetcode_459_repeated_substring_pattern.h"
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "securec.h"

bool repeatedSubstringPattern(char * s){
    int n = strlen(s);
    char k[2 * n + 1];
    k[0] = 0;
    strcat(k, s);
    strcat(k, s);
    return strstr(k + 1, s) - k != n;
}
