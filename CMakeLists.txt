  
cmake_minimum_required(VERSION 2.8.12)

cmake_policy(SET CMP0079 NEW)

# Variables
set(target "main.exe")
set(support_libs
        "common"
        "panic"
        "libsec"
        "gtest"
)

# set the project name
project(LeetcodeDev)

# add the executable
add_executable(${target})

# add the sub dirs.
add_subdirectory(src)
