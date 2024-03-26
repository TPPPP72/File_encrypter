// #include <string>
// #include <iostream>
#include <sys/stat.h>
#include <fstream>
#include "PFile.h"

// 检查文件类型 不存在 -> -1 目录 -> 0 文件 -> 1
int Pcheck(const std::string &path)
{
	struct stat info;
	if (stat(path.c_str(), &info) != 0)
		return -1;
	if (info.st_mode & S_IFDIR)
		return 0;
	if (info.st_mode & S_IFREG)
		return 1;
	return -1;
}

// 复制文件
bool Pcopy(const std::string &input, const std::string &output, const long long &p)
{
	std::ifstream r(input, std::ios::binary);
	if (!r.is_open())
		return false;
	r.seekg(0, std::ios::end);
	std::streamoff size = r.tellg();
	r.seekg(0, std::ios::beg);
	std::ofstream w(output, std::ios::binary);
	if (!w.is_open())
		return false;
	for (auto i = 0; i < size; i++)
		w.put(r.get() ^ p);
	r.close();
	w.close();
	return true;
}

// 获取文件的完整路径
std::string Pgetfullpath(const std::string &argv, std::string path)
{
	// 移除首尾空格
	while (path.front() == ' ')
		path.erase(path.begin());
	while (path.back() == ' ')
		path.erase(path.end() - 1);

	// 判断.的存在
	if (path.front() == '.')
		path.erase(path.begin());

	// 判断\的存在
	if (path.front() == '\\')
	{
		path.erase(path.begin());
		return argv + '\\' + path;
	}

	// 判断是否是直接传入文件
	if (path.find('\\') == std::string::npos)
		return argv + '\\' + path;
		
	return path;
}

// 获取文件所在路径 v1 请保证传入的路径是完整的 否则程序会崩溃！
std::string Pgetinpath(const std::string &path)
{
	return path.substr(0, path.rfind('\\') + 1);
}

// 获取文件所在路径 v2
std::string Pgetinpath(const std::string &argv, const std::string &path)
{
	std::string temp = Pgetfullpath(argv, path);
	return temp.substr(0, temp.rfind('\\') + 1);
}