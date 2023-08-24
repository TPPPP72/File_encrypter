@echo off
mkdir build>nul 2>nul
g++ -Wall -static .\includes\PFile.cpp .\includes\PIO.hpp .\quote\base64.hpp .\encrypt.cpp -o .\build\encrypt.exe
strip .\build\encrypt.exe
echo.finished!
pause>nul
