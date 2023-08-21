#ifndef PFILE_H
#define PFILE_H

#include <iostream>
#include <string>
#include <filesystem>

int Pcopy(std::string input, std::string output, long long p);
int Premove(std::string p);
std::string Pgetfullpath(std::string argv, std::string path);
std::string Pgetinpath(std::string path);
std::string Pgetinpath(std::string argv, std::string path);

#endif