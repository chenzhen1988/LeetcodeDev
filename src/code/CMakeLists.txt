IF(${testcase} MATCHES "all")
    FILE(GLOB_RECURSE
        src_file_list
        "${CMAKE_CURRENT_SOURCE_DIR}/src/*.cpp"
    )
ELSE()
	SET(src_file_list "${CMAKE_CURRENT_SOURCE_DIR}/src/${testcase}.cpp")
ENDIF()

TARGET_INCLUDE_DIRECTORIES(${target} PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/inc)

TARGET_SOURCES(${target} PUBLIC ${src_file_list})
