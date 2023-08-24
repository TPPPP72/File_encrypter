cmake_minimum_required(VERSION 3.0)

project(encrypt)


SET(_ROOT_SOURCES encrypt.cpp)
add_subdirectory(includes)
add_subdirectory(quote)
aux_source_directory(includes _SUB1_SOURCES)
aux_source_directory(quote _SUB2_SOURCES)

add_executable(${PROJECT_NAME} ${_ROOT_SOURCES} ${_SUB1_SOURCES} ${_SUB2_SOURCES})
