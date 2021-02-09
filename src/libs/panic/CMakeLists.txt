FILE(GLOB_RECURSE
    src_file_list
    "${CMAKE_CURRENT_SOURCE_DIR}/src/*.cpp"
)

target_include_directories(${target} PUBLIC ${CMAKE_CURRENT_SOURCE_DIR}/include)

target_sources(${target} PUBLIC ${src_file_list})
