cmake_minimum_required(VERSION 3.14)
project(TechnicalRadiation)

set(CMAKE_CXX_STANDARD 14)

add_executable(TechnicalRadiation
        cmake-build-debug/cmake_install.cmake
        cmake-build-debug/CMakeCache.txt
        cmake-build-debug/Makefile
        cmake-build-debug/TechnicalRadiation.cbp
        Envelope.cs
        HyperMediaExtensions.cs
        HyperMediaModel.cs
        main.cpp
        README.md)
