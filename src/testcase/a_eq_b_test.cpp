#include "gtest/gtest.h"
#include <stdio.h>
#include "a_eq_b.h"

TEST(TEST_A_EQ_B, TEST_01)
{
    char *a = (char *)"1";
    char *b = (char *)"2";
    EXPECT_EQ(a_eq_b(a, b), false);
}

TEST(TEST_A_EQ_B, TEST_02)
{
    char *a = (char *)"2";
    char *b = (char *)"2";
    EXPECT_EQ(a_eq_b(a, b), true);
}

TEST(TEST_A_EQ_B, TEST_03)
{
    char *a = (char *)"3";
    char *b = (char *)"3.0";
    EXPECT_EQ(a_eq_b(a, b), true);
}

TEST(TEST_A_EQ_B, TEST_04)
{
    char *a = (char *)"4";
    char *b = (char *)"3";
    EXPECT_EQ(a_eq_b(a, b), false);
}

TEST(TEST_A_EQ_B, TEST_05)
{
    char *a = (char *)"3000";
    char *b = (char *)"3000";
    EXPECT_EQ(a_eq_b(a, b), true);
}

TEST(TEST_A_EQ_B, TEST_06)
{
    char *a = (char *)"3000";
    char *b = (char *)"3000.00";
    EXPECT_EQ(a_eq_b(a, b), true);
}
