@echo off
mkdir build>nul 2>nul
g++ -Wall -static .\encrypt.cpp .\includes\PFile.cpp .\quote\base64.hpp -o .\build\encrypt.exe
strip .\build\encrypt.exe
echo.finished!
pause>nul
