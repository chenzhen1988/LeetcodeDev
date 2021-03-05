/*
 * Copyright (c) Huawei Technologies Co., Ltd. 2018-2019. All rights reserved.
 * Description:    leetcode_1576_modify_string
 */
#include "leetcode_1576_modify_string.h"
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "securec.h"

char GetValidChr(char left, char right) {
    for (char i = 'a'; i <= 'z'; i++) {
        if (i != left && i != right) {
            return i;
        }
    }
    return 0;
}

char * modifyString(char *s){
    int sLen = strlen(s);
    int sLeft = sLen;

    for (int i = 0; i < sLen; i++) {
        sLeft--;
        if (i == 0) {
            if (s[i] == '?' && sLeft > 0) {
                s[i] = GetValidChr(0, s[i + 1]);
            } else if (s[i] == '?' && sLeft <= 0) {
                s[i] = 'a';
            }
        } else if (i == sLen - 1) {
            if (s[i] == '?') {
                s[i] = GetValidChr(s[i - 1], 0);
            }
        } else {
            if (s[i] == '?') {
                s[i] = GetValidChr(s[i - 1], s[i + 1]);
            }
        }
    }
    return s;
}
