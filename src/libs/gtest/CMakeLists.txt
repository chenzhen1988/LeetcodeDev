FILE(GLOB_RECURSE
    lib_file_list
    "${CMAKE_CURRENT_SOURCE_DIR}/lib_linux/*.a"
)

target_include_directories(${target} PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/include)

target_link_libraries(${target} ${lib_file_list})
target_link_libraries(${target} pthread)
