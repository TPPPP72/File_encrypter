// #include <string>
// #include <iostream>
#include <fstream>
#include "PFile.h"

// 复制文件
bool Pcopy(const std::string &input, const std::string &output, long long p)
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

// 删除文件
bool Premove(const std::string &p)
{
	std::filesystem::path rem = p;
	if (std::filesystem::exists(rem))
	{
		std::filesystem::remove_all(rem);
		return true;
	}
	return false;
}

// 获取文件的完整路径
std::string Pgetfullpath(const std::string &argv, std::string path)
{
	// 移除首尾空格
	while (path.front() == ' ')
		path.erase(path.begin());
	while (path.back() == ' ')
		path.erase(path.end() - 1);

	// 缓存运行路径
	std::string temp = argv;
	temp = temp.substr(0, temp.rfind('\\') + 1);

	// 判断.的存在
	if (path.front() == '.')
		path.erase(path.begin());

	// 判断\的存在
	if (path.front() == '\\')
	{
		path.erase(path.begin());
		return temp + path; // 拼接原串
	}

	// 判断是否是直接传入文件
	if (path.find('\\') == std::string::npos)
		return temp + path; // 拼接原串
	else
		return path;
}

//获取文件所在路径 v1 请保证传入的路径是完整的 否则程序会崩溃！
std::string Pgetinpath(const std::string &path){
	return path.substr(0, path.rfind('\\') + 1);
}

// 获取文件所在路径 v2
std::string Pgetinpath(const std::string &argv, const std::string &path)
{
	std::string temp = Pgetfullpath(argv, path);
	return temp.substr(0, temp.rfind('\\') + 1);
}