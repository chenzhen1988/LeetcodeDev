/*
 * Copyright (c) Huawei Technologies Co., Ltd. 2018-2019. All rights reserved.
 * Description:    leetcode_003_lengthOfLongestSubstring
 */
#include "leetcode_003_lengthOfLongestSubstring.h"
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "securec.h"

int lengthOfLongestSubstring(char * s){
    int len_remind = 0;
    int win_l = 0;
    int win_r = 0;
    int i = 0;
    char *s_move = s;

    while (*s_move) {
        for (i = win_l; i < win_r; i++) {
            if (s[i] == *s_move) {
                len_remind = (len_remind > (win_r - win_l)) ? len_remind : (win_r - win_l);

                win_l = i + 1;
            }
        }

        win_r++;
        s_move++;
    }

    len_remind = (len_remind > win_r - win_l) ? len_remind : win_r - win_l;

    return len_remind;
}
