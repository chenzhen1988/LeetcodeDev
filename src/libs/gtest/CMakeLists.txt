TARGET_INCLUDE_DIRECTORIES(${target} PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/include)

TARGET_LINK_LIBRARIES(${target} ${CMAKE_CURRENT_SOURCE_DIR}/lib_linux/libgtest_main.a ${CMAKE_CURRENT_SOURCE_DIR}/lib_linux/libgtest.a pthread)
