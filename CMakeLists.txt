CMAKE_MINIMUM_REQUIRED(VERSION 2.8.12)

CMAKE_POLICY(SET CMP0079 NEW)

# Variables
SET(target "main.exe")
SET(support_libs
        "common"
        "panic"
        "libsec"
        "gtest"
	"libcstl"
)
SET(testcase ${T})

# set the project name
PROJECT(LeetcodeDev)

IF (testcase MATCHES "doc")
    add_custom_target(doc ALL
        COMMAND doxygen ./../tools/doxygen/Doxyfile
        )
    RETURN()
ENDIF()

# add the executable
ADD_EXECUTABLE(${target})

# add the sub dirs.
ADD_SUBDIRECTORY(src)
