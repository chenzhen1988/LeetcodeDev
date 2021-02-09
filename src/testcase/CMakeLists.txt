FILE(GLOB_RECURSE
    src_file_list
    "${CMAKE_CURRENT_SOURCE_DIR}/*.cpp"
)

target_sources(${target} PUBLIC ${src_file_list})
