#FILE(GLOB_RECURSE
#    lib_file_list
#    "${CMAKE_CURRENT_SOURCE_DIR}/lib_linux/*.a"
#)

target_include_directories(${target} PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/include)

target_link_libraries(${target} ${CMAKE_CURRENT_SOURCE_DIR}/lib_linux/libgtest_main.a ${CMAKE_CURRENT_SOURCE_DIR}/lib_linux/libgtest.a)
target_link_libraries(${target} pthread)
