if(${testcase} MATCHES "all")
    FILE(GLOB_RECURSE
        src_file_list
        "${CMAKE_CURRENT_SOURCE_DIR}/src/*.cpp"
    )
else()
    set(src_file_list "${CMAKE_CURRENT_SOURCE_DIR}/src/${testcase}.cpp")
endif()

target_include_directories(${target} PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/inc)

target_sources(${target} PUBLIC ${src_file_list})
