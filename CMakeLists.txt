cmake_minimum_required(VERSION 3.10)

project(encrypt)

SET(SRC_LIST encrypt.cpp PFile.cpp base64.hpp)

add_executable(${PROJECT_NAME} ${SRC_LIST})