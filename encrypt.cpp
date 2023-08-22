#include <vector>
#include "PFile.h"
#include "base64.hpp"

constexpr int size = 4;

long long getkey(const std::string &s);

int main(int argc, char **argv)
{
    // 参数数量校验
    if (argc != size)
    {
        std::cout << "Usage: [options(encode/decode)] [file] [password]";
        return 1;
    }

    // 复制原参数
    std::vector<std::string> per(size);
    for (auto i = 0; i <= size - 1; i++)
        per[i] = argv[i];

    // 检查选项参数
    if (per[1] != "encode" && per[1] != "decode")
    {
        std::cout << "Undefined option!";
        return 2;
    }

    // 初始化输入输出路径
    std::string input, output;
    input = Pgetfullpath(per[0], per[2]);
    output = Pgetinpath(input);

    // 检查文件是否存在
    if (!std::filesystem::exists(std::filesystem::path(input)))
    {
        std::cout << "No this file!";
        return 3;
    }

    // 确定输出文件完整路径
    std::string filename = input.substr(input.rfind("\\") + 1);
    if (per[1] == "encode")
    {
        filename = base64::to_base64(filename);
        while (filename.back() == '=')
            filename.erase(filename.end() - 1);
        output += filename;
    }
    else
    {
        while (filename.length() % 4)
            filename += '=';
        filename = base64::from_base64(filename);
        output += filename;
    }

    //  计算key值
    long long key = getkey(per[3]);

    // 加密
    std::cout << "Running......" << std::endl;
    Pcopy(input, output, key);
    if (per[1] == "encode")
        std::cout << "Encoded";
    else
        std::cout << "Decoded";
    std::cout << " file is declared to:" << output;

    // 退出程序
    return 0;
}

long long getkey(const std::string &s)
{
    constexpr int mod1 = 1919810, mod2 = 998244353;
    long long key = 0, base = 1;
    for (int i : s)
        key += i * base, base *= 10, base %= mod1, key %= mod2;
    return key;
}