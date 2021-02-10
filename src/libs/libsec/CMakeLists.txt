FILE(GLOB_RECURSE
    src_file_list
    "${CMAKE_CURRENT_SOURCE_DIR}/src/*.c"
)

TARGET_INCLUDE_DIRECTORIES(${target} PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/include)

TARGET_SOURCES(${target} PUBLIC ${src_file_list})
