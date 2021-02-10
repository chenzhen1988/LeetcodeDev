CMAKE_MINIMUM_REQUIRED(VERSION 2.8.12)

CMAKE_POLICY(SET CMP0079 NEW)

# Variables
SET(target "main.exe")
SET(support_libs
        "common"
        "panic"
        "libsec"
        "gtest"
)
SET(testcase ${T})

# set the project name
PROJECT(LeetcodeDev)

# add the executable
ADD_EXECUTABLE(${target})

# add the sub dirs.
ADD_SUBDIRECTORY(src)
