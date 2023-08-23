#ifndef PFILE_H
#define PFILE_H

#include <iostream>
#include <string>

int Pcheck(const std::string &path);
bool Pcopy(const std::string &input, const std::string &output, const long long &p);
std::string Pgetfullpath(const std::string &argv, std::string path);
std::string Pgetinpath(const std::string &path);
std::string Pgetinpath(const std::string &argv, const std::string &path);

#endif