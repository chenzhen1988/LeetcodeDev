IF(${testcase} MATCHES "all")
    FILE(GLOB_RECURSE
        src_file_list
        "${CMAKE_CURRENT_SOURCE_DIR}/*.cpp"
    )
ELSE()
    set(src_file_list "${CMAKE_CURRENT_SOURCE_DIR}/${testcase}_test.cpp")
ENDIF()

TARGET_SOURCES(${target} PUBLIC ${src_file_list})
