if(${testcase} MATCHES "all")
    FILE(GLOB_RECURSE
        src_file_list
        "${CMAKE_CURRENT_SOURCE_DIR}/*.cpp"
    )
else()
    set(src_file_list "${CMAKE_CURRENT_SOURCE_DIR}/${testcase}_test.cpp")
endif()

target_sources(${target} PUBLIC ${src_file_list})
