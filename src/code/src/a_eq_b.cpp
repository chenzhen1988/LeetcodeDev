#include <stdio.h>
#include "a_eq_b.h"

bool a_eq_b(char *a, char *b)
{
    char *a_move = a;
    char *b_move = b;
    char *left_move;

    while (*a_move != '\0' && *b_move != '\0') {
        if (*a_move != *b_move) {
            return false;
        }

        a_move++;
        b_move++;
    }

    left_move = *a_move == '\0' ? b_move : a_move;

    if (*left_move == '.') {
        left_move++;
    }

    while (*left_move != '\0') {
            if (*left_move != '0') {
                return false;
            }
            left_move++;
        }

    return true;
}
